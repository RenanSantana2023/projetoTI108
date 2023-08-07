using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadariaCarmel
{
    public partial class frmCalcula : Form
    {
        public frmCalcula()
        {
            InitializeComponent();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            //comentários de linha
            //Close();

            Application.Exit();

               
                
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = "";
            txtNumero2.Clear();
            lblResposta.Text = "";
            rdbSoma.Checked = false;
            rdbSubtracao.Checked = false;
            rdbDivisao.Checked = false;
            txtNumero1.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        { // declaração das variavéis
            double num1, num2, resp;

            //if (!(rdbSoma.Checked))
           // {
                //MessageBox.Show("selecione uma operação");
                
           // }

            //if (rdbSoma.Checked || rdbSubtracao.Checked || rdbDivisao.Checked || rdbMuntiplicacao)

            try
            {
                num1 = Convert.ToDouble(txtNumero1.Text);
                num2 = Convert.ToDouble(txtNumero2.Text);
                // estrutura de decisão
               
                // soma
                if (rdbSoma.Checked)
                {
                    resp = num1 + num2;
                    lblResposta.Text = resp.ToString();
                    
                }
                //subtração
                if (rdbSubtracao.Checked)
                {
                    resp = num1 - num2;
                    lblResposta.Text = resp.ToString();
                   
                }
                //muntiplicação
                if (rdbMuntiplicacao.Checked)
                {
                    resp = num1 * num2;
                    lblResposta.Text = resp.ToString();
                   
                }
                //divisão
                if (rdbDivisao.Checked)
                {
                    resp = num1 / num2;
                    lblResposta.Text = resp.ToString();
                
                    if (num2 == 0)
                    {
                        MessageBox.Show("impossivel dividir por 0");
                        txtNumero1.Text = "";
                        txtNumero2.Text = "";
                        lblResposta.Text = "";
                        rdbDivisao.Checked = false;
                        txtNumero1.Focus();

                    }

                    else
                    {
                        resp = num1 / num2;
                        // Pode-se colocar de forma global 
                        lblResposta.Text = resp.ToString();
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir somente números!!!");
                txtNumero1.Clear();
                txtNumero2.Text = "";
                txtNumero1.Focus();
            }

            {

            }
        }
    }
}
