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
    public partial class RegistroRetenciones : Form
    {
        Entidades.Retenciones retenciones ;
        public RegistroRetenciones()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool retorno = true;
            if (string.IsNullOrWhiteSpace(descripcionTextBox.Text))
            {
                errorProvider1.SetError(descripcionTextBox, "CAMPO VACIO");
                retorno = false;
            }

          
            if (string.IsNullOrWhiteSpace(valorTextBox.Text))
            {
                errorProvider1.SetError(valorTextBox, "CAMPO VACIO");
                retorno = false;
            }
            return retorno;
        }

        private void Limpiar()
        {
            descripcionTextBox.Clear();
            retencionIdMaskedTextBox.Clear();
            valorTextBox.Clear();
            errorProvider1.Clear();
            descripcionTextBox.Focus();
            retenciones = new Entidades.Retenciones();
        }

        private void RegistroRetenciones_Load(object sender, EventArgs e)
        {
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            var retenciones = new Entidades.Retenciones();
            int id = 0;

            try
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {

                    retenciones.Descripcion = descripcionTextBox.Text;
                    retenciones.Valor = Utilidades.TOIN(valorTextBox.Text);
                    retenciones.RetencionId = Utilidades.TOIN(retencionIdMaskedTextBox.Text);

                    if (id != retenciones.RetencionId)
                    {
                        BLL.RetencionesBLL.Mofidicar(retenciones);
                        MessageBox.Show("Modificada");
                    }
                    else
                    {
                        BLL.RetencionesBLL.Guardar(retenciones);
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(retencionIdMaskedTextBox.Text);
            Entidades.Retenciones retenciones;
            retenciones = BLL.RetencionesBLL.Buscar(p => p.RetencionId == id);
            if (retenciones != null)
            {
                retencionIdMaskedTextBox.Text = Convert.ToString(retenciones.RetencionId);
                descripcionTextBox.Text = retenciones.Descripcion;
                valorTextBox.Text = Convert.ToString(retenciones.Valor);
                MessageBox.Show("Resultados");

            }
            else
            {
                MessageBox.Show("No Existe");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(retencionIdMaskedTextBox.Text);
            // tipo = BLL.TiposEmailBLL.Buscar(id);


            var user = BLL.RetencionesBLL.Buscar(p => p.RetencionId == id);

            if (BLL.RetencionesBLL.Eliminar(user))
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
}
