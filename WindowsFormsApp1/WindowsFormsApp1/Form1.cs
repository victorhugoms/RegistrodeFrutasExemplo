using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Fruta> lista;

        public Form1()
        {

            InitializeComponent();
            lista = new List<Fruta>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                Fruta f = new Fruta();
                f.nome = txtNome.Text;
                f.quantidade = Convert.ToInt32(nudQuantidade.Value);
                f.preco = Convert.ToDouble(nudPreco.Value);
                if (rbMadura.Checked)
                    f.tipo = "Madura";
                else
                    f.tipo = "Verde";

                lista.Add(f);
                Registros();





            }
        }

        private void Registros()
        {
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = lista;
         }
    }

}
