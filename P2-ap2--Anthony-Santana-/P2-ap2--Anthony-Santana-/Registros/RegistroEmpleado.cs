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
    public partial class RegistroEmpleado : Form
    {
        Entidades.Empleados empleadoG;
        List<Entidades.Empleados> lista;
        public RegistroEmpleado()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "CAMPO VACIO");
                retorno = false;
            }


            if (string.IsNullOrWhiteSpace(sueldoMaskedTextBox.Text))
            {
                errorProvider1.SetError(sueldoMaskedTextBox, "CAMPO VACIO");
                retorno = false;
            }
            return retorno;
        }

        private void Limpiar()
        {
            empleadoIdMaskedTextBox.Clear();
            nombreTextBox.Clear();
            sueldoMaskedTextBox.Clear();
            nombreTextBox.Focus();
          
            empleadoG = new Entidades.Empleados();
        }

        private void LlenarCombo()
        {

            List<Entidades.Retenciones> lista = BLL.RetencionesBLL.GetListodo();


            retencionIdComboBox.DataSource = lista;
     


       //     List<Entidades.Empleados> lista = BLL.EmpleadoBLL.Lista();
         //   retencionIdComboBox.DataSource = lista;

            retencionIdComboBox.DisplayMember = "Descripcion";
            retencionIdComboBox.ValueMember = "RetencionId";

        }

        private void LlenarData(Entidades.Empleados n)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = n.RetencionId;

        }


        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {
            LlenarCombo();

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            var empleado = new Entidades.Empleados();
            int id = 0;

            try
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {

                    empleado.Nombre = nombreTextBox.Text;

                    empleado.EmpleadoId = Utilidades.TOIN(empleadoIdMaskedTextBox.Text);
                     empleado.FechaNacimiento = Convert.ToDateTime(fechaNacimientoDateTimePicker.Text);
                    empleado.Sueldo = Convert.ToDouble(sueldoMaskedTextBox.Text);

                    if (id != empleado.EmpleadoId)
                    {
                        BLL.EmpleadoBLL.Mofidicar(empleado);
                        MessageBox.Show("Modificada");
                    }
                    else
                    {
                        BLL.EmpleadoBLL.Guardar(empleado);
                        MessageBox.Show("Agregado con exito!");
                    }




                }
                Limpiar();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(empleadoIdMaskedTextBox.Text);
            // tipo = BLL.TiposEmailBLL.Buscar(id);


            var user = BLL.EmpleadoBLL.Buscar(p => p.EmpleadoId == id);

            if (BLL.EmpleadoBLL.Eliminar(user))
            {


                MessageBox.Show("Eliminado con exito.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar .");
            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(empleadoIdMaskedTextBox.Text);
            Entidades.Empleados empleado;
            empleado = BLL.EmpleadoBLL.Buscar(p => p.EmpleadoId == id);
            if (empleado != null)
            {
                nombreTextBox.Text = empleado.Nombre;
                sueldoMaskedTextBox.Text = Convert.ToString(empleado.Sueldo);
                fechaNacimientoDateTimePicker.Text = Convert.ToString(empleado.FechaNacimiento);


                MessageBox.Show("Resultados");

            }
            else
            {
                MessageBox.Show("No Existe");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            lista = (Entidades.Retenciones) Convert.;// Combo
           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }
    }
}
