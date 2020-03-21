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
    public partial class Main : Form
    {
        int udown = 0;
        int utop = 100;
        long power = 101;
        Decimal powerA = 0;
        Decimal powerB = 0;
        Decimal powerC = 0;
        public static HashSet<int> settA = new HashSet<int>();
        public static HashSet<int> settB = new HashSet<int>();
        public static HashSet<int> settC = new HashSet<int>();
        public static HashSet<int> univ = new HashSet<int>();

        public Main()
        {
            InitializeComponent();
            for (int i = udown; i <= utop; i++)
            {
                univ.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            OrigF origF = new OrigF();
            origF.ShowDialog();
            Show();
            shortF.Focus();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAutoGen.Checked == true)
            {
                setsBox.Visible = false;
                manInput.Visible = false;
                autoGen.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManInput.Checked == true) 
            { 
                setsBox.Visible = false;
                autoGen.Visible = false;
                manInput.Visible = true;
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            ShowRes showRes = new ShowRes();
            showRes.ShowDialog();
            Show();
            origF.Focus();
        }

        private void variantLabel_Click(object sender, EventArgs e)
        {
            var variant = ((21 + 92 % 60) % 30 + 1);
            variantLabel.Text = "Variant: " + variant;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            powerA = AutoGenA.Value;
            powerB = AutoGenB.Value;
            powerC = AutoGenC.Value;

            settA.Clear();
            settB.Clear();
            settC.Clear();

            setABox.Clear();
            setBBox.Clear();
            setCBox.Clear();

            while(settA.Count<powerA)
            {
                settA.Add(random.Next(udown, utop+1));
            }
            while (settB.Count < powerB)
            {
                settB.Add(random.Next(udown, utop + 1));
            }
            while (settC.Count < powerC)
            {
                settC.Add(random.Next(udown, utop + 1));
            }
            foreach (int i in settA) { setABox.Text += i.ToString() + ", "; }
            foreach (int i in settB) { setBBox.Text += i.ToString() + ", "; }
            foreach (int i in settC) { setCBox.Text += i.ToString() + ", "; }

            setsBox.Visible = true;
            setsBox.Height = 290;
            regenerate.Visible = true;
            autoGen.Visible = false;
            radioAutoGen.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setsBox.Height = 250;
            regenerate.Visible = false;

            setABox.Clear();
            setBBox.Clear();
            setCBox.Clear();

            settA.Clear();
            settB.Clear();
            settC.Clear();

            bool tool = false;
            bool minus = false;
            int numb = 0;
            for(int i = 0; i<manSetA.Text.Length; i++)
            {
                int temp = 0;
                if (int.TryParse(char.ConvertFromUtf32(manSetA.Text[i]), out temp))
                {
                    numb = numb * 10 + temp;
                    tool = true;
                }
                else if(manSetA.Text[i] == '-'){
                    minus = true;
                }
                else if(tool)
                {
                    if (minus) numb *= -1;
                    if(numb<utop && numb>udown) settA.Add(numb);
                    tool = false;
                    minus = false;
                    numb = 0;
                }
            }
            if (numb != 0)
            {
                if (minus) numb *= -1;
                if (numb < utop && numb > udown) settA.Add(numb);
            }

            tool = false;
            minus = false;
            numb = 0;
            for (int i = 0; i < manSetB.Text.Length; i++)
            {
                int temp = 0;
                if (int.TryParse(char.ConvertFromUtf32(manSetB.Text[i]), out temp))
                {
                    numb = numb * 10 + temp;
                    tool = true;
                }
                else if (manSetB.Text[i] == '-')
                {
                    minus = true;
                }
                else if (tool)
                {
                    if (minus) numb *= -1;
                    if (numb < utop && numb > udown) settB.Add(numb);
                    tool = false;
                    minus = false;
                    numb = 0;
                }
            }
            if (numb != 0)
            {
                if (minus) numb *= -1;
                if (numb < utop && numb > udown) settB.Add(numb);
            }

            tool = false;
            minus = false;
            numb = 0;
            for (int i = 0; i < manSetC.Text.Length; i++)
            {
                int temp = 0;
                if (int.TryParse(char.ConvertFromUtf32(manSetC.Text[i]), out temp))
                {
                    numb = numb * 10 + temp;
                    tool = true;
                }
                else if (manSetC.Text[i] == '-')
                {
                    minus = true;
                }
                else if (tool)
                {
                    if (minus) numb *= -1;
                    if (numb < utop && numb > udown) settC.Add(numb);
                    tool = false;
                    minus = false;
                    numb = 0;
                }
            }
            if (numb != 0)
            {
                if (minus) numb *= -1;
                if (numb < utop && numb > udown) settC.Add(numb);
            }


            foreach (int i in settA) { setABox.Text += i.ToString() + ", "; }
            foreach (int i in settB) { setBBox.Text += i.ToString() + ", "; }
            foreach (int i in settC) { setCBox.Text += i.ToString() + ", "; }

            manInput.Visible = false;
            setsBox.Visible = true;
            radioManInput.Checked = false;
        }

        private void regenerate_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            ShortF shortW = new ShortF();
            shortW.ShowDialog();
            Show();
            calcZ.Focus();
        }

        private void calcZ_Click(object sender, EventArgs e)
        {
            Hide();
            ForZ forZ = new ForZ();
            forZ.ShowDialog();
            Show();
            allRes.Focus();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            int.TryParse(uDownBox.Text, out udown);
            int.TryParse(uTopBox.Text, out utop);
            power = utop - udown + 1;
            AutoGenA.Maximum = power;
            AutoGenB.Maximum = power;
            AutoGenC.Maximum = power;
            AutoGenA.Value = power/2;
            AutoGenB.Value = power/2;
            AutoGenC.Value = power/2;
            univ.Clear();
            for (int i = udown; i <= utop; i++)
            {
                univ.Add(i);
            }
        }
    }
}
