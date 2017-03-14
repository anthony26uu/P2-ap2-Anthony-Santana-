namespace P2_ap2__Anthony_Santana_.Registros
{
    partial class RegistroEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label sueldoLabel;
            System.Windows.Forms.Label retencionIdLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroEmpleado));
            this.empleadoIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sueldoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxRetenciones = new System.Windows.Forms.ComboBox();
            this.AgregarRetenciones = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AgregarEmailsDetalle = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoTipo = new System.Windows.Forms.ComboBox();
            this.Idtipo = new System.Windows.Forms.ComboBox();
            this.dataGridEmail = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            empleadoIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            sueldoLabel = new System.Windows.Forms.Label();
            retencionIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Location = new System.Drawing.Point(12, 21);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(69, 13);
            empleadoIdLabel.TabIndex = 1;
            empleadoIdLabel.Text = "Empleado Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 47);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(12, 74);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 5;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // sueldoLabel
            // 
            sueldoLabel.AutoSize = true;
            sueldoLabel.Location = new System.Drawing.Point(12, 99);
            sueldoLabel.Name = "sueldoLabel";
            sueldoLabel.Size = new System.Drawing.Size(43, 13);
            sueldoLabel.TabIndex = 7;
            sueldoLabel.Text = "Sueldo:";
            // 
            // retencionIdLabel
            // 
            retencionIdLabel.AutoSize = true;
            retencionIdLabel.Location = new System.Drawing.Point(22, 35);
            retencionIdLabel.Name = "retencionIdLabel";
            retencionIdLabel.Size = new System.Drawing.Size(71, 13);
            retencionIdLabel.TabIndex = 5;
            retencionIdLabel.Text = "Retencion Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 5;
            label1.Text = "ID del Tipo";
            // 
            // empleadoIdMaskedTextBox
            // 
            this.empleadoIdMaskedTextBox.Location = new System.Drawing.Point(114, 18);
            this.empleadoIdMaskedTextBox.Mask = "99999";
            this.empleadoIdMaskedTextBox.Name = "empleadoIdMaskedTextBox";
            this.empleadoIdMaskedTextBox.Size = new System.Drawing.Size(119, 20);
            this.empleadoIdMaskedTextBox.TabIndex = 2;
            this.empleadoIdMaskedTextBox.ValidatingType = typeof(int);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(114, 44);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(114, 70);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 6;
            // 
            // sueldoMaskedTextBox
            // 
            this.sueldoMaskedTextBox.Location = new System.Drawing.Point(114, 96);
            this.sueldoMaskedTextBox.Mask = "99999";
            this.sueldoMaskedTextBox.Name = "sueldoMaskedTextBox";
            this.sueldoMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.sueldoMaskedTextBox.TabIndex = 8;
            this.sueldoMaskedTextBox.ValidatingType = typeof(int);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("buttonEliminar.Image")));
            this.buttonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEliminar.Location = new System.Drawing.Point(574, 346);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(60, 52);
            this.buttonEliminar.TabIndex = 58;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuardar.Image")));
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.Location = new System.Drawing.Point(485, 346);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(66, 52);
            this.buttonGuardar.TabIndex = 57;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("buttonNuevo.Image")));
            this.buttonNuevo.Location = new System.Drawing.Point(386, 348);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(66, 51);
            this.buttonNuevo.TabIndex = 56;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonbuscar.Image")));
            this.buttonbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonbuscar.Location = new System.Drawing.Point(249, 10);
            this.buttonbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(43, 29);
            this.buttonbuscar.TabIndex = 59;
            this.buttonbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonbuscar.UseVisualStyleBackColor = true;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxRetenciones);
            this.groupBox1.Controls.Add(this.AgregarRetenciones);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(retencionIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(15, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 181);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Retenciones";
            // 
            // comboBoxRetenciones
            // 
            this.comboBoxRetenciones.FormattingEnabled = true;
            this.comboBoxRetenciones.Location = new System.Drawing.Point(130, 27);
            this.comboBoxRetenciones.Name = "comboBoxRetenciones";
            this.comboBoxRetenciones.Size = new System.Drawing.Size(147, 21);
            this.comboBoxRetenciones.TabIndex = 64;
            // 
            // AgregarRetenciones
            // 
            this.AgregarRetenciones.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AgregarRetenciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarRetenciones.Image = ((System.Drawing.Image)(resources.GetObject("AgregarRetenciones.Image")));
            this.AgregarRetenciones.Location = new System.Drawing.Point(371, 27);
            this.AgregarRetenciones.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarRetenciones.Name = "AgregarRetenciones";
            this.AgregarRetenciones.Size = new System.Drawing.Size(56, 32);
            this.AgregarRetenciones.TabIndex = 63;
            this.AgregarRetenciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarRetenciones.UseVisualStyleBackColor = true;
            this.AgregarRetenciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 116);
            this.dataGridView1.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dataGridEmail);
            this.groupBox2.Controls.Add(this.Idtipo);
            this.groupBox2.Controls.Add(this.comboBoTipo);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.AgregarEmailsDetalle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Location = new System.Drawing.Point(539, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 247);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TIPO";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AgregarEmailsDetalle
            // 
            this.AgregarEmailsDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AgregarEmailsDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarEmailsDetalle.Image = ((System.Drawing.Image)(resources.GetObject("AgregarEmailsDetalle.Image")));
            this.AgregarEmailsDetalle.Location = new System.Drawing.Point(284, 30);
            this.AgregarEmailsDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarEmailsDetalle.Name = "AgregarEmailsDetalle";
            this.AgregarEmailsDetalle.Size = new System.Drawing.Size(56, 32);
            this.AgregarEmailsDetalle.TabIndex = 63;
            this.AgregarEmailsDetalle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AgregarEmailsDetalle.UseVisualStyleBackColor = true;
            this.AgregarEmailsDetalle.Click += new System.EventHandler(this.AgregarEmailsDetalle_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(322, 74);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(154, 20);
            this.textBoxEmail.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Descripcion Tipo:";
            // 
            // comboBoTipo
            // 
            this.comboBoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoTipo.FormattingEnabled = true;
            this.comboBoTipo.Location = new System.Drawing.Point(130, 76);
            this.comboBoTipo.Name = "comboBoTipo";
            this.comboBoTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoTipo.TabIndex = 74;
            // 
            // Idtipo
            // 
            this.Idtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Idtipo.FormattingEnabled = true;
            this.Idtipo.Location = new System.Drawing.Point(130, 35);
            this.Idtipo.Name = "Idtipo";
            this.Idtipo.Size = new System.Drawing.Size(121, 21);
            this.Idtipo.TabIndex = 75;
            // 
            // dataGridEmail
            // 
            this.dataGridEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmail.Location = new System.Drawing.Point(42, 103);
            this.dataGridEmail.Name = "dataGridEmail";
            this.dataGridEmail.Size = new System.Drawing.Size(502, 123);
            this.dataGridEmail.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Agregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Agregar";
            // 
            // RegistroEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(empleadoIdLabel);
            this.Controls.Add(this.empleadoIdMaskedTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(sueldoLabel);
            this.Controls.Add(this.sueldoMaskedTextBox);
            this.Name = "RegistroEmpleado";
            this.Text = "RegistroEmpleado";
            this.Load += new System.EventHandler(this.RegistroEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox empleadoIdMaskedTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.MaskedTextBox sueldoMaskedTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarRetenciones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AgregarEmailsDetalle;
        private System.Windows.Forms.ComboBox comboBoxRetenciones;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoTipo;
        private System.Windows.Forms.ComboBox Idtipo;
        private System.Windows.Forms.DataGridView dataGridEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}