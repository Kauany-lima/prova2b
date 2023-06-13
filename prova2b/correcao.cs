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
            string[] gab = { "a", "b", "d", "e", "c", "d", "a", "d", "e", "b" };

            //Array gab[10] = { "a", "b", "d",  "e", "c", "d", "a", "d", "e", "b" };
            int soma = 0;

            if (gab.Length == Convert.ToInt32(tx_1.Text)) 
            {
                soma += 1;
            }
            else
            {
                soma -= 1;
            }



        }
    }
}
