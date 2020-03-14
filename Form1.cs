﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace cp_pass_manager
{
    public partial class mainForm : Form
    {
        public String dbname;
        public SQLiteConnection dbconn;
        public SQLiteCommand sqlcmd;
        public static string dID, dName;
        DialogResult result;
        public mainForm()
        {
            InitializeComponent();

        }

        private void create_click(object sender, EventArgs e)
        {
            if (!File.Exists(dbname))
                SQLiteConnection.CreateFile(dbname);
            try
            {
                dbconn = new SQLiteConnection("Data Source=" + dbname + ";Version=3;");
                dbconn.Open();
                sqlcmd.Connection = dbconn;

                sqlcmd.CommandText = "CREATE TABLE IF NOT EXISTS passwords (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, login TEXT NOT NULL, password TEXT NOT NULL, site TEXT, description TEXT)";
                sqlcmd.ExecuteNonQuery();
                toolStripStatusLabel1.Text = "Подключение установлено";
            }
            catch (SQLiteException ex)
            {
                toolStripStatusLabel1.Text = "Подключение не установлено";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            dbconn = new SQLiteConnection();
            sqlcmd = new SQLiteCommand();

            dbname = "passwords.db";
            toolStripStatusLabel1.Text = "Подключение не установлено";
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbname))
                MessageBox.Show("Пожалуйста, создайте базу данных и пустую таблицу. Нажмите \"Создать\"");

            try
            {
                dbconn = new SQLiteConnection("Data Source=" + dbname + ";Version=3;");
                dbconn.Open();
                sqlcmd.Connection = dbconn;

                toolStripStatusLabel1.Text = "Подключение установлено";
            }
            catch (SQLiteException ex)
            {
                toolStripStatusLabel1.Text = "Подключение не установлено";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void select_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            String sqlQuery;

            if (dbconn.State != ConnectionState.Open)
            {
                MessageBox.Show("Откройте соединение с базой данных");
                return;
            }

            try
            {
                sqlQuery = "SELECT * FROM passwords";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dbconn);
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    dgv.Rows.Clear();
                    for (int i = 0; i < dTable.Rows.Count; i++)
                    {
                        dgv.Rows.Add(dTable.Rows[i].ItemArray);
                    }
                    dgv.ClearSelection();
                }
                else
                    MessageBox.Show("База данных пуста");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (dbconn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }

            addData addData = new addData();
            if (addData.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sqlcmd.CommandText = "INSERT INTO passwords ('name', 'login', 'password', 'site', 'description') values ('" +
                        addData.Name + "','" + addData.Login + "','" +
                        addData.Password + "','" + addData.Site + "','" +
                        addData.Description + "')";

                    sqlcmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dbconn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }
            try
            {
                dID = dgv.CurrentRow.Cells[0].Value.ToString();
                dName = dgv.CurrentRow.Cells[1].Value.ToString();
                result = MessageBox.Show("Вы уверены, что хотите удалить " + dName + "?", "Подтвердите", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    sqlcmd.CommandText = "DELETE FROM passwords WHERE ID = '" + dID + "'";
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dbconn.State != ConnectionState.Open)
            {
                MessageBox.Show("Open connection with database");
                return;
            }
            updateForm fmUpd = new updateForm();
            fmUpd.tbID.Text = this.dgv.CurrentRow.Cells[0].Value.ToString();
            fmUpd.tbName.Text = this.dgv.CurrentRow.Cells[1].Value.ToString();
            fmUpd.tbLogin.Text = this.dgv.CurrentRow.Cells[2].Value.ToString();
            fmUpd.tbPass.Text = this.dgv.CurrentRow.Cells[3].Value.ToString();
            fmUpd.tbSite.Text = this.dgv.CurrentRow.Cells[4].Value.ToString();
            fmUpd.tbDesc.Text = this.dgv.CurrentRow.Cells[5].Value.ToString();
            //fmUpd.Show();
            if (fmUpd.ShowDialog() == DialogResult.OK)
            {
                sqlcmd.CommandText = "UPDATE passwords SET name = @name, login = @login, password = @password, site = @site, description = @desc WHERE id = @id";
                sqlcmd.Parameters.Add(new SQLiteParameter("@name", fmUpd.tbName.Text));
                sqlcmd.Parameters.Add(new SQLiteParameter("@login", fmUpd.tbLogin.Text));
                sqlcmd.Parameters.Add(new SQLiteParameter("@password", fmUpd.tbPass.Text));
                sqlcmd.Parameters.Add(new SQLiteParameter("@site", fmUpd.tbSite.Text));
                sqlcmd.Parameters.Add(new SQLiteParameter("@desc", fmUpd.tbDesc.Text));
                sqlcmd.Parameters.Add(new SQLiteParameter("@id", fmUpd.tbID.Text));
                sqlcmd.ExecuteNonQuery();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[1].Selected = false;
                for (int j = 0; j < dgv.ColumnCount; j++)
                    if (dgv.Rows[i].Cells[j].Value != null)
                        if (dgv.Rows[i].Cells[j].Value.ToString().Contains(tbSearch.Text))
                        {
                            dgv.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        
    }
}

