using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ciclo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            double salario;
            if (double.TryParse(txtSalario.Text, out salario))
            {
                if (salario > 1500.00)
                {
                    rdbCorinthians.Checked = false;
                    rdbCorinthians.Enabled = false;
                }
                else rdbCorinthians.Enabled = true;
                
            }
        }

        private void txtAnonascimento_TextChanged(object sender, EventArgs e)
        {
            //txtAnonascimento.Text = DateTime.Now.Year.ToString();
            double nascimento;
            if (double.TryParse(txtAnonascimento.Text, out nascimento))
            {
                if (nascimento > 1970 && rdbSantos.Checked)
                {
                    MessageBox.Show("Não faz sentido que pessoas que nasceram depois de 1970 simpatizem com o Santos");
                    txtAnonascimento.Text ="";
                    return;
                }
            }
            if (nascimento >= Convert.ToDouble(DateTime.Now.Year))
            {
                MessageBox.Show("Para vai... vc não nasceu nesse ano!");
                txtAnonascimento.Text = "";
                return;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = 0,salario;
            int nascimento;
            string mostracomofez = "";
            if (!int.TryParse(txtAnonascimento.Text,out nascimento))
            {
                MessageBox.Show("Por favor digite o ano do seu nascimento corretamente");
                txtAnonascimento.Text ="";
                return;
            }
            if (!double.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("Por favor digite o salário corretamente");
                txtSalario.Text = "";
                return;
            }
            resultado = 100 * (Convert.ToDouble(DateTime.Now.Year - nascimento));
            mostracomofez += ("\n Idade = R$ " + resultado);
            if (rdbFeminino.Checked)
            {
                resultado += 1500.00;
                mostracomofez += "\n feminino = R$ 1500.00";
                
            }
            if (rdbMasculino.Checked)
            {
                resultado += 1000.00;
                mostracomofez += ("\n Masculino = R$ 1000.00");
            }
            if(nascimento >= 1900 && nascimento <= 1999)
            {
                resultado += 500.00;
                mostracomofez += ("\n Nascimento = R$ 500.00");
            }
            if (rdbCorinthians.Checked)
            {
                resultado += 5000.00;
                mostracomofez += ("\n Corinthians = R$ 5000.00");
            }
            if (rdbSantos.Checked)
            {
                resultado += 2000.00;
                mostracomofez += ("\n Santos = R$ 2000.00");
            }
            if (rdbSaopaulo.Checked)
            {
                resultado += 1000.00;
                mostracomofez += ("\n São Paulo = R$ 1000.00");
            }
            if (rdbPalmeiras.Checked)
            {
                resultado += -100.00;
                mostracomofez += ("\n Palmeiras = R$ -100.00");
            }
            if(salario <= 2500.00)
            {
                resultado += 2000.00;
                mostracomofez += ("\n Salário = R$ 2000.00");
            }
            if (salario > 2500.00 && salario <= 4500.00)
            {
                resultado += 1000.00;
                mostracomofez += ("\n Salário = R$ 1000.00");
            }
            if (chkCursandofaculdade.Checked)
            {
                resultado += 5000.00;
                mostracomofez += ("\n Cursando Faculdade = R$ 5000.00");
                if (rdbTecnologica.Checked)
                {
                    resultado += 3000.00;
                    mostracomofez += ("\n Tecnologia = R$ 3000.00");
                }
                if (rdbExatas.Checked)
                {
                    resultado += 2500.00;
                    mostracomofez += ("\n Exatas = R$ 2500.00");

                }
                if (rdbHumanas.Checked)
                {
                    resultado += 1000.00;
                    mostracomofez += ("Humanas = R$ 1000.00");
                }
            }
            lblResultado.Text = resultado.ToString("c");
            lblResultado.Visible = true;
            MessageBox.Show(mostracomofez);
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chkCursandofaculdade_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCursandofaculdade.Checked)
            {
                groupBox3.Visible = true;
            }else
            {
                groupBox3.Visible = false;
            }
        }

        private void rdbSaopaulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked && rdbSaopaulo.Checked)
            {
                MessageBox.Show("Não faz sentido que pessoas do sexo masculino simpatizem com o time São Paulo; ");
                rdbSaopaulo.Checked = false;
                
                return;
            }
        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMasculino.Checked && rdbSaopaulo.Checked)
            {
                MessageBox.Show("Não faz sentido que pessoas do sexo masculino simpatizem com o time São Paulo; ");
                rdbMasculino.Checked = false;
                return;
            }
            
        }

        private void rdbSantos_CheckedChanged(object sender, EventArgs e)
        {
            double nascimento;
            if (double.TryParse(txtAnonascimento.Text, out nascimento))
            {
                if (nascimento > 1970 && rdbSantos.Checked)
                {
                    MessageBox.Show("Não faz sentido que pessoas que nasceram depois de 1970 simpatizem com o Santos");
                    rdbSantos.Checked = false;
                    return;
                }
            }

        }

        private void rdbCorinthians_CheckedChanged(object sender, EventArgs e)
        {
            double salario;
            if (double.TryParse(txtSalario.Text, out salario))
            {
                if (salario > 1500.00 && rdbCorinthians.Checked)
                {
                    MessageBox.Show("Não faz sentido que pessoas que tenham salário superior a R$ 1500,00 simpatizem com o Corinthians; ");
                    rdbCorinthians.Checked = false;
                    return;
                }

            }
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
