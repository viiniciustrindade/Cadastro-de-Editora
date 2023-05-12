using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace Cadastro_de_Editora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        private void LoadID()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {


                SqlCommand cmd = new SqlCommand("SELECT IDENT_CURRENT('mvtBibEditora') + 1", connection);
                int proximoID = Convert.ToInt32(cmd.ExecuteScalar());


                txtcodEditora.Text = proximoID.ToString();

            }
        }
        private void CarregarUsuariosGrid()
        {
            dadosGrid.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                EditoraDAO dao = new EditoraDAO(connection);
                List<EditoraModel> editoras = dao.GetEditoras();
                foreach (EditoraModel editora in editoras)
                {
                    DataGridViewRow row = dadosGrid.Rows[dadosGrid.Rows.Add()];
                    row.Cells[colCodEditora.Index].Value = editora.codEditora;
                    row.Cells[colNomeEditora.Index].Value = editora.nomeEditora;

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
            LoadID();
            btn_Excluir.Enabled = false;
        }
        private void dadosGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtcodEditora.Text = dadosGrid.Rows[e.RowIndex].Cells[colCodEditora.Index].Value + "";
                txtNomeEditora.Text = dadosGrid.Rows[e.RowIndex].Cells[colNomeEditora.Index].Value + "";
                if (string.IsNullOrEmpty(this.txtNomeEditora.Text))
                {
                    btn_Excluir.Enabled = false;

                }
                else
                {
                    btn_Excluir.Enabled = true;
                }
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            if (string.IsNullOrEmpty(txtNomeEditora.Text) || string.IsNullOrWhiteSpace(txtNomeEditora.Text))
            {
                MessageBox.Show("Informe o campo [Nome]","Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    EditoraDAO dao = new EditoraDAO(connection);

                    string sql2 = "SELECT COUNT(codEditora) FROM mvtBibEditora WHERE codEditora = @codEditora";
                    SqlCommand cmdSelect = new SqlCommand(sql2, connection);
                    cmdSelect.Parameters.AddWithValue("@codEditora", txtcodEditora.Text);
                    int count = Convert.ToInt32(cmdSelect.ExecuteScalar());

                    if (count > 0)
                    {
                        dao.Alterar(new EditoraModel()
                        {
                            codEditora = txtcodEditora.Text,
                            nomeEditora = txtNomeEditora.Text,
                        });
                    }
                    else
                    {
                        dao.Salvar(new EditoraModel()
                        {
                            nomeEditora = txtNomeEditora.Text,
                        });
                    }


                    MessageBox.Show("Editora salva com sucesso!");
                    // se salvar deu certo carrega os usuários
                    CarregarUsuariosGrid();
                    LoadID();
                    btn_Excluir.Enabled = false;
                    txtNomeEditora.Text = "";
                }
            }
            catch (Exception ex)
            {
                // se salvar deu errado mostra mensagem
                MessageBox.Show($"Houve um problema ao salvar o usuário!\n{ex.Message}");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // Valida se o campo for NULL do banco, VAZIO = "" OU " "
            if (string.IsNullOrEmpty(txtNomeEditora.Text) || string.IsNullOrWhiteSpace(txtNomeEditora.Text))
            {
                MessageBox.Show("Editora não foi selecionada!","Atenção");
                return;
            }
            DialogResult confirmacao = MessageBox.Show("Deseja Excluir a Editora?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (confirmacao == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        EditoraDAO dao = new EditoraDAO(connection);
                        dao.Excluir(new EditoraModel()
                        {
                            codEditora = txtcodEditora.Text
                        });
                    }
                    MessageBox.Show("Editora excluída com sucesso!");
                    CarregarUsuariosGrid();
                    LoadID();
                    btn_Excluir.Enabled = false;
                    txtNomeEditora.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir a editora!\n{ex.Message}");
            }
        }
    }
}
