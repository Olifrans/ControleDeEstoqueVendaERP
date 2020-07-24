using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroSubCategoria : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(cx);

            cbCatCod.DataSource = bll.Localizar(""); //Origem dos dados, retornando todos s dados da categoria mostrando na tela os dados nome e código
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotes(2);
            this.operacao = "inserir";
        }
    }
}
