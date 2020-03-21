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
    public partial class ShowRes : Form
    {
        HashSet<int> setZ1 = new HashSet<int>();
        HashSet<int> setZ2 = new HashSet<int>();
        HashSet<int> setD1 = new HashSet<int>();
        HashSet<int> setD2 = new HashSet<int>();
        public ShowRes()
        {
            InitializeComponent();
        }

        private void open1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            string setDbyOrig = System.IO.File.ReadAllText(filename);
            setDbyOrigBox.Text = setDbyOrig;
            MessageBox.Show("Set D dowloaded");
        }

        private void open2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            string setDbyShort = System.IO.File.ReadAllText(filename);
            setDbyShortBox.Text = setDbyShort;
            MessageBox.Show("Set D downloaded");
        }

        private void open3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            string setZbyMe = System.IO.File.ReadAllText(filename);
            setZbyMeBox.Text = setZbyMe;
            MessageBox.Show("Set Z dowloaded");
        }

        private void calc_Click(object sender, EventArgs e)
        {
            setZbySysBox.Text = "";
            setZ2.UnionWith(ForZ.setX);
            setZ2.SymmetricExceptWith(ForZ.setY);
            foreach(int i in setZ2) { setZbySysBox.Text += i + ", "; }
            MessageBox.Show("Set Z calculated");
        }

        private void compare1_Click(object sender, EventArgs e)
        {
            setD1.Clear();
            setD2.Clear();
            bool tool = false;
            bool minus = false;
            int numb = 0;
            for (int i = 0; i < setDbyOrigBox.Text.Length; i++)
            {
                int temp = 0;
                if (int.TryParse(char.ConvertFromUtf32(setDbyOrigBox.Text[i]), out temp))
                {
                    numb = numb * 10 + temp;
                    tool = true;
                }
                else if (setDbyOrigBox.Text[i] == '-')
                {
                    minus = true;
                }
                else if (tool)
                {
                    if (minus) numb *= -1;
                    setD1.Add(numb);
                    tool = false;
                    minus = false;
                    numb = 0;
                }
            }
            if (numb != 0)
            {
                if (minus) numb *= -1;
                setD1.Add(numb);
            }

            tool = false;
            minus = false;
            numb = 0;
            for (int i = 0; i < setDbyShortBox.Text.Length; i++)
            {
                int temp = 0;
                if (int.TryParse(char.ConvertFromUtf32(setDbyShortBox.Text[i]), out temp))
                {
                    numb = numb * 10 + temp;
                    tool = true;
                }
                else if (setDbyShortBox.Text[i] == '-')
                {
                    minus = true;
                }
                else if (tool)
                {
                    if (minus) numb *= -1;
                    setD2.Add(numb);
                    tool = false;
                    minus = false;
                    numb = 0;
                }
            }
            if (numb != 0)
            {
                if (minus) numb *= -1;
                setD2.Add(numb);
            }

            if (setD1.SetEquals(setD2))
            {
                MessageBox.Show("1 and 2 are identific");
            }
            else
            {
                MessageBox.Show("1 and 2 are not identific");
            }
        }

        private void compare2_Click(object sender, EventArgs e)
        {
            setZ1.Clear();
            bool tool = false;
            bool minus = false;
            int numb = 0;
            for (int i = 0; i < setZbyMeBox.Text.Length; i++)
            {
                int temp = 0;
                if (int.TryParse(char.ConvertFromUtf32(setZbyMeBox.Text[i]), out temp))
                {
                    numb = numb * 10 + temp;
                    tool = true;
                }
                else if (setZbyMeBox.Text[i] == '-')
                {
                    minus = true;
                }
                else if (tool)
                {
                    if (minus) numb *= -1;
                    setZ1.Add(numb);
                    tool = false;
                    minus = false;
                    numb = 0;
                }
            }
            if (numb != 0)
            {
                if (minus) numb *= -1;
                setZ1.Add(numb);
            }

            if (setZ1.SetEquals(setZ2))
            {
                MessageBox.Show("1 and 2 are identific");
            }
            else
            {
                MessageBox.Show("1 and 2 are not identific");

            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
