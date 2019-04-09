using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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
            stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text,domainUpDown.Text,comboBoxFac.Text,numericUpDown.Text);
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
            TextBoxLastname.Select();
        }
        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text, domainUpDown.Text, comboBoxFac.Text, numericUpDown.Text);
            buttonNext.Enabled = true;
            buttonPrev.Enabled = --Student.lastid == 1 ? false : true;
            stud.Save();
            //notifyIconSaved.ShowBalloonTip(500);
            stud = new Student();
            stud.Load();
            Show();
            TextBoxLastname.Select();
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
        private void ОткрытьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("students");
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
            Student.auto = !Student.auto;
        }

        private void EnterToTab(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ((Control)sender).Parent.SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void TextBoxNames_TextChanged(object sender, EventArgs e)
        {
            if (Student.auto)
            {
                stud = new Student(TextBoxLastname.Text, TextBoxName.Text, TextBoxMidname.Text, domainUpDown.Text, comboBoxFac.Text, numericUpDown.Text);
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
        public Student(string lastname, string name, string midname, string year, string fac, string group)
        {
            this.lastname = lastname;
            this.name = name;
            this.midname = midname;
            this.year = year;
            this.fac = fac;
            this.group = int.Parse(group);
            id = lastid;
            path = paths + id + "." + ext[0];
        }
        public void Save() // to file
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);
            for (int i = 0; i < saLength; i++)
                writer.WriteLine(this[i]);
            writer.Close();
            fs.Close();

            fs = new FileStream(paths + id + "." + ext[1], FileMode.Create, FileAccess.Write);
            BinaryWriter bwriter = new BinaryWriter(fs);
            for (int i = 0; i < saLength; i++)
                bwriter.Write(this[i]);
            bwriter.Close();
            fs.Close();

            fs = new FileStream(paths + id + "." + ext[2], FileMode.Create, FileAccess.Write);
            for (int i = 0; i < saLength; i++)
                fs.Write(Encoding.Unicode.GetBytes(this[i]), 0, this[i].Length);
            fs.Close();
        }
        public bool FileExists()
        {
            return File.Exists(path) ? true : false;
        }
        public void Load()
        {
            if (FileExists()) 
                Load(path);
        }
        public void Load(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            
            switch (path.Substring(path.Length - 3).ToLower())
            {
                case "txt":
                    StreamReader sreader = new StreamReader(fs);
                    for (int i = 0; i < saLength; i++)
                        this[i] = sreader.ReadLine();
                    sreader.Close();
                    break;
                case "bin":
                    BinaryReader breader = new BinaryReader(fs);
                    for (int i = 0; i < saLength; i++)
                        this[i] = breader.ReadString();
                    breader.Close();
                    break;
                case "dat":
                    break;
            }
            fs.Close();
        }

        public string this[int i]
        {
            get
            {
                List<string> l = new List<string> { lastname, name, midname, id.ToString(), year.ToString(),
                fac, group.ToString(),  /*subjects.Length.ToString()*/};
                //l.AddRange(subjects);
                return l[i];
            }
            set
            {
                switch (i)
                {
                    case 0: lastname = value; break;
                    case 1: name = value; break;
                    case 2: midname = value; break;
                    case 3: id = int.Parse(value); break;
                    case 4: year = value; break;
                    case 5: fac = value; break;
                    case 6: group = int.Parse(value); break;
                }
            }
        }

        const int saLength = 7;
        public static bool ro = false, auto = false;
        public int id, group;
        public static int lastid = 1;
        public string lastname, name, midname, path, year, fac;
        public string[] subjects;
        static readonly string paths = "students/student";
        static readonly string[] ext = { "txt", "bin", "dat"};
    }
}