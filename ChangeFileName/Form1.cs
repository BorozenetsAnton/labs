using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ChangeFileName
{
    public partial class Form1 : Form
    {
        string MainDirectory = "";
        char DelimToChange = '_';
        char DelimToReplace = ' ';
        int ReplacePosition = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseFolder_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.ShowNewFolderButton = false;
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(FBD.SelectedPath);
                MainDirectory = FBD.SelectedPath;
            }
            if (MainDirectory.Length > 0)
            {
                MakeChanges.Enabled = true;
                ChangePlace.Enabled = true;
                ChangeSymbol.Enabled = true;
                textBox1.AppendText(MainDirectory);
            }
        }

        private void MakeChanges_Click(object sender, EventArgs e)
        {
            if(RadioButton1.Checked)
            {
                DelimToChange = '_';
            }
            if(RadioButton2.Checked)
            {
                DelimToChange = '-';
            }
            if(radioButton3.Checked)
            {
                DelimToChange = ' ';
            }
            if (RadioButton4.Checked)
            {
                DelimToReplace = '_';
            }
            if (RadioButton5.Checked)
            {
                DelimToReplace = '-';
            }
            if(RadioButton6.Checked)
            {
                DelimToReplace = ' ';
            }
            //Directory.CreateDirectory(MainDirectory);
            //foreach (string s1 in Directory.GetFiles(MainDirectory))
            //{
            //    string s2 = MainDirectory + "\\"+ Path.GetFileName(s1);
            //    s2 = s2.Replace(DelimToChange, DelimToReplace);
            //    File.Move(s1, s2);
            //}
            Movefiles(MainDirectory, DelimToChange, DelimToReplace);
            
        }

        static void Movefiles(string directory, char Delimtochange,char Delimtoreplace)
        {
            Directory.CreateDirectory(directory);
            foreach (string s1 in Directory.GetFiles(directory))
            {
                string filename = Path.GetFileName(s1);
                filename = filename.Replace(Delimtochange, Delimtoreplace);
                string s2 = directory + "\\" + filename;
                //s2 = s2.Replace(Delimtochange, Delimtoreplace);
                File.Move(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(directory))
            {
                Movefiles(directory + "\\" + Path.GetFileName(s), Delimtochange, Delimtoreplace);
            }
        }

        private void ChangeSymbol_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                DelimToChange = '_';
            }
            if (RadioButton2.Checked)
            {
                DelimToChange = '-';
            }
            if (radioButton3.Checked)
            {
                DelimToChange = ' ';
            }
            if (RadioButton4.Checked)
            {
                DelimToReplace = '_';
            }
            if (RadioButton5.Checked)
            {
                DelimToReplace = '-';
            }
            if (RadioButton6.Checked)
            {
                DelimToReplace = ' ';
            }
            if (radioButton13.Checked)//позиция
                ReplacePosition = 1;
            if (radioButton14.Checked)
                ReplacePosition = 2;
            if (radioButton15.Checked)
                ReplacePosition = 3;
            if (radioButton16.Checked)
                ReplacePosition = 4;
            if (radioButton17.Checked)
                ReplacePosition = 5;
            //Directory.CreateDirectory(MainDirectory);

            //foreach (string s1 in Directory.GetFiles(MainDirectory))
            //{
            //    string filename = Path.GetFileName(s1);
            //    string[] words = filename.Split(new char[] { ' ','_','-' });
            //    int pos = words.Length - ReplacePosition;
            //    int torep = filename.LastIndexOf(words[pos]);
            //    filename = ReplaceCharInString1(filename, torep - 1, DelimToReplace);
            //    string s2 = MainDirectory + "\\" + filename;
            //    File.Move(s1, s2);
            //}
            ReplaceSymbol(MainDirectory, DelimToChange, DelimToReplace, ReplacePosition);
        }

        static void ReplaceSymbol(string directory, char Delimtochange, char Delimtoreplace, int Replaceposition)
        {
            Directory.CreateDirectory(directory);

            foreach (string s1 in Directory.GetFiles(directory))
            {
                string filename = Path.GetFileName(s1);
                string[] words = filename.Split(new char[] { ' ', '_', '-' });
                int pos = words.Length - Replaceposition;
                int torep = filename.LastIndexOf(words[pos]);
                filename = ReplaceCharInString1(filename, torep - 1, Delimtoreplace);
                string s2 = directory + "\\" + filename;
                File.Move(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(directory))
            {
                ReplaceSymbol(directory + "\\" + Path.GetFileName(s), Delimtochange, Delimtoreplace,Replaceposition);
            }
        }

        public static string ReplaceCharInString1(string str, int index, char newSymb)
        {
            return str.Remove(index, 1).Insert(index, newSymb.ToString());
        }

        private void ChangePlace_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                DelimToChange = '_';
            }
            if (RadioButton2.Checked)
            {
                DelimToChange = '-';
            }
            if (radioButton3.Checked)
            {
                DelimToChange = ' ';
            }
            if (RadioButton4.Checked)
            {
                DelimToReplace = '_';
            }
            if (RadioButton5.Checked)
            {
                DelimToReplace = '-';
            }
            if (RadioButton6.Checked)
            {
                DelimToReplace = ' ';
            }
            Swap(MainDirectory, DelimToChange, DelimToReplace);
        }

        static void Swap(string directory, char Delimtochange, char Delimtoreplace)
        {
            Directory.CreateDirectory(directory);
            foreach (string s1 in Directory.GetFiles(directory))
            {
                string filename = Path.GetFileName(s1);
                filename = filename.Replace(Delimtoreplace, '@');
                filename = filename.Replace(Delimtochange, Delimtoreplace);
                filename = filename.Replace('@', Delimtochange);
                string s2 = directory + "\\" + filename;
                File.Move(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(directory))
            {
                Swap(directory + "\\" + Path.GetFileName(s), Delimtochange, Delimtoreplace);
            }
        }
    }
}
