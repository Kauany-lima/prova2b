using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova2b
{
    public partial class correcao : Form
    {
        public correcao()
        {
            InitializeComponent();
            
        }

        private void calcular_Click(object sender, EventArgs e)
        {
         



            // Array array = new Array[10];
            string[] gab = { "a", "b", "d", "e", "c", "a", "a", "d", "e", "b" };

         
            int soma = 0;

            //1
            if (gab.Length == Convert.ToInt32(tx_1.Text)) 
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }

            //2
            if (gab.Length == Convert.ToInt32(tx_2.Text))
            {
                soma += 0;
            }
            else
            {
                soma -= 0;
            }

            //3
            if (gab.Length == Convert.ToInt32(tx_3.Text))
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }

            //4
            if (gab.Length == Convert.ToInt32(tx_4.Text))
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }

            //5
            if (gab.Length == Convert.ToInt32(tx_5.Text))
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }

            //6
            if (gab.Length == Convert.ToInt32(tx_6.Text))
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }

            //7

            if (gab.Length == Convert.ToInt32(tx_7.Text))
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }

            //8
            if (gab.Length == Convert.ToInt32(tx_8.Text))
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }

            //9
            if (gab.Length == Convert.ToInt32(tx_10.Text))
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }

            //10
            if (gab.Length == Convert.ToInt32(tx_1.Text))
            {
                soma += 1;
            }
            else
            {
                soma -= 0;
            }
            int soma2 = soma;
            string res = ib_resultado.Text;
            MessageBox.Show(Convert.ToString(soma2));

        }

        private void ib_resultado_Click(object sender, EventArgs e)
        {

        }
    }
}
