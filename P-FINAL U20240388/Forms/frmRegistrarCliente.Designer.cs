namespace P_FINAL_U20240388.Forms
{
    partial class frmRegistrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarCliente));
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.lblCodigo0 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombre0 = new System.Windows.Forms.Label();
            this.txtDUICliente = new System.Windows.Forms.TextBox();
            this.lblDUINIT = new System.Windows.Forms.Label();
            this.btnCancelar10 = new System.Windows.Forms.Button();
            this.btnGuardar10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(246, 139);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(209, 24);
            this.txtCodigoCliente.TabIndex = 15;
            this.txtCodigoCliente.TextChanged += new System.EventHandler(this.txtCodigoCliente_TextChanged);
            // 
            // lblCodigo0
            // 
            this.lblCodigo0.AutoSize = true;
            this.lblCodigo0.BackColor = System.Drawing.Color.Black;
            this.lblCodigo0.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo0.ForeColor = System.Drawing.Color.Ivory;
            this.lblCodigo0.Location = new System.Drawing.Point(303, 115);
            this.lblCodigo0.Name = "lblCodigo0";
            this.lblCodigo0.Size = new System.Drawing.Size(71, 21);
            this.lblCodigo0.TabIndex = 14;
            this.lblCodigo0.Text = "CODIGO:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(246, 244);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(209, 24);
            this.txtNombreCliente.TabIndex = 17;
            // 
            // lblNombre0
            // 
            this.lblNombre0.AutoSize = true;
            this.lblNombre0.BackColor = System.Drawing.Color.Black;
            this.lblNombre0.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre0.ForeColor = System.Drawing.Color.Ivory;
            this.lblNombre0.Location = new System.Drawing.Point(303, 220);
            this.lblNombre0.Name = "lblNombre0";
            this.lblNombre0.Size = new System.Drawing.Size(81, 21);
            this.lblNombre0.TabIndex = 16;
            this.lblNombre0.Text = "NOMBRE:";
            // 
            // txtDUICliente
            // 
            this.txtDUICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDUICliente.Location = new System.Drawing.Point(246, 331);
            this.txtDUICliente.Name = "txtDUICliente";
            this.txtDUICliente.Size = new System.Drawing.Size(209, 24);
            this.txtDUICliente.TabIndex = 19;
            this.txtDUICliente.TextChanged += new System.EventHandler(this.txtDUICliente_TextChanged);
            // 
            // lblDUINIT
            // 
            this.lblDUINIT.AutoSize = true;
            this.lblDUINIT.BackColor = System.Drawing.Color.Black;
            this.lblDUINIT.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUINIT.ForeColor = System.Drawing.Color.Ivory;
            this.lblDUINIT.Location = new System.Drawing.Point(303, 307);
            this.lblDUINIT.Name = "lblDUINIT";
            this.lblDUINIT.Size = new System.Drawing.Size(76, 21);
            this.lblDUINIT.TabIndex = 18;
            this.lblDUINIT.Text = "DUI/NIT:";
            // 
            // btnCancelar10
            // 
            this.btnCancelar10.BackColor = System.Drawing.Color.Red;
            this.btnCancelar10.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar10.ForeColor = System.Drawing.Color.White;
            this.btnCancelar10.Location = new System.Drawing.Point(365, 376);
            this.btnCancelar10.Name = "btnCancelar10";
            this.btnCancelar10.Size = new System.Drawing.Size(117, 54);
            this.btnCancelar10.TabIndex = 47;
            this.btnCancelar10.Text = "CANCELAR";
            this.btnCancelar10.UseVisualStyleBackColor = false;
            // 
            // btnGuardar10
            // 
            this.btnGuardar10.BackColor = System.Drawing.Color.Lime;
            this.btnGuardar10.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar10.ForeColor = System.Drawing.Color.White;
            this.btnGuardar10.Location = new System.Drawing.Point(207, 376);
            this.btnGuardar10.Name = "btnGuardar10";
            this.btnGuardar10.Size = new System.Drawing.Size(117, 54);
            this.btnGuardar10.TabIndex = 46;
            this.btnGuardar10.Text = "GUARDAR";
            this.btnGuardar10.UseVisualStyleBackColor = false;
            this.btnGuardar10.Click += new System.EventHandler(this.btnGuardar10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(241, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 29);
            this.label4.TabIndex = 48;
            this.label4.Text = "REGISTRO DE CLIENTE";
            // 
            // frmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 707);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar10);
            this.Controls.Add(this.btnGuardar10);
            this.Controls.Add(this.txtDUICliente);
            this.Controls.Add(this.lblDUINIT);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblNombre0);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.lblCodigo0);
            this.Name = "frmRegistrarCliente";
            this.Text = "frmRegistrarCliente";
            this.Load += new System.EventHandler(this.frmRegistrarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label lblCodigo0;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label lblNombre0;
        private System.Windows.Forms.TextBox txtDUICliente;
        private System.Windows.Forms.Label lblDUINIT;
        private System.Windows.Forms.Button btnCancelar10;
        private System.Windows.Forms.Button btnGuardar10;
        private System.Windows.Forms.Label label4;
    }
}