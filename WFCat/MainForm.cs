using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WFCat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //private void TextBoxLastname_KeyDown(object sender, KeyEventArgs e)
        //{
        //    Student stud;
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //    }
        //}

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.Load();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Student stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text);
            stud.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("./students");
            TextBoxLastname.Text = "Фамилия";
        }
    }

    public class Student
    {
        public Student()
        {
            lastname = "";
            name = "";
            midname = "";
            id = lastid;
            lastid++;
            path = paths + id + ".";
        }
        public Student(string lastname, string name, string midname)
        {
            this.lastname = lastname;
            this.name = name;
            this.midname = midname;
            id = lastid;
            lastid++;
            path = paths + id + "."; 
        }
        public void Save() // to file
        {
            foreach (string e in ext)
            {
                StreamWriter writer = new StreamWriter(new FileStream(path + e, FileMode.Create, FileAccess.Write));
                writer.Write("{0}\r\n{1}\r\n{2}", lastname, name, midname);
                writer.Close();
                MainForm form = new MainForm();
                form.notifyIconSaved.ShowBalloonTip(500);
            }
        }
        public void Load() // from file
        {
            int i = 0;
        start:
            string e = ext[i];
            try
            {
                FileStream tryfile = new FileStream(path + e, FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException)
            {
                if (i < ext.Length)
                {
                    i++;
                    goto start;
                }
                else /*error*/ ;
            }
            StreamReader reader = new StreamReader(new FileStream(path + e, FileMode.Open, FileAccess.Read));
            MainForm form = new MainForm();
            form.TextBoxLastname.Text = "123";
            form.TextBoxName.Text = reader.ReadLine();
            form.TextBoxMidname.Text = reader.ReadLine();
            reader.Close();
        }
        public string lastname, name, midname, path;
        private readonly string paths = "./students/student";
        private readonly string[] ext = { "txt", "bin", "dat" };
        public int id = 0;
        private int lastid = 0;
    }

}