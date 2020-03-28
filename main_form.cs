using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

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
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {
                dbname = saveFileDialog1.FileName;
                SQLiteConnection.CreateFile(dbname);                
            }
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
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            dbconn = new SQLiteConnection();
            sqlcmd = new SQLiteCommand();            
            toolStripStatusLabel1.Text = "Подключение не установлено";
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Пожалуйста, создайте базу данных и пустую таблицу. Нажмите \"Создать\"");
                return;
            }
            else
            {
                dbname = openFileDialog1.FileName;
            }
            try
            {
                dbconn = new SQLiteConnection("Data Source=" + dbname + ";Version=3;");
                dbconn.Open();
                sqlcmd.Connection = dbconn;
                select_Click(sender, e);

                toolStripStatusLabel1.Text = "Подключение установлено";
            }
            catch (SQLiteException ex)
            {
                toolStripStatusLabel1.Text = "Подключение не установлено";
                MessageBox.Show("Ошибка: " + ex.Message);
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
                dgv.Visible = true;
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
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (dbconn.State != ConnectionState.Open)
            {
                MessageBox.Show("Откройте соединение с базой данных");
                return;
            }

            addData addData = new addData();
            if (addData.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sqlcmd.CommandText = "INSERT INTO passwords ('name', 'login', 'password', 'site', 'description') values (@name, @login, @password, @site, @desc)";
                    sqlcmd.Parameters.Add(new SQLiteParameter("@name", addData.tbName.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@login", addData.tbLogin.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@password", addData.tbPass.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@site", addData.tbSite.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@desc", addData.tbDesc.Text));
                    sqlcmd.ExecuteNonQuery();
                    select_Click(sender, e);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (dbconn.State != ConnectionState.Open)
            {
                MessageBox.Show("Откройте соединение с базой данных");
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
                    select_Click(sender, e);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if (dbconn.State != ConnectionState.Open)
            {
                MessageBox.Show("Откройте соединение с базой данных");
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
                try
                {
                    sqlcmd.CommandText = "UPDATE passwords SET name = @name, login = @login, password = @password, site = @site, description = @desc WHERE id = @id";
                    sqlcmd.Parameters.Add(new SQLiteParameter("@name", fmUpd.tbName.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@login", fmUpd.tbLogin.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@password", fmUpd.tbPass.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@site", fmUpd.tbSite.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@desc", fmUpd.tbDesc.Text));
                    sqlcmd.Parameters.Add(new SQLiteParameter("@id", fmUpd.tbID.Text));
                    sqlcmd.ExecuteNonQuery();
                    select_Click(sender, e);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (dbconn.State != ConnectionState.Open)
            {
                MessageBox.Show("Откройте соединение с базой данных");
                return;
            }
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

