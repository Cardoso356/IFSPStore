using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IFSPStore.App.Base
{
    public partial class CadastroBase : MaterialForm
    {
        protected bool IsAlteracao = false;

        public CadastroBase()
        {
            InitializeComponent();
        }

        private void botao_de_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar ?,", @"IFSP Store",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }



        private void LimpaCampos()
        {
            IsAlteracao = false;
            foreach (var control in TabControlCadastro.Controls)
            {
                if(control is MaterialTextBoxEdit){

                }
            }
        }

        protected virtual void CarregarGrid()
        {

        }

        protected virtual void Novo()
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Focus();
        }

        protected virtual void Salvar()
        {

        }

        protected virtual void Editar()
        {
            if(dataGridViewConsulta.SelectedRows.Count > 0)
            {
                IsAlteracao = true;
                var linha = dataGridViewConsulta.SelectedRows[0];
                CarregaRegistro(linha);
                TabControlCadastro.SelectedIndex = 0;
                TabControlCadastro.Focus();
            }
            else
            {
                MessageBox.Show(@"Selecione algum registro!", @"IFSP 
                    Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected virtual void Deletar(int id)
        {

        }

        protected virtual void CarregaRegistro(DataGridViewRow? linha)
        {

        }

        private void botao_salvar_Click(object sender, EventArgs e)
        {

        }

        private void botao_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void botao_editar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void botao_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                if(MessageBox.Show(@"Deseja realmente excluir", @"IFSP Store",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewConsulta.SelectedRows[0].Cells["id"].Value;
                    Excluir(id);
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show
                }
            }
            
        }
    }
