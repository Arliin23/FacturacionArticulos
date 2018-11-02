namespace Facturacion_Articulos
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.cmdPedidos = new System.Windows.Forms.Button();
            this.cmdAyuda = new System.Windows.Forms.Button();
            this.cmdFactura = new System.Windows.Forms.Button();
            this.cmdAlbaran = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdPedidos
            // 
            this.cmdPedidos.FlatAppearance.BorderSize = 0;
            this.cmdPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPedidos.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdPedidos.Image = ((System.Drawing.Image)(resources.GetObject("cmdPedidos.Image")));
            this.cmdPedidos.Location = new System.Drawing.Point(96, 12);
            this.cmdPedidos.Name = "cmdPedidos";
            this.cmdPedidos.Size = new System.Drawing.Size(122, 153);
            this.cmdPedidos.TabIndex = 0;
            this.cmdPedidos.Text = "Pedidos";
            this.cmdPedidos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdPedidos.UseVisualStyleBackColor = true;
            // 
            // cmdAyuda
            // 
            this.cmdAyuda.FlatAppearance.BorderSize = 0;
            this.cmdAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAyuda.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdAyuda.Image = ((System.Drawing.Image)(resources.GetObject("cmdAyuda.Image")));
            this.cmdAyuda.Location = new System.Drawing.Point(331, 200);
            this.cmdAyuda.Name = "cmdAyuda";
            this.cmdAyuda.Size = new System.Drawing.Size(139, 145);
            this.cmdAyuda.TabIndex = 1;
            this.cmdAyuda.Text = "Ayuda";
            this.cmdAyuda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAyuda.UseVisualStyleBackColor = true;
            // 
            // cmdFactura
            // 
            this.cmdFactura.FlatAppearance.BorderSize = 0;
            this.cmdFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFactura.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdFactura.Image = ((System.Drawing.Image)(resources.GetObject("cmdFactura.Image")));
            this.cmdFactura.Location = new System.Drawing.Point(96, 200);
            this.cmdFactura.Name = "cmdFactura";
            this.cmdFactura.Size = new System.Drawing.Size(122, 145);
            this.cmdFactura.TabIndex = 2;
            this.cmdFactura.Text = "Factura";
            this.cmdFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdFactura.UseVisualStyleBackColor = true;
            this.cmdFactura.Click += new System.EventHandler(this.cmdFactura_Click);
            // 
            // cmdAlbaran
            // 
            this.cmdAlbaran.FlatAppearance.BorderSize = 0;
            this.cmdAlbaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAlbaran.ForeColor = System.Drawing.Color.AliceBlue;
            this.cmdAlbaran.Image = ((System.Drawing.Image)(resources.GetObject("cmdAlbaran.Image")));
            this.cmdAlbaran.Location = new System.Drawing.Point(331, 20);
            this.cmdAlbaran.Name = "cmdAlbaran";
            this.cmdAlbaran.Size = new System.Drawing.Size(139, 145);
            this.cmdAlbaran.TabIndex = 3;
            this.cmdAlbaran.Text = "Albarán";
            this.cmdAlbaran.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdAlbaran.UseVisualStyleBackColor = true;
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.FlatAppearance.BorderSize = 0;
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCerrar.Image")));
            this.cmdCerrar.Location = new System.Drawing.Point(544, 358);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(51, 66);
            this.cmdCerrar.TabIndex = 9;
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(607, 436);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdAlbaran);
            this.Controls.Add(this.cmdFactura);
            this.Controls.Add(this.cmdAyuda);
            this.Controls.Add(this.cmdPedidos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdPedidos;
        private System.Windows.Forms.Button cmdAyuda;
        private System.Windows.Forms.Button cmdFactura;
        private System.Windows.Forms.Button cmdAlbaran;
        private System.Windows.Forms.Button cmdCerrar;
    }
}