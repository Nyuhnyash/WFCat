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
            if (stud.id == -1)
                labelId.Text = "-";
            else
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

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text);
            stud.Save();
            stud = new Student();
            if (stud.Load() == 1)
            {
                TextBoxLastname.Text = "";
                TextBoxName.Text = "";
                TextBoxMidname.Text = "";
            }
            Show();
        }
        
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            stud = new Student();
            stud.Load(openFileDialog.FileName);
            Show();
        }

        private void TextBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Return)
            //    TextBoxName.SelectNextControl();
        }

        private void checkBoxRo_CheckedChanged(object sender, EventArgs e)
        {
            Student.ro = !Student.ro;
        }
    }

    public partial class Student
    {
        public Student()
        {
            lastname = name = midname = "";
            id = lastid;
            path = paths + id + "." + ext[0];
        }
        public Student(string lastname, string name, string midname)
        {
            this.lastname = lastname;
            this.name = name;
            this.midname = midname;
            id = lastid;
            lastid++;
            path = paths + id + "." + ext[0];
        }
        //public void SaveNew()
        //{
        //    while (File.Exists(paths + id + "." + ext[0]));
        //    id++;
        //}
        public void Save()
        { 
            Save(path);
        } // Save old
        public void Save(string path) // to file
        {
            StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            writer.Write("{0}\r\n{1}\r\n{2}\r\n{3}", lastname, name, midname, id);
            writer.Close();
            //new MainForm().notifyIconSaved.ShowBalloonTip(500);
        }
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
        public int Load()
        {
            if (File.Exists(path))
            {
                Load(path);
                return 0;
            }
            else
                if (ro)
                {
                    id = 1;
                    lastid = 1;
                    path = paths + 1 + "." + ext[0];
                    Load(path);
                    return 0;
                } else
                return 1;
        }
        public void FirstLoad() // Load from file
        {
            int i = 0;
            if (!File.Exists(path))
                return;
            Load(path);
        }

        public void Load(string path) // from path (openFileDialog)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            switch (path.Substring(path.Length - 3).ToLower())
            {
                case "txt":
                    LoadTXT(fs);
                    break;
                case "bin":
                    LoadBIN(fs);

                    break;
                case "byte":
                    LoadBYTE(fs);
                    break;
            }
            fs.Close();
        }
        public void LoadTXT(FileStream fs)
        {
            StreamReader reader = new StreamReader(fs);
            lastname = reader.ReadLine();
            name = reader.ReadLine();
            midname = reader.ReadLine();
            id = int.Parse(reader.ReadLine());
            reader.Close();
        }
        public void LoadBIN(FileStream fs)
        {
            BinaryReader reader = new BinaryReader(fs);
            lastname = reader.ReadString();
            name = reader.ReadString();
            midname = reader.ReadString();
            id = reader.ReadInt32();
            reader.Close();
        }
        public void LoadBYTE(FileStream fs)
        {

        }
        //public int id
        //{
        //    get => id;
        //    set
        //    {
        //        id = lastid;
        //    }
        //}
        static public bool ro = false;
        public int id;
        static int lastid = 1;
        static readonly string paths = "students/student";
        public string lastname, name, midname, path;
        private readonly string[] ext = { "txt"/*, "bin", "dat" */};
    }

}