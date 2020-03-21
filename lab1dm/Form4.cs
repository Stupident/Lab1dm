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
    public partial class ForZ : Form
    {
        public static HashSet<int> setX = new HashSet<int>();
        public static HashSet<int> setY = new HashSet<int>();
        public static HashSet<int> setZ = new HashSet<int>();
        public ForZ()
        {
            InitializeComponent();

            setX.Clear();
            setX.UnionWith(Main.univ);
            setX.ExceptWith(Main.settB);
            setY.Clear();
            setY.UnionWith(Main.univ);
            setY.ExceptWith(Main.settA);
            setZ.Clear();

            foreach (int i in setX) { setXBox.Text += i.ToString() + ", "; }
            foreach (int i in setY) { setYBox.Text += i.ToString() + ", "; }
        }

        private void calcButton_Click(object sender, EventArgs e)
        {


            for(int s = 0; s <=1; s++)
            {
                if(s == 1)
                {
                    HashSet<int> setTemp = new HashSet<int>(setX);
                    setX.Clear();
                    setX.UnionWith(setY);
                    setY.Clear();
                    setY.UnionWith(setTemp);
                }
                foreach(int i in setX)
                {
                    bool q = true;
                    foreach(int j in setY)
                    {
                        if(i == j)
                        {
                            q = false;
                        }
                    }
                    if (q) setZ.Add(i);
                }
            }


            foreach (int i in setZ) { setZBox.Text += i.ToString() + ", "; }
            calcButton.Enabled = false;
            saveButton.Visible = true;
            saveButton.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, setZBox.Text);
            MessageBox.Show("File saved");
            goBack.Focus();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
