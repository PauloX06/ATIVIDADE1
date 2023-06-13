using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lb_resultado.Text = "";
            lb_cpf2.Text = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            mask_cpf.Clear();
            num_peso.ResetText();
            cmbSexo.ResetText();
            num_altura.ResetText();
            num_idade.ResetText();
            lb_resultado.Text = "";
            lb_cpf2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string cpf = mask_cpf.Text;
            double peso = Convert.ToDouble(num_peso.Text);
            string sexo = cmbSexo.Text;
            double altura = Convert.ToDouble(num_altura.Text);
            string idade = num_idade.Text;
 



            Pessoa p = new Pessoa(nome, cpf, peso, sexo, altura, idade);
            (double imc, string classificacao, string grau) = p.CalcularIMC();
            lb_resultado.Text = $"O IMC é: { imc.ToString("0.00")}  \n Classificação: {classificacao} \n Grau: {grau} " ;

            /*if (Validacoes.Validacpf(cpf) == true)
            {
                lb_cpf2.Text = "O cpf é valido";
            }
            else 
            {
                lb_cpf2.Text = "O cpf é invalido";
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
