using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace segundo_teste
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"User ID=aluno8;Password=aluno_5438;Data Source=localhost\SQLEXPRESS;Initial Catalog=Eproc_aluno8;Persist Security Info=True;Timeout=120;TrustServerCertificate=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            cmd.Connection = con;
            carregarLista();
        }

        private void add_produto_Click(object sender, EventArgs e)
        {
            if(txb_produtos.Text != "")
            {
                con.Open();
                cmd.CommandText = "INSERT INTO Produtos(alimentos) VALUES ('" + txb_produtos.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                carregarLista();

                contador.Text = list_produtos.Items.Count.ToString();

                txb_produtos.Text = "";
            }
        }

        private void carregarLista()
        {
            list_produtos.Items.Clear();

            con.Open();
            cmd.CommandText = "SELECT * FROM Produtos";
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    list_produtos.Items.Add(dr[0].ToString());
                }

            }

            contador.Text = list_produtos.Items.Count.ToString();

            con.Close();
        }

        private void remove_produto_Click(object sender, EventArgs e)
        {
            if (txb_produtos.Text != "")
            {
              con.Open();
                cmd.CommandText = "DELETE FROM Produtos WHERE alimentos = '" + txb_produtos.Text+"'";
                cmd.ExecuteNonQuery();
                con.Close();

                carregarLista();


                txb_produtos.Text = "";
            }

            else
            {
                MessageBox.Show("ADICIONE UM PRODUTO " + "\n" + "                  OU" + "\n" + "SELECIONE UM PRODUTO");
            }
        }

        private void list_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox l = sender as ListBox;

            if (l.SelectedIndex != -1)
            {
                list_produtos.SelectedIndex = l.SelectedIndex;

                txb_produtos.Text = list_produtos.SelectedItem.ToString();
            }
        }

        private void txb_produtos_Click(object sender, EventArgs e)
        {
            txb_produtos.Clear();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            if (txb_produtos.Text != "")
            {
                con.Open();
                cmd.CommandText = "DELETE FROM Produtos";
                cmd.ExecuteNonQuery();
                con.Close();

                carregarLista();


                txb_produtos.Text = "";
            }

            else
            {
                MessageBox.Show("SELECIONE UM ITEM DA TABELE!!");
            }


        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (txb_produtos.Text != "")
            {
                con.Open();
                cmd.CommandText = "UPDATE Produtos SET alimentos= '"+txb_produtos.Text+"' WHERE alimentos= '"+list_produtos.SelectedItem.ToString()+"' ";
                cmd.ExecuteNonQuery();
                con.Close();

                carregarLista();


                txb_produtos.Text = "";
            }

            else
            {
                MessageBox.Show("SELECIONE UM ITEM DA TABELE!!");
            }

        }
    }
    
}
