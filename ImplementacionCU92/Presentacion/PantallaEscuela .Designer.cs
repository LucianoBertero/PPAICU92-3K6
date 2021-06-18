namespace ImplementacionCU92.Presentacion
{
    partial class PantallaEscuela
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
            this.cmbEscuela = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidadVisitantes = new System.Windows.Forms.TextBox();
            this.btnConfirmarVisitantes = new System.Windows.Forms.Button();
            this.cmbSede = new System.Windows.Forms.ComboBox();
            this.lblSede = new System.Windows.Forms.Label();
            this.lblTipoVisita = new System.Windows.Forms.Label();
            this.cmbTipoVisita = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbEscuela
            // 
            this.cmbEscuela.FormattingEnabled = true;
            this.cmbEscuela.Location = new System.Drawing.Point(66, 12);
            this.cmbEscuela.Name = "cmbEscuela";
            this.cmbEscuela.Size = new System.Drawing.Size(121, 21);
            this.cmbEscuela.TabIndex = 0;
            this.cmbEscuela.SelectedIndexChanged += new System.EventHandler(this.cmbEscuela_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escuela:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(193, 15);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(159, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Ingrese La cantidad de Alumnos";
            this.lblCantidad.Visible = false;
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // txtCantidadVisitantes
            // 
            this.txtCantidadVisitantes.Location = new System.Drawing.Point(358, 12);
            this.txtCantidadVisitantes.Name = "txtCantidadVisitantes";
            this.txtCantidadVisitantes.Size = new System.Drawing.Size(69, 20);
            this.txtCantidadVisitantes.TabIndex = 3;
            this.txtCantidadVisitantes.Visible = false;
            // 
            // btnConfirmarVisitantes
            // 
            this.btnConfirmarVisitantes.Location = new System.Drawing.Point(450, 3);
            this.btnConfirmarVisitantes.Name = "btnConfirmarVisitantes";
            this.btnConfirmarVisitantes.Size = new System.Drawing.Size(90, 36);
            this.btnConfirmarVisitantes.TabIndex = 4;
            this.btnConfirmarVisitantes.Text = "Confirmar Visitantes";
            this.btnConfirmarVisitantes.UseVisualStyleBackColor = true;
            this.btnConfirmarVisitantes.Visible = false;
            this.btnConfirmarVisitantes.Click += new System.EventHandler(this.btnConfirmarVisitantes_Click);
            // 
            // cmbSede
            // 
            this.cmbSede.FormattingEnabled = true;
            this.cmbSede.Location = new System.Drawing.Point(66, 52);
            this.cmbSede.Name = "cmbSede";
            this.cmbSede.Size = new System.Drawing.Size(121, 21);
            this.cmbSede.TabIndex = 5;
            this.cmbSede.Visible = false;
            this.cmbSede.SelectedIndexChanged += new System.EventHandler(this.cmbSede_SelectedIndexChanged);
            // 
            // lblSede
            // 
            this.lblSede.AutoSize = true;
            this.lblSede.Location = new System.Drawing.Point(12, 60);
            this.lblSede.Name = "lblSede";
            this.lblSede.Size = new System.Drawing.Size(40, 13);
            this.lblSede.TabIndex = 6;
            this.lblSede.Text = "Sedes:";
            this.lblSede.Visible = false;
            // 
            // lblTipoVisita
            // 
            this.lblTipoVisita.AutoSize = true;
            this.lblTipoVisita.Location = new System.Drawing.Point(211, 55);
            this.lblTipoVisita.Name = "lblTipoVisita";
            this.lblTipoVisita.Size = new System.Drawing.Size(73, 13);
            this.lblTipoVisita.TabIndex = 7;
            this.lblTipoVisita.Text = "Tipo de visita:";
            this.lblTipoVisita.Visible = false;
            // 
            // cmbTipoVisita
            // 
            this.cmbTipoVisita.FormattingEnabled = true;
            this.cmbTipoVisita.Location = new System.Drawing.Point(316, 52);
            this.cmbTipoVisita.Name = "cmbTipoVisita";
            this.cmbTipoVisita.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVisita.TabIndex = 8;
            this.cmbTipoVisita.Visible = false;
            this.cmbTipoVisita.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVisita_SelectedIndexChanged);
            // 
            // PantallaEscuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 356);
            this.Controls.Add(this.cmbTipoVisita);
            this.Controls.Add(this.lblTipoVisita);
            this.Controls.Add(this.lblSede);
            this.Controls.Add(this.cmbSede);
            this.Controls.Add(this.btnConfirmarVisitantes);
            this.Controls.Add(this.txtCantidadVisitantes);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEscuela);
            this.Name = "PantallaEscuela";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEscuela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidadVisitantes;
        private System.Windows.Forms.Button btnConfirmarVisitantes;
        private System.Windows.Forms.ComboBox cmbSede;
        private System.Windows.Forms.Label lblSede;
        private System.Windows.Forms.Label lblTipoVisita;
        private System.Windows.Forms.ComboBox cmbTipoVisita;
    }
}