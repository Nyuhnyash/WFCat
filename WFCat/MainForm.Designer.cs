namespace WFCat
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TextBoxLastname = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxMidname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMidname = new System.Windows.Forms.Label();
            this.labelIdUseless = new System.Windows.Forms.Label();
            this.notifyIconSaved = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найстройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.автосохранениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.толькоДляЧтенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxLastname
            // 
            this.TextBoxLastname.Location = new System.Drawing.Point(70, 62);
            this.TextBoxLastname.Name = "TextBoxLastname";
            this.TextBoxLastname.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLastname.TabIndex = 0;
            this.TextBoxLastname.TextChanged += new System.EventHandler(this.TextBoxNames_TextChanged);
            this.TextBoxLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxLastname_KeyPress);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(70, 88);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 1;
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxNames_TextChanged);
            this.TextBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxName_KeyPress);
            // 
            // TextBoxMidname
            // 
            this.TextBoxMidname.Location = new System.Drawing.Point(70, 114);
            this.TextBoxMidname.Name = "TextBoxMidname";
            this.TextBoxMidname.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMidname.TabIndex = 2;
            this.TextBoxMidname.TextChanged += new System.EventHandler(this.TextBoxNames_TextChanged);
            this.TextBoxMidname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxMidname_KeyPress);
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(12, 65);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(53, 17);
            this.labelLastname.TabIndex = 3;
            this.labelLastname.Text = "Фамилия";
            this.labelLastname.UseCompatibleTextRendering = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            // 
            // labelMidname
            // 
            this.labelMidname.AutoSize = true;
            this.labelMidname.Location = new System.Drawing.Point(12, 117);
            this.labelMidname.Name = "labelMidname";
            this.labelMidname.Size = new System.Drawing.Size(54, 13);
            this.labelMidname.TabIndex = 5;
            this.labelMidname.Text = "Отчество";
            // 
            // labelIdUseless
            // 
            this.labelIdUseless.AutoSize = true;
            this.labelIdUseless.Location = new System.Drawing.Point(12, 39);
            this.labelIdUseless.Name = "labelIdUseless";
            this.labelIdUseless.Size = new System.Drawing.Size(18, 13);
            this.labelIdUseless.TabIndex = 6;
            this.labelIdUseless.Text = "ID";
            // 
            // notifyIconSaved
            // 
            this.notifyIconSaved.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIconSaved.BalloonTipText = "Сохранено";
            this.notifyIconSaved.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSaved.Icon")));
            this.notifyIconSaved.Text = "WFCat";
            this.notifyIconSaved.Visible = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(197, 289);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Вперед";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(67, 39);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(10, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "-";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "student0.txt";
            this.openFileDialog.Filter = "*.txt|*.txt|*.bin|*.bin|*.dat|*.dat";
            this.openFileDialog.InitialDirectory = "./students";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(12, 289);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 3;
            this.buttonPrev.Text = "Назад";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(257, 143);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Предмет";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "Оценка";
            this.Column2.Name = "Column2";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(WFCat.Student);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.найстройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.ОткрытьToolStripMenuItem_Click);
            // 
            // найстройкиToolStripMenuItem
            // 
            this.найстройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.автосохранениеToolStripMenuItem,
            this.толькоДляЧтенияToolStripMenuItem});
            this.найстройкиToolStripMenuItem.Name = "найстройкиToolStripMenuItem";
            this.найстройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.найстройкиToolStripMenuItem.Text = "Настройки";
            // 
            // автосохранениеToolStripMenuItem
            // 
            this.автосохранениеToolStripMenuItem.CheckOnClick = true;
            this.автосохранениеToolStripMenuItem.Name = "автосохранениеToolStripMenuItem";
            this.автосохранениеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.автосохранениеToolStripMenuItem.Text = "Автосохранение";
            this.автосохранениеToolStripMenuItem.Click += new System.EventHandler(this.АвтосохранениеToolStripMenuItem_Click);
            // 
            // толькоДляЧтенияToolStripMenuItem
            // 
            this.толькоДляЧтенияToolStripMenuItem.CheckOnClick = true;
            this.толькоДляЧтенияToolStripMenuItem.Name = "толькоДляЧтенияToolStripMenuItem";
            this.толькоДляЧтенияToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.толькоДляЧтенияToolStripMenuItem.Text = "Только для чтения";
            this.толькоДляЧтенияToolStripMenuItem.Click += new System.EventHandler(this.ТолькоДляЧтенияToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelIdUseless);
            this.Controls.Add(this.labelMidname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.TextBoxMidname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxLastname);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMidname;
        private System.Windows.Forms.Label labelIdUseless;
        public System.Windows.Forms.NotifyIcon notifyIconSaved;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxMidname;
        private System.Windows.Forms.TextBox TextBoxLastname;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найстройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem толькоДляЧтенияToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ToolStripMenuItem автосохранениеToolStripMenuItem;
    }
}

