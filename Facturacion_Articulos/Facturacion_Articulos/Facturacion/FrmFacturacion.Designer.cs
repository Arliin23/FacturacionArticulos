namespace Facturacion_Articulos
{
    partial class FrmFacturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturacion));
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmdFinVenta = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvArticulosFactura = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdAgregarArticulo = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cbxCantidadDisponible = new System.Windows.Forms.ComboBox();
            this.articuloFacturableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionBDDataSet1 = new Facturacion_Articulos.FacturacionBDDataSet1();
            this.cbxPrecio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NuDCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.articulo_FacturableTableAdapter = new Facturacion_Articulos.FacturacionBDDataSet1TableAdapters.Articulo_FacturableTableAdapter();
            this.facturacionBDDataSet2 = new Facturacion_Articulos.FacturacionBDDataSet2();
            this.articuloFacturableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.articulo_FacturableTableAdapter1 = new Facturacion_Articulos.FacturacionBDDataSet2TableAdapters.Articulo_FacturableTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloFacturableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuDCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionBDDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloFacturableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(135, 29);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(111, 23);
            this.txtTotal.TabIndex = 5;
            // 
            // cmdFinVenta
            // 
            this.cmdFinVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFinVenta.Location = new System.Drawing.Point(434, 489);
            this.cmdFinVenta.Name = "cmdFinVenta";
            this.cmdFinVenta.Size = new System.Drawing.Size(123, 58);
            this.cmdFinVenta.TabIndex = 8;
            this.cmdFinVenta.Text = "Finalizar Venta";
            this.cmdFinVenta.UseVisualStyleBackColor = true;
            this.cmdFinVenta.Click += new System.EventHandler(this.cmdFinVenta_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLimpiar.Location = new System.Drawing.Point(563, 489);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 58);
            this.cmdLimpiar.TabIndex = 9;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Location = new System.Drawing.Point(12, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 90);
            this.panel2.TabIndex = 11;
            // 
            // dgvArticulosFactura
            // 
            this.dgvArticulosFactura.AllowUserToDeleteRows = false;
            this.dgvArticulosFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulosFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulosFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Articulo,
            this.Precio,
            this.Cantidad});
            this.dgvArticulosFactura.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvArticulosFactura.Location = new System.Drawing.Point(12, 58);
            this.dgvArticulosFactura.Name = "dgvArticulosFactura";
            this.dgvArticulosFactura.ReadOnly = true;
            this.dgvArticulosFactura.Size = new System.Drawing.Size(626, 225);
            this.dgvArticulosFactura.TabIndex = 13;
            this.dgvArticulosFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulosFactura_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Articulo
            // 
            this.Articulo.HeaderText = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // cmdAgregarArticulo
            // 
            this.cmdAgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAgregarArticulo.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdAgregarArticulo.Image = global::Facturacion_Articulos.Properties.Resources.plus;
            this.cmdAgregarArticulo.Location = new System.Drawing.Point(367, 489);
            this.cmdAgregarArticulo.Name = "cmdAgregarArticulo";
            this.cmdAgregarArticulo.Size = new System.Drawing.Size(61, 58);
            this.cmdAgregarArticulo.TabIndex = 14;
            this.cmdAgregarArticulo.UseVisualStyleBackColor = true;
            this.cmdAgregarArticulo.Click += new System.EventHandler(this.cmdAgregarArticulo_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(592, 17);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 23);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbxCantidadDisponible
            // 
            this.cbxCantidadDisponible.DataSource = this.articuloFacturableBindingSource1;
            this.cbxCantidadDisponible.DisplayMember = "Cantidad";
            this.cbxCantidadDisponible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxCantidadDisponible.FormattingEnabled = true;
            this.cbxCantidadDisponible.Location = new System.Drawing.Point(510, 42);
            this.cbxCantidadDisponible.Name = "cbxCantidadDisponible";
            this.cbxCantidadDisponible.Size = new System.Drawing.Size(100, 23);
            this.cbxCantidadDisponible.TabIndex = 26;
            this.cbxCantidadDisponible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCantidadDisponible_KeyPress);
            // 
            // articuloFacturableBindingSource
            // 
            this.articuloFacturableBindingSource.DataMember = "Articulo_Facturable";
            this.articuloFacturableBindingSource.DataSource = this.facturacionBDDataSet1;
            // 
            // facturacionBDDataSet1
            // 
            this.facturacionBDDataSet1.DataSetName = "FacturacionBDDataSet1";
            this.facturacionBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxPrecio
            // 
            this.cbxPrecio.DataSource = this.articuloFacturableBindingSource1;
            this.cbxPrecio.DisplayMember = "Precio_Unitario";
            this.cbxPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxPrecio.FormattingEnabled = true;
            this.cbxPrecio.Location = new System.Drawing.Point(135, 131);
            this.cbxPrecio.Name = "cbxPrecio";
            this.cbxPrecio.Size = new System.Drawing.Size(89, 23);
            this.cbxPrecio.TabIndex = 25;
            this.cbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxPrecio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cantidad Disponible";
            // 
            // NuDCantidad
            // 
            this.NuDCantidad.Location = new System.Drawing.Point(510, 109);
            this.NuDCantidad.Name = "NuDCantidad";
            this.NuDCantidad.Size = new System.Drawing.Size(100, 23);
            this.NuDCantidad.TabIndex = 23;
            this.NuDCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NuDCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cantidad  a comprar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Precio";
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.DataSource = this.articuloFacturableBindingSource1;
            this.cbxArticulo.DisplayMember = "Nombre_Articulo";
            this.cbxArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Location = new System.Drawing.Point(135, 73);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Size = new System.Drawing.Size(167, 25);
            this.cbxArticulo.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Articulo";
            // 
            // cbxID
            // 
            this.cbxID.DataSource = this.articuloFacturableBindingSource1;
            this.cbxID.DisplayMember = "ID_Articulo";
            this.cbxID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxID.FormattingEnabled = true;
            this.cbxID.Location = new System.Drawing.Point(135, 17);
            this.cbxID.Name = "cbxID";
            this.cbxID.Size = new System.Drawing.Size(100, 25);
            this.cbxID.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxID);
            this.panel1.Controls.Add(this.cbxArticulo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbxPrecio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxCantidadDisponible);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NuDCantidad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 174);
            this.panel1.TabIndex = 27;
            // 
            // articulo_FacturableTableAdapter
            // 
            this.articulo_FacturableTableAdapter.ClearBeforeFill = true;
            // 
            // facturacionBDDataSet2
            // 
            this.facturacionBDDataSet2.DataSetName = "FacturacionBDDataSet2";
            this.facturacionBDDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloFacturableBindingSource1
            // 
            this.articuloFacturableBindingSource1.DataMember = "Articulo_Facturable";
            this.articuloFacturableBindingSource1.DataSource = this.facturacionBDDataSet2;
            // 
            // articulo_FacturableTableAdapter1
            // 
            this.articulo_FacturableTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(649, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdAgregarArticulo);
            this.Controls.Add(this.dgvArticulosFactura);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdFinVenta);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.AliceBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmFacturacion";
            this.Text = "FrmFacturacion";
            this.Load += new System.EventHandler(this.FrmFacturacion_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulosFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloFacturableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NuDCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionBDDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloFacturableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button cmdFinVenta;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dgvArticulosFactura;
        private System.Windows.Forms.Button cmdAgregarArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ComboBox cbxCantidadDisponible;
        private System.Windows.Forms.ComboBox cbxPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NuDCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxArticulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private FacturacionBDDataSet1 facturacionBDDataSet1;
        private System.Windows.Forms.BindingSource articuloFacturableBindingSource;
        private FacturacionBDDataSet1TableAdapters.Articulo_FacturableTableAdapter articulo_FacturableTableAdapter;
        private FacturacionBDDataSet2 facturacionBDDataSet2;
        private System.Windows.Forms.BindingSource articuloFacturableBindingSource1;
        private FacturacionBDDataSet2TableAdapters.Articulo_FacturableTableAdapter articulo_FacturableTableAdapter1;
    }
}