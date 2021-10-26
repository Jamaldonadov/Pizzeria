namespace Win.Pizzeria
{
    partial class FormNuestrasPizzas
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
            System.Windows.Forms.Label disponibleLabel;
            System.Windows.Forms.Label pedidoLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label tipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuestrasPizzas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ordenBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.ordenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ordenBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.disponibleCheckBox = new System.Windows.Forms.CheckBox();
            this.pedidoTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            disponibleLabel = new System.Windows.Forms.Label();
            pedidoLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingNavigator)).BeginInit();
            this.ordenBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // disponibleLabel
            // 
            disponibleLabel.AutoSize = true;
            disponibleLabel.Location = new System.Drawing.Point(112, 127);
            disponibleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            disponibleLabel.Name = "disponibleLabel";
            disponibleLabel.Size = new System.Drawing.Size(59, 13);
            disponibleLabel.TabIndex = 2;
            disponibleLabel.Text = "Disponible:";
            // 
            // pedidoLabel
            // 
            pedidoLabel.AutoSize = true;
            pedidoLabel.Location = new System.Drawing.Point(112, 57);
            pedidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            pedidoLabel.Name = "pedidoLabel";
            pedidoLabel.Size = new System.Drawing.Size(43, 13);
            pedidoLabel.TabIndex = 4;
            pedidoLabel.Text = "Pedido:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(112, 80);
            precioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(40, 13);
            precioLabel.TabIndex = 6;
            precioLabel.Text = "Precio:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new System.Drawing.Point(112, 102);
            tipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 8;
            tipoLabel.Text = "Tipo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Win.Pizzeria.Properties.Resources.Captura_de_pantalla__13_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 147);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 366);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ordenBindingNavigator
            // 
            this.ordenBindingNavigator.AddNewItem = null;
            this.ordenBindingNavigator.BindingSource = this.ordenBindingSource;
            this.ordenBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordenBindingNavigator.DeleteItem = null;
            this.ordenBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ordenBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordenBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.ordenBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordenBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordenBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordenBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordenBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordenBindingNavigator.Name = "ordenBindingNavigator";
            this.ordenBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordenBindingNavigator.Size = new System.Drawing.Size(502, 27);
            this.ordenBindingNavigator.TabIndex = 1;
            this.ordenBindingNavigator.Text = "bindingNavigator1";
            // 
            // ordenBindingSource
            // 
            this.ordenBindingSource.DataSource = typeof(BL.Pizzeria.NuestrasPizzas);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // ordenBindingNavigatorSaveItem
            // 
            this.ordenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordenBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordenBindingNavigatorSaveItem.Image")));
            this.ordenBindingNavigatorSaveItem.Name = "ordenBindingNavigatorSaveItem";
            this.ordenBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.ordenBindingNavigatorSaveItem.Text = "Guardar datos";
            this.ordenBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordenBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 24);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // disponibleCheckBox
            // 
            this.disponibleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ordenBindingSource, "Disponible", true));
            this.disponibleCheckBox.Location = new System.Drawing.Point(175, 123);
            this.disponibleCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.disponibleCheckBox.Name = "disponibleCheckBox";
            this.disponibleCheckBox.Size = new System.Drawing.Size(78, 20);
            this.disponibleCheckBox.TabIndex = 3;
            this.disponibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // pedidoTextBox
            // 
            this.pedidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenBindingSource, "Pedido", true));
            this.pedidoTextBox.Location = new System.Drawing.Point(175, 54);
            this.pedidoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pedidoTextBox.Name = "pedidoTextBox";
            this.pedidoTextBox.ReadOnly = true;
            this.pedidoTextBox.Size = new System.Drawing.Size(144, 20);
            this.pedidoTextBox.TabIndex = 5;
            this.pedidoTextBox.TextChanged += new System.EventHandler(this.pedidoTextBox_TextChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(175, 77);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(144, 20);
            this.precioTextBox.TabIndex = 7;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordenBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(175, 100);
            this.tipoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(144, 20);
            this.tipoTextBox.TabIndex = 9;
            // 
            // FormNuestrasPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 522);
            this.Controls.Add(disponibleLabel);
            this.Controls.Add(this.disponibleCheckBox);
            this.Controls.Add(pedidoLabel);
            this.Controls.Add(this.pedidoTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(this.ordenBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNuestrasPizzas";
            this.Text = "NuestrasPizzas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingNavigator)).EndInit();
            this.ordenBindingNavigator.ResumeLayout(false);
            this.ordenBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource ordenBindingSource;
        private System.Windows.Forms.BindingNavigator ordenBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ordenBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox disponibleCheckBox;
        private System.Windows.Forms.TextBox pedidoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}