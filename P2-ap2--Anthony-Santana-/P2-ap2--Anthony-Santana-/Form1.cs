using P2_ap2__Anthony_Santana_.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P2_ap2__Anthony_Santana_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tiposEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroTipos db = new Registros.RegistroTipos();
            db.Show();
        }

        private void retencionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros.RegistroRetenciones db = new Registros.RegistroRetenciones();
            db.Show();
        }

        private void retencionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaRetenciones db = new ConsultaRetenciones();
                db.Show();

        }
    }
}
