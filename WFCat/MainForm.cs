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
            if (!Directory.Exists("students"))
                Directory.CreateDirectory("students");
            stud = new Student();
            stud.Load();
            Show();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text);
            stud.Save();
            //notifyIconSaved.ShowBalloonTip(500);
            buttonPrev.Enabled = true;
            if (Student.ro)
            {
                Student.lastid += 2;
                stud = new Student();
                if (!stud.FileExists())
                {
                    buttonNext.Enabled = false;
                }
                Student.lastid--;
            }
            else
                Student.lastid++;
            stud = new Student();
            stud.Load();
            Show();
        }
        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text);
            buttonNext.Enabled = true;
            buttonPrev.Enabled = --Student.lastid == 1 ? false : true;
            stud.Save();
            //notifyIconSaved.ShowBalloonTip(500);
            stud = new Student();
            stud.Load();
            Show();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            stud = new Student();
            stud.Load(openFileDialog.FileName);
            Show();
        }
        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void ТолькоДляЧтенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.ro = !Student.ro;
            TextBoxLastname.ReadOnly = TextBoxName.ReadOnly = TextBoxMidname.ReadOnly = Student.ro;
            Student.lastid++;
            stud = new Student();
            if (Student.ro)
                buttonNext.Enabled = stud.FileExists() ? true : false;
            else
                buttonNext.Enabled = true;
            Student.lastid--;
        }
        private void АвтосохранениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.aus = !Student.aus;
        }

        private void TextBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                TextBoxName.Select();
        }
        private void TextBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                TextBoxMidname.Select();
        }
        private void TextBoxMidname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                buttonNext.Select();
        }

        private void TextBoxNames_TextChanged(object sender, EventArgs e)
        {
            if (Student.aus)
            {
                stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text);
                stud.Save();
            }
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
            path = paths + id + "." + ext[0];
        }
        public void Save() // to file
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            foreach (string s in TSA())
                writer.WriteLine(s);
            writer.Close();
            //BinaryWriter bwriter = new BinaryWriter(fs);
            //foreach (string s in TSA())
            //    bwriter.Write(s);
            //bwriter.Close();

        }
        public bool FileExists()
        {
            return File.Exists(path) ? true : false;
        }
        public void Load()
        {
            Load(path);
        }
        public void Load(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            string[] sa = new string[4];
            switch (path.Substring(path.Length - 3).ToLower())
            {
                case "txt":
                    StreamReader sreader = new StreamReader(fs);
                    for (int i = 0; i < saLength; i++)
                        sa[i] = sreader.ReadLine();
                    FSA(sa);
                    sreader.Close();
                    break;
                case "bin":
                    BinaryReader breader = new BinaryReader(fs);
                    for (int i = 0; i < saLength; i++)
                        sa[i] = breader.ReadString();
                    FSA(sa);
                    breader.Close();
                    break;
                case "byte":
                    break;
            }
            fs.Close();
        }
        string[] TSA()
        {
            return new string[saLength] { lastname, name, midname, id.ToString() };
        }
        void FSA(string[] sa)
        {
            lastname = sa[0];
            name = sa[1];
            midname = sa[2];
            id = int.Parse(sa[3]);
        }
        const int saLength = 4;
        public static bool ro = false, aus = false;
        public int id;
        public static int lastid = 1;
        static readonly string paths = "students/student";
        public string lastname, name, midname, path;
        readonly string[] ext = { "txt", "bin", "dat"};
    }
}