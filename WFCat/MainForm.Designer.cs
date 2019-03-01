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
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // TextBoxLastname
            // 
            this.TextBoxLastname.Location = new System.Drawing.Point(70, 36);
            this.TextBoxLastname.Name = "TextBoxLastname";
            this.TextBoxLastname.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLastname.TabIndex = 0;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(70, 62);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 1;
            // 
            // TextBoxMidname
            // 
            this.TextBoxMidname.Location = new System.Drawing.Point(70, 88);
            this.TextBoxMidname.Name = "TextBoxMidname";
            this.TextBoxMidname.Size = new System.Drawing.Size(100, 20);
            this.TextBoxMidname.TabIndex = 2;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(12, 39);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(53, 17);
            this.labelLastname.TabIndex = 3;
            this.labelLastname.Text = "Фамилия";
            this.labelLastname.UseCompatibleTextRendering = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Имя";
            // 
            // labelMidname
            // 
            this.labelMidname.AutoSize = true;
            this.labelMidname.Location = new System.Drawing.Point(12, 91);
            this.labelMidname.Name = "labelMidname";
            this.labelMidname.Size = new System.Drawing.Size(54, 13);
            this.labelMidname.TabIndex = 5;
            this.labelMidname.Text = "Отчество";
            // 
            // labelIdUseless
            // 
            this.labelIdUseless.AutoSize = true;
            this.labelIdUseless.Location = new System.Drawing.Point(12, 117);
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
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(12, 227);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(197, 227);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(67, 117);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.labelIdUseless);
            this.Controls.Add(this.labelMidname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.TextBoxMidname);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.TextBoxLastname);
            this.Name = "MainForm";
            this.Text = "Профиль";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMidname;
        private System.Windows.Forms.Label labelIdUseless;
        public System.Windows.Forms.NotifyIcon notifyIconSaved;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxMidname;
        private System.Windows.Forms.TextBox TextBoxLastname;
        private System.Windows.Forms.Label labelId;
    }
}

