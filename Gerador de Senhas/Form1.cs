using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Senhas
{
    public partial class Form1 : Form
    {
        int num_senhas = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_gerar_Click(object sender, EventArgs e)
        {
            string chars = "abcdefghijklmnopqrstuwvxyz";
            if (check_maiusculas.Checked)
                chars += "ABCDEFGHIJKLMNOPQRSTUWVXYZ";
            if (check_algarismos.Checked)
                chars += "0123456789";
            if (check_simbolos.Checked)
                chars += "#/$!?=-\"";

            lista_senhas.Items.Clear();
            Random rnd = new Random();

            for (int n = 1; n<= num_senhas; n++)
            {
                StringBuilder str = new StringBuilder();
                for(int m = 1; m <= count_chars.Value; m++)
                {
                    int pos = rnd.Next(0, chars.Length);
                        str.Append(chars[pos].ToString());
                }
                lista_senhas.Items.Add(str.ToString());
            }
        }
    }
}
