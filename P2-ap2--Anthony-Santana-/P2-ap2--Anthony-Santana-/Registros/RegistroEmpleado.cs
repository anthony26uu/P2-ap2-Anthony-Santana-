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
        Entidades.EmpleadosEmails Email;
        List<Entidades.Retenciones> listado;
        List<Entidades.TiposEmail> lista1;


        public RegistroEmpleado()
        {
            InitializeComponent();
         
            Limpiar();
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


            if (string.IsNullOrWhiteSpace(comboBoxRetenciones.Text))
            {
                errorProvider1.SetError(comboBoxRetenciones, "CAMPO VACIO");
                retorno = false;
            }


            if (string.IsNullOrWhiteSpace(comboBoTipo.Text))
            {
                errorProvider1.SetError(comboBoTipo, "CAMPO VACIO");
                retorno = false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                errorProvider1.SetError(textBoxEmail, "CAMPO VACIO");
                retorno = false;
            }

            if (string.IsNullOrWhiteSpace(Idtipo.Text))
            {
                errorProvider1.SetError(Idtipo, "CAMPO VACIO");
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
            errorProvider1.Clear();
            comboBoTipo.Text = null;
            textBoxEmail.Clear();
            Idtipo.Text = null;
            dataGridView1.DataSource = null;
            comboBoxRetenciones.Text=null;
            dataGridEmail.DataSource = null;
             Email= new Entidades.EmpleadosEmails();

            empleadoG = new Entidades.Empleados();
        }

        private void LlenarCombo()
        {
            List<Entidades.Retenciones> lista = BLL.RetencionesBLL.GetListodo();
            comboBoxRetenciones.DataSource = lista;
            comboBoxRetenciones.DisplayMember = "Descripcion";
            comboBoxRetenciones.ValueMember = "RetencionId";

        }

   


        private void LlenarComboEmails()
        {
            lista1 = BLL.TiposEmailBLL.GetListodo();
            Idtipo.DataSource = lista1;
            comboBoTipo.DataSource = lista1;

           
           Idtipo.DisplayMember = "TipoId";
           Idtipo.ValueMember = "TipoId";

            if (Idtipo.DisplayMember == "TipoId")
            {
                   
                comboBoTipo.ValueMember = "Descripcion";
            }
            else
            {
                Idtipo.DisplayMember = "TipoId";
            }

        }

        private void LlenarData(Entidades.Empleados n)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = n.RetencionesList.ToList();

        }

        private void LlenarDataEmail(Entidades.Empleados empleado)
        {
            dataGridEmail.DataSource = null;
            dataGridEmail.DataSource = empleado.EmailsList.ToList();
            
          this.dataGridEmail.Columns["Id"].Visible = false;
          this.dataGridEmail.Columns["EmpleadoId"].Visible = false;
          this.dataGridEmail.Columns["TipoEmail"].Visible = false;
       //  this.dataGridEmail.Columns["LisRelacion"].Visible = false;


        }


        private void RegistroEmpleado_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            LlenarComboEmails();

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

                    empleado.RetencionId = (int)comboBoxRetenciones.SelectedValue;

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
            if (string.IsNullOrWhiteSpace(empleadoIdMaskedTextBox.Text))
            {
                MessageBox.Show( "ID CAMPO VACIO");
                Limpiar();
                
            }
            else
            {
                  int id = int.Parse(empleadoIdMaskedTextBox.Text);
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

          
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(empleadoIdMaskedTextBox.Text))
            {
                MessageBox.Show("ID CAMPO VACIO");
                Limpiar();

            }
            else
            {
                int id = int.Parse(empleadoIdMaskedTextBox.Text);

                var empleado = BLL.EmpleadoBLL.Buscar(p => p.EmpleadoId == id);

                if (empleado != null)
                {

                    //Resultados busqueda empleado
                    nombreTextBox.Text = empleado.Nombre;
                    sueldoMaskedTextBox.Text = Convert.ToString(empleado.Sueldo);
                    fechaNacimientoDateTimePicker.Text = Convert.ToString(empleado.FechaNacimiento);

                    listado = BLL.RetencionesBLL.Lista(p => p.RetencionId == id);
                    lista1 = BLL.TiposEmailBLL.Lista(p => p.TipoId == id);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listado;

                    dataGridEmail.DataSource = null;
                    dataGridEmail.DataSource = lista1;

           //         LlenarDataEmail(empleadoG);

                    MessageBox.Show("Resultados");

                }
                else
                {
                    MessageBox.Show("No Existe");
                }
            }
               
        }

        //Boton Agregar Tuve problemas al cambiar nombre
         private void button1_Click(object sender, EventArgs e)
        {

          
            Entidades.Retenciones retencion = new Entidades.Retenciones();
            retencion= (Entidades.Retenciones)comboBoxRetenciones.SelectedItem;
            empleadoG.RetencionesList.Add(retencion);
            LlenarData(empleadoG);

        
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void AgregarEmailsDetalle_Click(object sender, EventArgs e)
        {
            empleadoG.AgregarDetalle(Email.TipoEmail, textBoxEmail.Text);

            LlenarDataEmail(empleadoG);
        }
    }
}
