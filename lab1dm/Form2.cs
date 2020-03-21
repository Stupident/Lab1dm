using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1dm
{
    public partial class OrigF : Form
    {
        int ind = 0;
        public static HashSet<int> setNotA = new HashSet<int>();
        public static HashSet<int> setNotC = new HashSet<int>();
        public static HashSet<int> set1 = new HashSet<int>();
        public static HashSet<int> set2 = new HashSet<int>();
        public static HashSet<int> set3 = new HashSet<int>();
        public static HashSet<int> set4 = new HashSet<int>();


        public OrigF()
        {
            InitializeComponent();
            foreach (int i in Main.settA) { setABox.Text += i.ToString() + ", "; }
            foreach (int i in Main.settB) { setBBox.Text += i.ToString() + ", "; }
            foreach (int i in Main.settC) { setCBox.Text += i.ToString() + ", "; }

            ind = 0;
            setNotA.Clear();
            setNotA.UnionWith(Main.univ);
            setNotC.Clear();
            setNotC.UnionWith(Main.univ);
            set1.Clear();
            set1.UnionWith(Main.settB);
            set2.Clear();
            set2.UnionWith(Main.settC);
            set3.Clear();
            set3.UnionWith(Main.settA);
            set4.Clear();
            set4.UnionWith(Main.settB);
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }
        Boolean uslPic = true;
        private void pictureF_Click(object sender, EventArgs e)
        {
            if (uslPic)
            {
                pictureF.Height = 210;
                pictureF.Width = 630;
                uslPic = false;
            }
            else
            {
                pictureF.Height = 150;
                pictureF.Width = 450;
                uslPic = true;
            }
        }


        private void nextStep_Click(object sender, EventArgs e)
        {
            switch (ind)
            {

                case 0:
                    setNotA.ExceptWith(Main.settA);
                    foreach (int i in setNotA) { notABox.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 1:
                    setNotC.ExceptWith(Main.settC);
                    foreach (int i in setNotC) { notCBox.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 2:
                    set1.IntersectWith(setNotC);
                    foreach (int i in set1) { textBox1.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 3:
                    set2.IntersectWith(setNotA);
                    foreach (int i in set2) { textBox2.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 4:
                    set3.IntersectWith(Main.settB);
                    foreach (int i in set3) { textBox3.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 5:
                    set4.UnionWith(setNotA);
                    foreach (int i in set4) { textBox4.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 6:
                    set4.UnionWith(setNotC);
                    foreach (int i in set4) { textBox5.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 7:
                    set1.UnionWith(set2);
                    foreach (int i in set1) { textBox6.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 8:
                    set4.UnionWith(set1);
                    foreach (int i in set4) { textBox7.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 9:
                    set4.UnionWith(set3);
                    foreach (int i in set4) { setDBox.Text += i.ToString() + ", "; }
                    nextStep.Enabled = false;
                    saveButton.Visible = true;
                    saveButton.Focus();
                    break;
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, setDBox.Text);
            MessageBox.Show("File saved");
            button1.Focus();
        }
    }
}
