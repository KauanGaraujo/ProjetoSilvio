using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoSilvio.View
{
    public partial class TelaFechaVenda : Form
    {
        PdvTela xuxa;

        public TelaFechaVenda(PdvTela PDV)
        {
            InitializeComponent();
            xuxa = PDV;







        }

        private void TelaFechaVenda_Load(object sender, EventArgs e)
        {

            label12.Text = "R$" + Convert.ToString(xuxa.totalfinal) + ",00";
            label13.Text = "PRODUTO:\n" + xuxa.dataGridView1.Rows[0].Cells[0].Value.ToString();
            label14.Text += "UNITÁRIO:\n" + xuxa.dataGridView1.Rows[0].Cells[1].Value.ToString();
            label15.Text += "QUANTIDADE:\n" + xuxa.dataGridView1.Rows[0].Cells[2].Value.ToString();
            label5.Text = DateTime.Now.ToString();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
