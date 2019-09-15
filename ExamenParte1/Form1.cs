using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParte1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblsalariofinal.Visible = false;
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            double horasTrabajadas = double.Parse(txthoras.Text);
            double valorHora = double.Parse(txtvalor.Text);
            double total = horasTrabajadas * valorHora;

            if (total < 700000)
            {
                total = total + (total * 0.10);
            }
            else
                if (total >= 700000 && total < 1000000)
                {
                    total = total - (total * 0.02);
                }
            else
                if (total >= 1000001)
                {
                     total = total - (total * 0.03);
                }

            lblsalariofinal.Text = "$" + Convert.ToDecimal(total).ToString("N0");
            lblsalariofinal.Visible = true;
        }
    }
}
