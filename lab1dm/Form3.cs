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
    public partial class ShortF : Form
    {
        int ind;
        public static HashSet<int> setNotA = new HashSet<int>();
        public static HashSet<int> setNotC = new HashSet<int>();

        public ShortF()
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
                    setNotA.UnionWith(setNotC);
                    foreach (int i in setNotA) { textBox1.Text += i.ToString() + ", "; }
                    ind++;
                    break;

                case 3:
                    setNotA.UnionWith(Main.settB);
                    foreach (int i in setNotA) { setDBox.Text += i.ToString() + ", "; }
                    nextStep.Enabled = false;
                    saveButton.Visible = true;
                    saveButton.Focus();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, setDBox.Text);
            MessageBox.Show("File saved");
            goBack.Focus();
        }
    }
}
