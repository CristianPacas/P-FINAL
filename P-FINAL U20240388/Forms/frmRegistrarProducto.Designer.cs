namespace P_FINAL_U20240388.Forms
{
    partial class frmRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.dgvRegistro0 = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro0)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "REGISTRO DE MERCADERIA";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(63, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 24);
            this.txtNombre.TabIndex = 35;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Black;
            this.lblNombre.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Ivory;
            this.lblNombre.Location = new System.Drawing.Point(121, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 21);
            this.lblNombre.TabIndex = 34;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(63, 139);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(209, 24);
            this.txtPrecioUnitario.TabIndex = 37;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.BackColor = System.Drawing.Color.Black;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.ForeColor = System.Drawing.Color.Ivory;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(97, 115);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(139, 21);
            this.lblPrecioUnitario.TabIndex = 36;
            this.lblPrecioUnitario.Text = "PRECIO UNITARIO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(661, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(209, 24);
            this.txtCodigo.TabIndex = 39;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Black;
            this.lblCodigo.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Ivory;
            this.lblCodigo.Location = new System.Drawing.Point(719, 11);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(71, 21);
            this.lblCodigo.TabIndex = 38;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(661, 112);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(209, 24);
            this.txtCantidad.TabIndex = 41;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Black;
            this.lblCantidad.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Ivory;
            this.lblCantidad.Location = new System.Drawing.Point(719, 88);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(89, 21);
            this.lblCantidad.TabIndex = 40;
            this.lblCantidad.Text = "CANTIDAD:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(63, 211);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(209, 24);
            this.txtCategoria.TabIndex = 43;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Black;
            this.lblCategoria.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.Ivory;
            this.lblCategoria.Location = new System.Drawing.Point(121, 187);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(90, 21);
            this.lblCategoria.TabIndex = 42;
            this.lblCategoria.Text = "CATEGORIA";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Lime;
            this.btnRegistrar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(590, 142);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 54);
            this.btnRegistrar.TabIndex = 44;
            this.btnRegistrar.Text = "GUARDAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.BackColor = System.Drawing.Color.Red;
            this.btnCancelar2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar2.ForeColor = System.Drawing.Color.White;
            this.btnCancelar2.Location = new System.Drawing.Point(691, 195);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(117, 54);
            this.btnCancelar2.TabIndex = 45;
            this.btnCancelar2.Text = "CANCELAR";
            this.btnCancelar2.UseVisualStyleBackColor = false;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // dgvRegistro0
            // 
            this.dgvRegistro0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro0.Location = new System.Drawing.Point(0, 255);
            this.dgvRegistro0.Name = "dgvRegistro0";
            this.dgvRegistro0.RowHeadersWidth = 51;
            this.dgvRegistro0.RowTemplate.Height = 24;
            this.dgvRegistro0.Size = new System.Drawing.Size(930, 250);
            this.dgvRegistro0.TabIndex = 46;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Lime;
            this.btnEditar.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(801, 142);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 54);
            this.btnEditar.TabIndex = 47;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(930, 504);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvRegistro0);
            this.Controls.Add(this.btnCancelar2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtPrecioUnitario);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmRegistrarProducto";
            this.Text = "frmRegistrarProducto";
            this.Load += new System.EventHandler(this.frmRegistrarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.DataGridView dgvRegistro0;
        private System.Windows.Forms.Button btnEditar;
    }
}