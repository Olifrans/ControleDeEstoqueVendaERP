using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelo;
using DAL;
using BLL;

namespace GUI
{
    public partial class frmCadastroCategoria : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void frmCadastroCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Limpar tela
            this.LimpaTela();
            this.alteraBotes(1);

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Leitura dos  na tela
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.CatNome = txtNome.Text;

                //Objeto para grvar os dado no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo "+modelo.CatCod.ToString());

                }
                else
                {
                    //Alterar uma categoria
                    modelo.CatCod = Convert.ToInt32(txtCodigo);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotes(1);
            }

            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotes(2);

        }

        private void btExcluir_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    //Objeto para grvar os dado no banco de dados
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCategoria bll = new BLLCategoria(cx);

                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossivél excluir o registro.  \n o registro esta sendo utilizado em outro local");
                this.alteraBotes(3);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCategoria f = new frmConsultaCategoria();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                //Objeto para grvar os dado no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                ModeloCategoria modelo = bll.CarregaModeloCategoria(f.codigo);
                txtCodigo.Text = modelo.CatCod.ToString();
                txtNome.Text = modelo.CatNome;
                alteraBotes(3);


            }
            else
            {
                this.LimpaTela();
                this.alteraBotes(1);
            }
            f.Dispose();
        }
    }
}
