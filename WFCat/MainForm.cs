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
        private Student stud;

        private void Show()
        {
            TextBoxLastname.Text = stud.lastname;
            TextBoxName.Text = stud.name;
            TextBoxMidname.Text = stud.midname;
            labelId.Text = stud.id.ToString();
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("./students"))
                Directory.CreateDirectory("./students");
            stud = new Student();
            stud.FirstLoad();
            Show();
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
            openFileDialog.ShowDialog();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text);
            stud.Save();
            Show();
        }
        
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            stud = new Student();
            stud.Load(openFileDialog.FileName);
            Show();
        }
    }

    public partial class Student
    {
        public Student()
        {
            lastname = "";
            name = "";
            midname = "";
            id = -1;
        }
        public Student(string lastname, string name, string midname)
        {
            this.lastname = lastname;
            this.name = name;
            this.midname = midname;
            id = lastid;
            lastid++;
        }
        public void Save() // to file
        {
            foreach (string e in ext)
            {
                do
                {
                    id++;
                    path = paths + (id) + ".";
                }
                while (File.Exists(path + e));
                StreamWriter writer = new StreamWriter(new FileStream(path + e, FileMode.Create, FileAccess.Write));
                writer.Write("{0}\r\n{1}\r\n{2}\r\n{3}", lastname, name, midname, id);
                writer.Close();
                Load(path + e);
                new MainForm().notifyIconSaved.ShowBalloonTip(500);
            }
        }

        public void FirstLoad() // from file
        {

            int i = 0;

            /* Если не найдено расширение .txt
            bool b = true;
            while (b)
            {
                path = paths + id + ".";
                try
                {
                    new FileStream(path + ext[i], FileMode.Open, FileAccess.Read);
                    b = false;
                }
                catch (FileNotFoundException)
                {
                    i++;
                }
            }
            */

            path = paths + "0.";
            try
            {
                new FileStream(path + ext[i], FileMode.Open, FileAccess.Read);
            }
            catch (FileNotFoundException)
            {
                return;
            }
            Load(path + ext[i]);
        }

        public void Load(string path) // from path (openFileDialog)
        {
            StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));
            lastname = reader.ReadLine();
            name = reader.ReadLine();
            midname = reader.ReadLine();
            id = int.Parse(reader.ReadLine());
            reader.Close();
        }

        //public int Id
        //{
        //    get { return id; }
        //    set
        //    {
        //        if (id < 0)
        //        {
        //            id = lastid;
        //            lastid++;
        //        }
        //    }
        //}

        public int id;
        static private int lastid = 0;
        static private readonly string paths = "./students/student";
        public string lastname, name, midname, path;
        private readonly string[] ext = { "txt"/*, "bin", "dat" */};
    }

}