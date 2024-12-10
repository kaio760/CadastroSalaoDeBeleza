using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_cabelo_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_cabelo.Checked == true)
                listBoxServicos.Items.Add(Box_cabelo.Text);
            else
                listBoxServicos.Items.Remove(Box_cabelo.Text);
        }

        private void Box_unhaPe_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_unhaPe.Checked == true)
                listBoxServicos.Items.Add(Box_unhaPe.Text);
            else
                listBoxServicos.Items.Remove(Box_unhaPe.Text);
        }

        private void Box_unhaMao_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_unhaMao.Checked == true)
                listBoxServicos.Items.Add(Box_unhaMao.Text);
            else
                listBoxServicos.Items.Remove(Box_unhaMao.Text);
        }

        private void Box_facial_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_facial.Checked == true)
                listBoxServicos.Items.Add(Box_facial.Text);
            else
                listBoxServicos.Items.Remove(Box_facial.Text);
        }

        private void Box_barbear_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_barbear.Checked == true)
                listBoxServicos.Items.Add(Box_barbear.Text);
            else
                listBoxServicos.Items.Remove(Box_barbear.Text);
        }

        private void Box_cera_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_cera.Checked == true)
                listBoxServicos.Items.Add(Box_cera.Text);
            else
                listBoxServicos.Items.Remove(Box_cera.Text);
        }

        private void Box_quiropraxistas_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_quiropraxistas.Checked == true)
                listBoxServicos.Items.Add(Box_quiropraxistas.Text);
            else
                listBoxServicos.Items.Remove(Box_quiropraxistas.Text);
        }

        private void Box_massagem_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_massagem.Checked == true)
                listBoxServicos.Items.Add(Box_massagem.Text);
            else
                listBoxServicos.Items.Remove(Box_massagem.Text);
        }

        private void Box_tintura_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_tintura.Checked == true)
                listBoxServicos.Items.Add(Box_tintura.Text);
            else
                listBoxServicos.Items.Remove(Box_tintura.Text);
        }

        private void Box_maquiagem_CheckedChanged(object sender, EventArgs e)
        {
            if (Box_maquiagem.Checked == true)
                listBoxServicos.Items.Add(Box_maquiagem.Text);
            else
                listBoxServicos.Items.Remove(Box_maquiagem.Text);
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_email.Clear();
            txt_nascimento.Clear();
            Mtb_rg.Clear();
            Mtb_cpf.Clear();
            Mtb_cep.Clear();
            Mtb_celular.Clear();
            Radio_masculino.Checked = false;
            Radio_feminino.Checked = false;
            Radio_sem.Checked = false;

            string[] vetor = new string[5];

            try
            {

                for (int i = 0; i < listBoxServicos.Items.Count; i++)
                {
                    vetor[i] = listBoxServicos.Items[i].ToString();
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                {
                    MessageBox.Show("O valor máximo para posição do vetor é 5. Desmarque serviços", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            rctVetor.Clear();

            for (int j = 0; j < 5; j++)
            {
                rctVetor.Text = rctVetor.Text + vetor[j] + "\\";
            }
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //usar o char para não permitir pontuação ou numero

            if (char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }
    }
}
