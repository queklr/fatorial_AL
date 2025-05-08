using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fatorial_AL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblResultado.Text = "";
            if (int.TryParse(txtnumero.Text, out int num))
            {
                long factorial = 1;
                string multiplicacion = "";
                for (int i = num; i > 0; i--)//5, 1*5,5*4,20*3,60*2,120*1,=2120
                {
                    factorial = factorial * i;
                    listBox1.Items.Add(i);

                    multiplicacion += (i == 1) ? $"{i}" : $"{i}*";
                }
                lblResultado.Text = $"{num}! = {multiplicacion} = { factorial}";
            }
            else
            {
                MessageBox.Show("ingrese un numero  valido");
            }
        }
    }
}
