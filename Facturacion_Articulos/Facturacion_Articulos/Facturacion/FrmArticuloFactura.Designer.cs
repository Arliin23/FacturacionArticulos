namespace Facturacion_Articulos.Facturacion
{
    partial class FrmArticuloFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticuloFactura));
            this.label3 = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NuDCantidad = new System.Windows.Forms.NumericUpDown();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.facturacionBDDataSet = new Facturacion_Articulos.FacturacionBDDataSet();
            this.articuloFacturableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.articulo_FacturableTableAdapter = new Facturacion_Articulos.FacturacionBDDataSetTableAdapters.Articulo_FacturableTableAdapter();
            this.txtCantidadDisponible = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NuDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionBDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloFacturableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID";
            // 
            // cbxID
            // 
            this.cbxID.DataSource = this.articuloFacturableBindingSource;
            this.cbxID.DisplayMember = "ID_Articulo";
            this.cbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(185, 42);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(121, 25);
            this.cbxID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Articulo";
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.DataSource = this.articuloFacturableBindingSource;
            this.cbxArticulo.DisplayMember = "Nombre_Articulo";
            this.cbxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Location = new System.Drawing.Point(185, 109);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Size = new System.Drawing.Size(121, 25);
            this.cbxArticulo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(185, 176);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            this.txtPrecio.Size = new System.Drawing.Size(121, 23);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad  a comprar";
            // 
            // NuDCantidad
            // 
            this.NuDCantidad.Location = new System.Drawing.Point(185, 316);
            this.NuDCantidad.Name = "NuDCantidad";
            this.NuDCantidad.Size = new System.Drawing.Size(121, 23);
            this.NuDCantidad.TabIndex = 10;
            this.NuDCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.FlatAppearance.BorderSize = 0;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.Location = new System.Drawing.Point(83, 366);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(51, 66);
            this.cmdGuardar.TabIndex = 11;
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.FlatAppearance.BorderSize = 0;
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(234, 366);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(51, 66);
            this.cmdCerrar.TabIndex = 12;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            // 
            // facturacionBDDataSet
            // 
            this.facturacionBDDataSet.DataSetName = "FacturacionBDDataSet";
            this.facturacionBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloFacturableBindingSource
            // 
            this.articuloFacturableBindingSource.DataMember = "Articulo_Facturable";
            this.articuloFacturableBindingSource.DataSource = this.facturacionBDDataSet;
            // 
            // articulo_FacturableTableAdapter
            // 
            this.articulo_FacturableTableAdapter.ClearBeforeFill = true;
            // 
            // txtCantidadDisponible
            // 
            this.txtCantidadDisponible.Location = new System.Drawing.Point(185, 246);
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.ReadOnly = true;
            this.txtCantidadDisponible.Size = new System.Drawing.Size(121, 23);
            this.txtCantidadDisponible.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantida Disponible";
            // 
            // FrmArticuloFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(373, 444);
            this.Controls.Add(this.txtCantidadDisponible);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.NuDCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxID);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmArticuloFactura";
            this.Text = "FrmArticuloFactura";
            this.Load += new System.EventHandler(this.FrmArticuloFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NuDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionBDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloFacturableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxArticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NuDCantidad;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdCerrar;
        private FacturacionBDDataSet facturacionBDDataSet;
        private System.Windows.Forms.BindingSource articuloFacturableBindingSource;
        private FacturacionBDDataSetTableAdapters.Articulo_FacturableTableAdapter articulo_FacturableTableAdapter;
        private System.Windows.Forms.TextBox txtCantidadDisponible;
        private System.Windows.Forms.Label label5;
    }
}