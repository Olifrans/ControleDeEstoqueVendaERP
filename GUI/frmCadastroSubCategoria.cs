using BLL;
using DAL;
using Modelo;
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

        public void LimpaTela()
        {
            txtNome.Clear();
            txtScatCod.Clear();           
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
            try
            {
                //Leitura dos dados
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txtNome.Text;
                modelo.CatCod = Convert.ToInt32(cbCatCod.SelectedValue);

                //Objeto para grvar os dado no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                if (this.operacao == "inserir")
                {
                    //Cadastrar uma categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ScatCod.ToString());
                }
                else
                {
                    //Alterar uma categoria
                    modelo.ScatCod = Convert.ToInt32(txtScatCod.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotes(1);
            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotes(1);
            this.LimpaTela();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            alteraBotes(2);
            this.operacao = "alterar";
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
                    BLLSubCategoria bll = new BLLSubCategoria(cx);

                    bll.Excluir(Convert.ToInt32(txtScatCod.Text));
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
            frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                //Objeto para grvar os dado no banco de dados
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(cx);

                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtScatCod.Text = modelo.ScatCod.ToString();
                txtNome.Text = modelo.ScatNome;
                cbCatCod.SelectedValue = modelo.CatCod;
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
