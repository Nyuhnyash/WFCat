namespace WFCat
{
    partial class ProfileForm
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
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMidname = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMidname = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(70, 36);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastname.TabIndex = 0;
            this.textBoxLastname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLastname_MouseClick);
            this.textBoxLastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxLastname_KeyDown);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(70, 62);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxMidname
            // 
            this.textBoxMidname.Location = new System.Drawing.Point(70, 88);
            this.textBoxMidname.Name = "textBoxMidname";
            this.textBoxMidname.Size = new System.Drawing.Size(100, 20);
            this.textBoxMidname.TabIndex = 2;
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
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(12, 117);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 6;
            this.labelId.Text = "ID";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelMidname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.textBoxMidname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLastname);
            this.Name = "ProfileForm";
            this.Text = "Профиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMidname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMidname;
        private System.Windows.Forms.Label labelId;

    }
}

