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

            descripcionTextBox.Focus();
        }

        private void RegistroRetenciones_Load(object sender, EventArgs e)
        {
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            var guardar = new Entidades.Retenciones();
            int id = 0;

            try
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar los campos");
                }
                else
                {

                    guardar.Descripcion = descripcionTextBox.Text;

                    guardar.RetencionId = Utilidades.TOIN(retencionIdMaskedTextBox.Text);

                    if (id != guardar.RetencionId)
                    {
                        BLL.RetencionesBLL.Mofidicar(guardar);
                        MessageBox.Show("Modificada");
                    }
                    else
                    {
                        BLL.RetencionesBLL.Guardar(guardar);
                        MessageBox.Show("Agregado con exito!");
                    }




                }
               // Limpiar();
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
    }
}
