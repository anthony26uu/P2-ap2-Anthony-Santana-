﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2_ap2__Anthony_Santana_.Consultas
{
    public partial class ConsultaEmpleados : Form
    {
        public ConsultaEmpleados()
        {
            InitializeComponent();
        }
        public void Llenar()
        {

            comboBox1.Items.Insert(0, "Id");
            comboBox1.Items.Insert(1, "Nombre");
            comboBox1.Items.Insert(2, "Fecha");


            //Si Colocas DiplayMember arriba no funcoina
            comboBox1.DataSource = comboBox1.Items;
            comboBox1.DisplayMember = "Id";


        }


        public bool Validar()
        {

            if (string.IsNullOrEmpty(buscaText.Text))
            {
                BuscarError.SetError(buscaText, "Favor llenar el campo");
                return false;

            }
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                BuscarError.SetError(comboBox1, "Favor seleccionar");
                return false;
            }
            return true;
        }



        public void SeleccionarOpcionCombo()
        {

            if (!Validar())
            {
                MessageBox.Show("Favor de llenar el campo");
                BuscarError.Clear();
            }
            else
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    dataGridView1.DataSource = BLL.EmpleadoBLL.Lista(p => p.RetencionId == Convert.ToInt32(buscaText.Text));
                }

                else if (comboBox1.SelectedIndex == 1)
                {
                    dataGridView1.DataSource = BLL.EmpleadoBLL.Lista(p => p.Nombre == buscaText.Text);

                }

                else if(comboBox1.SelectedIndex == 2)

                {
                   
                    dataGridView1.DataSource = BLL.EmpleadoBLL.Lista(p => p.FechaNacimiento >= DesdedateTimePicker.Value.Date && p.FechaNacimiento <= HatadateTimePicker1.Value.Date);
               
                }
                


            }

        }


        private void ConsultaEmpleados_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionarOpcionCombo();
        }
    }
}
