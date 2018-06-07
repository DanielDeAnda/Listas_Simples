using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas_simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista lista = new Lista();
        Auto nuevo;
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lista.agregarInicio(nuevo = new Auto(txtPlaca.Text,txtMarca.Text,txtModelo.Text,txtTelef.Text,txtAño.Text));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = lista.Listar();
        }

        private void btnElimPrim_Click(object sender, EventArgs e)
        {
            lista.eliminarPrimero();
        }

        private void btnElimUltim_Click(object sender, EventArgs e)
        {
            lista.eliminarUltimo();
        }

        private void btnRepInvers_Click(object sender, EventArgs e)
        {
            txtLista.Text = lista.reporteInverso();
        }
    }
}
