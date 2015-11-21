using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RegeraBoleto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iFator_vencto = int.Parse(sCodeBar8.Text.Substring(0, 4));
            int iFator_vencto2;
            DateTime dDt_vencto1 = new DateTime(2003, 8, 8);
            DateTime dDt_vencto2 = DateTime.Parse(dt_vencimento.Text);
            int n_dias_atraso;
            string dvGeral;
            string valor = sCodeBar8.Text.Substring(4, 10);

            //--->> fator 2131 => 08/08/2003

            // Calcula a diferença em dias entre a data de 08/08/2003 e a nova data de vencimento

            TimeSpan ts = new TimeSpan();
            ts = dDt_vencto2 - dDt_vencto1;

            int n_dias = int.Parse(ts.TotalDays.ToString());

            // Calcula o novo fator de vencimento

            iFator_vencto2 = 2131 + n_dias;
            n_dias_atraso = iFator_vencto2 - iFator_vencto;

            // Calcula o DV Geral

            string fator = iFator_vencto2.ToString();
            string campoLivre = sCodeBar1.Text.Substring(4, 1) + sCodeBar2.Text.Substring(0, 4) + sCodeBar3.Text + sCodeBar4.Text.Substring(0, 5) + sCodeBar5.Text + sCodeBar6.Text.Substring(0, 5);

            dvGeral = DvMod11(sCodeBar1.Text.Substring(0, 4) + fator + valor + campoLivre);

            // Novo Código de Barras

            string codeBar = sCodeBar1.Text + "." + sCodeBar2.Text + "." + sCodeBar3.Text + "." + sCodeBar4.Text + "  " + sCodeBar5.Text + "." + sCodeBar6.Text + "   " + dvGeral + "  " + fator + valor;
            label2.Text = codeBar;

            textBox1.Text = codeBar;

        }

        /// <summary>
        /// Calcula o DV módulo 11 de um número dado
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public string DvMod11(string numero)
        {
            int i = numero.Length;
            int fator = 2;
            int total = 0;
            int dv = 0;
            while (i >= 1)
            {
                total += int.Parse(numero.Substring(i - 1, 1)) * fator;
                fator += 1;
                if (fator > 9)
                    fator = 2;
                i--;
            }
            dv = 11 - (total % 11);
            if (dv >= 10)
                return "1";
            else
                return dv.ToString();
        }

        /// <summary>
        /// Replica uma string n vezes
        /// </summary>
        /// <param name="s">String a ser replicada</param>
        /// <param name="n">Número de vezes que a string será replicada</param>
        /// <returns>Retorna a string replicada. Ex: Replicate("0",5) => Retorna "00000"</returns>
        protected string Replicate(string s, int n)
        {
            string x = "";
            for (int i = 1; i <= n; i++)
            {
                x += s;
            }
            return x;
        }

        /// <summary>
        /// Preenche com zeros a esquerda de uma string
        /// </summary>
        /// <param name="value">String que será preenchida com zeros a esquerda</param>
        /// <param name="zeros">Quantidade de zeros que será colocado à esquerda de "value"</param>
        /// <returns>Retorna a string preenchida com zeros a esquerda</returns>
        public string Strzero(object value, int zeros)
        {
            string aux;
            if (value == null)
            {
                aux = Replicate("0", zeros);
                return aux;
            }
            else
            {
                aux = value.ToString();
                return this.Replicate("0", zeros - aux.Length) + aux;
            }
        }

        private void sCodeBar1_TextChanged(object sender, EventArgs e)
        {
            var tb = (sender as TextBox);
            switch ((tb.Name).Substring(8))
            {
                case "1":
                case "2":
                case "3":
                case "5":
                    if (tb.TextLength == 5)
                    {
                        Control p;
                        p = tb.Parent;
                        p.SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    break;
                case "4":
                case "6":
                    if (tb.TextLength == 6)
                    {
                        Control p;
                        p = tb.Parent;
                        p.SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    break;
                case "7":
                    if (tb.TextLength == 1)
                    {
                        Control p;
                        p = tb.Parent;
                        p.SelectNextControl(ActiveControl, true, true, true, true);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}