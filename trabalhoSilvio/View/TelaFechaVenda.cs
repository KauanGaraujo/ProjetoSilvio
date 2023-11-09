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

            label12.Text = "R$" + Convert.ToString(xuxa.totalfinal) + ",00";

            for (int i = 0; i < xuxa.dataGridView1.RowCount - 1; i++)

            {

                label16.Text += "\nPRODUTO : " + xuxa.dataGridView1.Rows[i].Cells[0].Value.ToString();
                label16.Text += "\nQUANTIDADE : " + xuxa.dataGridView1.Rows[i].Cells[1].Value.ToString();
                label16.Text += "\nUNITÁRIO : " + xuxa.dataGridView1.Rows[i].Cells[2].Value.ToString();
                label6.Text += "\nTOTAL : " + xuxa.dataGridView1.Rows[1].Cells[3].Value.ToString();

                label5.Text = DateTime.Now.ToString();
            }
        }

        private void TelaFechaVenda_Load(object sender, EventArgs e)
        {

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
