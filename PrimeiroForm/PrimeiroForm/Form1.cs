﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiroForm
{
    public partial class PrimeiroForm : Form
    {
        public PrimeiroForm()
        {
            InitializeComponent();
        }

        private void txtQuantidade1_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade1.Text == "0")
            {
                txtQuantidade1.Text = "";
            }
        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
            if (txtValor1.Text == "0")
            {
                txtValor1.Text = "";
            }
        }

        private void txtQuantidade2_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade2.Text == "0")
            {
                txtQuantidade2.Text = "";
            }
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {
            if (txtValor2.Text == "0")
            {
                txtValor2.Text = "";
            }
        }

        private void txtQuantidade3_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade3.Text == "0")
            {
                txtQuantidade3.Text = "";
            }
        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {
            if (txtValor3.Text == "0")
            {
                txtValor3.Text = "";
            }
        }

        private void txtQuantidade4_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidade4.Text == "0")
            {
                txtQuantidade4.Text = "";
            }
        }

        private void txtValor4_TextChanged(object sender, EventArgs e)
        {
            if (txtValor4.Text == "0")
            {
                txtValor4.Text = "";
            }
        }

        private void txtQuantidade1_Click(object sender, EventArgs e)
        {
            txtQuantidade1.Text = "";
        }

        private void txtValor1_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
        }

        private void txtQuantidade2_Click(object sender, EventArgs e)
        {
            txtQuantidade2.Text = "";
        }

        private void txtValor2_Click(object sender, EventArgs e)
        {
            txtValor2.Text = "";
        }

        private void txtQuantidade3_Click(object sender, EventArgs e)
        {
            txtQuantidade3.Text = "";
        }

        private void txtValor3_Click(object sender, EventArgs e)
        {
            txtValor3.Text = "";
        }

        private void txtQuantidade4_Click(object sender, EventArgs e)
        {
            txtQuantidade4.Text = "";
        }

        private void txtValor4_Click(object sender, EventArgs e)
        {
            txtValor4.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Quantidade1 = 0;
            try
            {

                Quantidade1 = Convert.ToInt32(txtQuantidade1.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Quantidade deve conter apenas números naturais");
                txtQuantidade1.Focus();
                return;
            } 
            double Valor1 = 0;
            try
            {

                Valor1 = Convert.ToDouble(txtValor1.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Valor deve conter apenas números reais");
                txtValor1.Focus();
                return;
            }
            int Quantidade2 = 0;
            try
            {

                Quantidade2 = Convert.ToInt32(txtQuantidade2.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Quantidade deve conter apenas números naturais");
                txtQuantidade2.Focus();
                return;
            }
            double Valor2 = 0;
            try
            {

                Valor2 = Convert.ToDouble(txtValor1.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Valor deve conter apenas números reais");
                txtValor2.Focus();
                return;
            }
            int Quantidade3 = 0;
            try
            {

                Quantidade3 = Convert.ToInt32(txtQuantidade3.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Quantidade deve conter apenas números naturais");
                txtQuantidade3.Focus();
                return;
            }
            double Valor3 = 0;
            try
            {

                Valor3 = Convert.ToDouble(txtValor3.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Valor deve conter apenas números reais");
                txtValor3.Focus();
                return;
            }
            int Quantidade4 = 0;
            try
            {

                Quantidade4 = Convert.ToInt32(txtQuantidade4.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Quantidade deve conter apenas números naturais");
                txtQuantidade4.Focus();
                return;
            }
            double Valor4 = 0;
            try
            {

                Valor4 = Convert.ToInt32(txtValor4.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Valor deve conter apenas números reais");
                txtValor4.Focus();
                return;
            }
        }

    }
}
