using BLL;
using Entidades;
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
    public partial class RegistroTipos : Form
    {
        Entidades.TiposEmail tipo;
        public RegistroTipos()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool retorno = true;
            if(string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                errorProvider1.SetError(descripcionTextBox, "CAMPO VACIO");
                retorno = false;
            }
            return retorno;
        }

        private void Limpiar()
        {
            descripcionTextBox.Clear();
            tipoIdMaskedTextBox.Clear();
            descripcionTextBox.Focus();
            tipo = new Entidades.TiposEmail();
            errorProvider1.Clear();
        }


        private void tiposEmailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void RegistroTipos_Load(object sender, EventArgs e)
        {
            

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            var guardar = new Entidades.TiposEmail();
            int id =0;

            try
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {

                    guardar.Descripcion =descripcionTextBox.Text;
                  
                    guardar.TipoId = Utilidades.TOIN(tipoIdMaskedTextBox.Text);

                    if (id != guardar.TipoId)
                    {
                        BLL.TiposEmailBLL.Mofidicar(guardar);
                        MessageBox.Show("Modificada");
                    }
                    else
                    {
                        BLL.TiposEmailBLL.Guardar(guardar);
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

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(tipoIdMaskedTextBox.Text);
            Entidades.TiposEmail tipo;
            tipo = BLL.TiposEmailBLL.Buscar(p => p.TipoId == id);
            if(tipo != null)
            {
                tipoIdMaskedTextBox.Text = Convert.ToString(tipo.TipoId);
                descripcionTextBox.Text = tipo.Descripcion;
                MessageBox.Show("Resultados");

            }
            else
            {
                MessageBox.Show("No Existe");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            int id = int.Parse(tipoIdMaskedTextBox.Text);
            var user = BLL.TiposEmailBLL.Buscar(p => p.TipoId == id);

            if (BLL.TiposEmailBLL.Eliminar(user))
            {

                MessageBox.Show("El Tipo se ha Eliminado con exito.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el Tipo.");
            }
        }
    }
}
