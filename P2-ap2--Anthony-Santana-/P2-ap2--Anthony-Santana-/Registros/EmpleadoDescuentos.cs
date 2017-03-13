using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2_ap2__Anthony_Santana_.Registros
{
    public partial class EmpleadoDescuentos : Form
    {
        List<Entidades.Empleados> listado;
        // List<Entidades.Retenciones> listadoR;
        Entidades.Retenciones listadoR;
        List<EmpleadoDescuentos> relaciones;

        public EmpleadoDescuentos()
        {
            InitializeComponent();
        }

    

        private void EmpleadoDescuentos_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listado.Add(new Entidades.Empleados(Convert.ToInt32(empleadoIdComboBox.Text)));

          //  listado.Add(new Entidades.Empleados(empleadoIdComboBox.Text,  empleadoIdComboBox.Text));

           dataGridView1.DataSource = null;
            dataGridView1.DataSource = listado;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
          


    }
}
}