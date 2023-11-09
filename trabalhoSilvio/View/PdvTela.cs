using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalhoSilvio.View
{
    public partial class PdvTela : Form
    {


        public int totalfinal = 0;
        public PdvTela()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string registrowhopper = button1.Text = "1";
            textBox1.Text = registrowhopper;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string registrowhopperduplo = button2.Text = "2";
            textBox1.Text = registrowhopperduplo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string registroburguer = button3.Text = "3";
            textBox1.Text = registroburguer;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string registrorefri = button5.Text = "4";
            textBox1.Text = registrorefri;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string registrosucos = button6.Text = "5";
            textBox1.Text = registrosucos;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string registrosuco = button7.Text = "6";
            textBox1.Text = registrosuco;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            int qtd = ((int)numericUpDown1.Value);

            string[] itens = { "Whopper", "Whopper Duplo", "Hamburguer", "Refri", "Sucos", "Suco" };
            int[] valor = { 12, 18, 8, 10, 12, 12 };

            int total = qtd * valor[codigo - 1];

            totalfinal += total;

            dataGridView1.Rows.Add(itens[codigo - 1], qtd, valor[codigo - 1], total);

            label5.Text = "R$" + totalfinal.ToString();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.Text = String.Empty;
            textBox1.Text = String.Empty;
            numericUpDown1.Value = 0;
            dataGridView1.Rows.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TelaFechaVenda tela = new TelaFechaVenda(this);
            tela.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
