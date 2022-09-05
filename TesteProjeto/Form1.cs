using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            País país = new País();

            país.Nome = txtNome.Text;
            país.Populacao = txtPopulacao.Text;
            país.Territorio = txtTerritorio.Text;
            país.ExpectativaVida = txtExpectativaVida.Text;
            país.PIB = txtPIB.Text;
            país.IDH = txtIDH.Text;

            System.Windows.Forms.MessageBox.Show(

                "Nome: " + país.Nome + "\n" +
                "População: " + país.Populacao + "\n" +
               "Território: " + país.Territorio + "\n" +
               "Expectativa de vida: " + país.ExpectativaVida + "\n" +
               "PIB: " + país.PIB + "\n" +
               "IDH:" + país.IDH
               );

        }
    }
}
