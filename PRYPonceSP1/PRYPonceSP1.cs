﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRYPonceSP1
{
    public partial class FrmPRYPonceSP1 : Form
    {
        public FrmPRYPonceSP1()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void bntAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" &&
                txtContraseña.Text == "Kamerun") ||
                (txtUsuario.Text == "Operador" &&
                txtContraseña.Text == "operando"))
            { 
            }
            else
            {
                MessageBox.Show("No es esta");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }
            }
            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
