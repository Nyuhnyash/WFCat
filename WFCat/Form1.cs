using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFCat
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void textBoxLastname_MouseClick(object sender, MouseEventArgs e)
        {
            Student st1 = new Student();
        }

        private void textBoxLastname_KeyDown(object sender, KeyEventArgs e)
        {
          Student st1;
            if (e.KeyCode == Keys.Enter)
                 st1 = new Student(textBoxLastname.Text, textBoxName.Text, textBoxMidname.Text);
        }
    }
        public  class Student
        {
            public Student()
            {
                lastname = "";
                name = "";
                midname = "";
            }
            public Student(string lastname, string name, string midname)
            {
                this.lastname = lastname;
                this.name = name;
                this.midname = midname;
            }
            public void Out()
            {
                Console.WriteLine(this.lastname, this.name, this, midname);
            }
            public string lastname, name, midname;
        }

    }