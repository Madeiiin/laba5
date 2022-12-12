using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Char sost = 'z';
        String vvod;
        String stek = "";
        private void button1_Click(object sender, EventArgs e)
        {
            bool go = true;
            stek = "";
            //label3.Text = label3.Text + "dsa";
            vvod = Convert.ToString(textBox1.Text);
            //label2.Text = vvod.Length + "";
            int k = 0;
            do
            {
                if ((vvod[k] == '1' || vvod[k] == '0') && k < vvod.Length) { go = true; k++; } else go = false;
                if (k == vvod.Length) break;
            }
            while (go);
            if (go)
            {
                for (int i = 0; i < vvod.Length - 1; i++)
                {
                    stek += vvod[i];
                    for (int j = 0; j < stek.Length; j++)
                    {
                        //01 -> F
                        if (stek.Length > 2)
                            if (stek[stek.Length - 2] == '0' && stek[stek.Length - 1] == '1') { stek = stek.Remove(stek.Length - 2, 2); stek += "F"; }
                        //F -> S
                        if (stek[stek.Length - 1] == 'F') { stek = stek.Remove(stek.Length - 1, 1); stek += 'S'; }
                        //S -> eps
                        if (stek[stek.Length - 1] == 'S') { stek = stek.Remove(stek.Length - 1, 1); }
                        //1 -> A
                        if (stek[stek.Length - 1] == '1') { stek = stek.Remove(stek.Length - 1, 1); stek += 'A'; }
                        //A0 -> B
                        if (stek.Length > 2)
                        if (stek[stek.Length - 1] == '0' && stek[stek.Length - 2] == 'A') { stek = stek.Remove(stek.Length - 2, 2); stek += "B"; }
                        //B1 -> B
                        if (stek[stek.Length - 1] == '1' && stek[stek.Length - 2] == 'B') { stek = stek.Remove(stek.Length - 2, 2); stek += "B"; }
                        //01A -> S
                        if (stek.Length > 3)
                            if (stek[stek.Length - 3] == '0' && stek[stek.Length - 2] == '1' && stek[stek.Length - 1] == 'A') { stek = stek.Remove(stek.Length - 3, 3); stek += 'S'; }
                        //01B -> S
                        if (stek.Length > 3)
                            if (stek[stek.Length - 3] == '0' && stek[stek.Length - 2] == '1' && stek[stek.Length - 1] == 'B') { stek = stek.Remove(stek.Length - 3, 3); stek += 'S'; }
                        //A -> eps
                        if (stek[stek.Length - 1] == 'A') { stek = stek.Remove(stek.Length - 1, 1); }
                        //B -> eps
                        if (stek.Length >= 1)
                        if (stek[stek.Length - 1] == 'B') { stek = stek.Remove(stek.Length - 1, 1); }
                        //0 -> eps
                        if (stek.Length >= 1)
                        if (stek[stek.Length - 1] == '0') { stek = stek.Remove(stek.Length - 1, 1); }

                        //label2.Text = stek;
                    }
                }
                if (stek == "" || stek=="S" || stek == String.Empty || stek == " " || stek.Length == 0) { label4.Text = "Результат: да "; }
                else label4.Text = "Результат: нет";
            }
            else label4.Text = "Результат: нет";
            //label2.Text = stek + "";
        }
    }
}
