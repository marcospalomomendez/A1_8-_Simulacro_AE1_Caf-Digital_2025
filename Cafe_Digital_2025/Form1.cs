using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Digital_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void cartasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carta carta = new Carta();
            carta.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedidos pedido = new Pedidos();
            pedido.ShowDialog();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            Carta carta = new Carta();
            carta.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cartel1_Load(object sender, EventArgs e)
        {

        }
    }
}
