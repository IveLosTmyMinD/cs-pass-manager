namespace cp_pass_manager
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.create = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
            this.данныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.select = new System.Windows.Forms.ToolStripMenuItem();
            this.insert = new System.Windows.Forms.ToolStripMenuItem();
            this.btUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.speedSelect = new System.Windows.Forms.ToolStripButton();
            this.speedAdd = new System.Windows.Forms.ToolStripButton();
            this.speedRemove = new System.Windows.Forms.ToolStripButton();
            this.speedEdit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.данныеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.create,
            this.open,
            this.toolStripMenuItem1,
            this.close});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // create
            // 
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(121, 22);
            this.create.Text = "Создать";
            this.create.Click += new System.EventHandler(this.create_click);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(121, 22);
            this.open.Text = "Открыть";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 6);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(121, 22);
            this.close.Text = "Выход";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // данныеToolStripMenuItem
            // 
            this.данныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.select,
            this.insert,
            this.btUpdate,
            this.delete});
            this.данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            this.данныеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.данныеToolStripMenuItem.Text = "Данные";
            // 
            // select
            // 
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(154, 22);
            this.select.Text = "Прочесть";
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // insert
            // 
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(154, 22);
            this.insert.Text = "Добавить";
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(154, 22);
            this.btUpdate.Text = "Редактировать";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(154, 22);
            this.delete.Text = "Удалить";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(641, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // dgv
            // 
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.login,
            this.password,
            this.site,
            this.description});
            this.dgv.Location = new System.Drawing.Point(0, 52);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(933, 415);
            this.dgv.TabIndex = 2;
            this.dgv.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // login
            // 
            this.login.HeaderText = "Логин";
            this.login.Name = "login";
            // 
            // password
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.password.DefaultCellStyle = dataGridViewCellStyle4;
            this.password.HeaderText = "Пароль";
            this.password.Name = "password";
            // 
            // site
            // 
            this.site.HeaderText = "Сайт";
            this.site.Name = "site";
            // 
            // description
            // 
            this.description.HeaderText = "Описание";
            this.description.Name = "description";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(0, 467);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(205, 22);
            this.tbSearch.TabIndex = 3;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(212, 467);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(87, 27);
            this.btSearch.TabIndex = 4;
            this.btSearch.Text = "Поиск";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Файл базы данных (*.db)|*.db|Все файлы (*.*)|*.*";
            this.saveFileDialog1.Title = "Сохранить базу";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Файл базы данных (*.db)|*.db|Все файлы (*.*)|*.*";
            this.openFileDialog1.Title = "Открыть базу";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speedSelect,
            this.speedAdd,
            this.speedRemove,
            this.speedEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // speedSelect
            // 
            this.speedSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.speedSelect.Image = ((System.Drawing.Image)(resources.GetObject("speedSelect.Image")));
            this.speedSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speedSelect.Name = "speedSelect";
            this.speedSelect.Size = new System.Drawing.Size(23, 22);
            this.speedSelect.Text = "toolStripButton1";
            this.speedSelect.Click += new System.EventHandler(this.speedSelect_Click);
            // 
            // speedAdd
            // 
            this.speedAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.speedAdd.Image = ((System.Drawing.Image)(resources.GetObject("speedAdd.Image")));
            this.speedAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speedAdd.Name = "speedAdd";
            this.speedAdd.Size = new System.Drawing.Size(23, 22);
            this.speedAdd.Text = "toolStripButton2";
            this.speedAdd.Click += new System.EventHandler(this.speedAdd_Click);
            // 
            // speedRemove
            // 
            this.speedRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.speedRemove.Image = ((System.Drawing.Image)(resources.GetObject("speedRemove.Image")));
            this.speedRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speedRemove.Name = "speedRemove";
            this.speedRemove.Size = new System.Drawing.Size(23, 22);
            this.speedRemove.Text = "toolStripButton3";
            this.speedRemove.Click += new System.EventHandler(this.speedRemove_Click);
            // 
            // speedEdit
            // 
            this.speedEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.speedEdit.Image = ((System.Drawing.Image)(resources.GetObject("speedEdit.Image")));
            this.speedEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.speedEdit.Name = "speedEdit";
            this.speedEdit.Size = new System.Drawing.Size(23, 22);
            this.speedEdit.Text = "toolStripButton4";
            this.speedEdit.Click += new System.EventHandler(this.speedEdit_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 519);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem create;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem данныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem select;
        private System.Windows.Forms.ToolStripMenuItem insert;
        private System.Windows.Forms.ToolStripMenuItem btUpdate;
        private System.Windows.Forms.ToolStripMenuItem delete;
        public System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn site;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton speedSelect;
        private System.Windows.Forms.ToolStripButton speedAdd;
        private System.Windows.Forms.ToolStripButton speedRemove;
        private System.Windows.Forms.ToolStripButton speedEdit;
    }
}

