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
    public partial class EmpleadosEmails : Form
    {
        public EmpleadosEmails()
        {
            InitializeComponent();
        }

        private void empleadosDescuentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosDescuentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parcialDbDataSet2);

        }

        private void empleadosDescuentosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosDescuentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parcialDbDataSet2);

        }

        private void EmpleadosEmails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parcialDbDataSet2.EmpleadosDescuentos' table. You can move, or remove it, as needed.
            this.empleadosDescuentosTableAdapter.Fill(this.parcialDbDataSet2.EmpleadosDescuentos);

        }
    }
}
