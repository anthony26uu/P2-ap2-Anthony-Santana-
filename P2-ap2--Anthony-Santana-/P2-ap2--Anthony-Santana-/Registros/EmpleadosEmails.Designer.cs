namespace P2_ap2__Anthony_Santana_.Registros
{
    partial class EmpleadosEmails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadosEmails));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label empleadoIdLabel;
            System.Windows.Forms.Label retencionIdLabel;
            this.parcialDbDataSet2 = new P2_ap2__Anthony_Santana_.ParcialDbDataSet2();
            this.empleadosDescuentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosDescuentosTableAdapter = new P2_ap2__Anthony_Santana_.ParcialDbDataSet2TableAdapters.EmpleadosDescuentosTableAdapter();
            this.tableAdapterManager = new P2_ap2__Anthony_Santana_.ParcialDbDataSet2TableAdapters.TableAdapterManager();
            this.empleadosDescuentosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.empleadosDescuentosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.empleadoIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.retencionIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            idLabel = new System.Windows.Forms.Label();
            empleadoIdLabel = new System.Windows.Forms.Label();
            retencionIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parcialDbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDescuentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDescuentosBindingNavigator)).BeginInit();
            this.empleadosDescuentosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // parcialDbDataSet2
            // 
            this.parcialDbDataSet2.DataSetName = "ParcialDbDataSet2";
            this.parcialDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosDescuentosBindingSource
            // 
            this.empleadosDescuentosBindingSource.DataMember = "EmpleadosDescuentos";
            this.empleadosDescuentosBindingSource.DataSource = this.parcialDbDataSet2;
            // 
            // empleadosDescuentosTableAdapter
            // 
            this.empleadosDescuentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpleadosDescuentosTableAdapter = this.empleadosDescuentosTableAdapter;
            this.tableAdapterManager.EmpleadosEmailsTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.RetencionesTableAdapter = null;
            this.tableAdapterManager.TipoIdTableAdapter = null;
            this.tableAdapterManager.TiposEmailsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = P2_ap2__Anthony_Santana_.ParcialDbDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // empleadosDescuentosBindingNavigator
            // 
            this.empleadosDescuentosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.empleadosDescuentosBindingNavigator.BindingSource = this.empleadosDescuentosBindingSource;
            this.empleadosDescuentosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.empleadosDescuentosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.empleadosDescuentosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.empleadosDescuentosBindingNavigatorSaveItem});
            this.empleadosDescuentosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.empleadosDescuentosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.empleadosDescuentosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.empleadosDescuentosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.empleadosDescuentosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.empleadosDescuentosBindingNavigator.Name = "empleadosDescuentosBindingNavigator";
            this.empleadosDescuentosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.empleadosDescuentosBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.empleadosDescuentosBindingNavigator.TabIndex = 0;
            this.empleadosDescuentosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // empleadosDescuentosBindingNavigatorSaveItem
            // 
            this.empleadosDescuentosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.empleadosDescuentosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosDescuentosBindingNavigatorSaveItem.Image")));
            this.empleadosDescuentosBindingNavigatorSaveItem.Name = "empleadosDescuentosBindingNavigatorSaveItem";
            this.empleadosDescuentosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.empleadosDescuentosBindingNavigatorSaveItem.Text = "Save Data";
            this.empleadosDescuentosBindingNavigatorSaveItem.Click += new System.EventHandler(this.empleadosDescuentosBindingNavigatorSaveItem_Click_1);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(64, 103);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idMaskedTextBox
            // 
            this.idMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosDescuentosBindingSource, "Id", true));
            this.idMaskedTextBox.Location = new System.Drawing.Point(141, 100);
            this.idMaskedTextBox.Name = "idMaskedTextBox";
            this.idMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.idMaskedTextBox.TabIndex = 2;
            // 
            // empleadoIdLabel
            // 
            empleadoIdLabel.AutoSize = true;
            empleadoIdLabel.Location = new System.Drawing.Point(64, 129);
            empleadoIdLabel.Name = "empleadoIdLabel";
            empleadoIdLabel.Size = new System.Drawing.Size(69, 13);
            empleadoIdLabel.TabIndex = 3;
            empleadoIdLabel.Text = "Empleado Id:";
            // 
            // empleadoIdMaskedTextBox
            // 
            this.empleadoIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosDescuentosBindingSource, "EmpleadoId", true));
            this.empleadoIdMaskedTextBox.Location = new System.Drawing.Point(141, 126);
            this.empleadoIdMaskedTextBox.Name = "empleadoIdMaskedTextBox";
            this.empleadoIdMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.empleadoIdMaskedTextBox.TabIndex = 4;
            // 
            // retencionIdLabel
            // 
            retencionIdLabel.AutoSize = true;
            retencionIdLabel.Location = new System.Drawing.Point(64, 155);
            retencionIdLabel.Name = "retencionIdLabel";
            retencionIdLabel.Size = new System.Drawing.Size(71, 13);
            retencionIdLabel.TabIndex = 5;
            retencionIdLabel.Text = "Retencion Id:";
            // 
            // retencionIdMaskedTextBox
            // 
            this.retencionIdMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosDescuentosBindingSource, "RetencionId", true));
            this.retencionIdMaskedTextBox.Location = new System.Drawing.Point(141, 152);
            this.retencionIdMaskedTextBox.Name = "retencionIdMaskedTextBox";
            this.retencionIdMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.retencionIdMaskedTextBox.TabIndex = 6;
            // 
            // EmpleadosEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idMaskedTextBox);
            this.Controls.Add(empleadoIdLabel);
            this.Controls.Add(this.empleadoIdMaskedTextBox);
            this.Controls.Add(retencionIdLabel);
            this.Controls.Add(this.retencionIdMaskedTextBox);
            this.Controls.Add(this.empleadosDescuentosBindingNavigator);
            this.Name = "EmpleadosEmails";
            this.Text = "EmpleadosEmails";
            this.Load += new System.EventHandler(this.EmpleadosEmails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parcialDbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDescuentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDescuentosBindingNavigator)).EndInit();
            this.empleadosDescuentosBindingNavigator.ResumeLayout(false);
            this.empleadosDescuentosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ParcialDbDataSet2 parcialDbDataSet2;
        private System.Windows.Forms.BindingSource empleadosDescuentosBindingSource;
        private ParcialDbDataSet2TableAdapters.EmpleadosDescuentosTableAdapter empleadosDescuentosTableAdapter;
        private ParcialDbDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator empleadosDescuentosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton empleadosDescuentosBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox idMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox empleadoIdMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox retencionIdMaskedTextBox;
    }
}