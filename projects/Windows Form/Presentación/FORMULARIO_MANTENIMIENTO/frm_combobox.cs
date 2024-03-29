﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIO_MANTENIMIENTO
{
    public partial class frm_combobox : Form
    {
        public frm_combobox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtResult.Text = "Seleccionado: " + cmbCursos.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbCursos.Items.Add(txtCursoNuevo.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string DiaTexto;
            decimal ValueGet = numericUpDown1.Value;
            switch (ValueGet)
            {
                case 1:
                    DiaTexto = "Lunes";
                    break;
                case 2:
                    DiaTexto = "Martes";
                    break;
                case 3:
                    DiaTexto = "Miercoles";
                    break;
                case 4:
                    DiaTexto = "Jueves";
                    break;
                case 5:
                    DiaTexto = "Viernes";
                    break;
                case 6:
                    DiaTexto = "Sabado";
                    break;
                case 7:
                    DiaTexto = "Domingo";
                    break;
                default:
                    DiaTexto = "No seleccionado";
                    break;
            }
            txtDia.Text = DiaTexto;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Increment(1);
                txtConteo.Text = progressBar1.Value.ToString();
                //progressBar1.Value = Contador;
                
            }

            
        }

        private void txtIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void txtDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblPercent.Text = "Porcentaje " + trackBar1.Value.ToString() + "%";
        }
    }
}
