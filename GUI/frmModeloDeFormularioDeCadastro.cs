using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmModeloDeFormularioDeCadastro : Form
    {
        public String operacao;
        public frmModeloDeFormularioDeCadastro()
        {
            InitializeComponent();
        }

        public void alteraBotes(int op)
        {
            //op = Operações que ´podem ser feitas com os botôes
            // 1 = Prepara os botôes para inserir e localizar
            // 2 = Prepara os botôes para inserir/alterar um registro
            // 3 = Prepara a tela para excluir ou alterar

            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btExcluir.Enabled = false;
            btCancelar.Enabled = false;
            btSalvar.Enabled = false;

            if(op ==1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }

            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }

            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }




        private void btCancelar_Click(object sender, EventArgs e)
        {

        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmModeloDeFormularioDeCadastro_Load(object sender, EventArgs e)
        {
            this.alteraBotes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
