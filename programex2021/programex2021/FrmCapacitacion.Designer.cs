
namespace programex2021
{
    partial class FrmCapacitacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bpresione = new System.Windows.Forms.Button();
            this.Blista = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.LBLresultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bcargar = new System.Windows.Forms.Button();
            this.lblape = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.Bborrar = new System.Windows.Forms.Button();
            this.lbllista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bpresione
            // 
            this.Bpresione.Location = new System.Drawing.Point(655, 92);
            this.Bpresione.Name = "Bpresione";
            this.Bpresione.Size = new System.Drawing.Size(75, 23);
            this.Bpresione.TabIndex = 0;
            this.Bpresione.Text = "PRESIONE";
            this.Bpresione.UseVisualStyleBackColor = true;
            this.Bpresione.Click += new System.EventHandler(this.Bpresione_Click_1);
            // 
            // Blista
            // 
            this.Blista.Location = new System.Drawing.Point(655, 187);
            this.Blista.Name = "Blista";
            this.Blista.Size = new System.Drawing.Size(75, 23);
            this.Blista.TabIndex = 1;
            this.Blista.Text = "LISTA";
            this.Blista.UseVisualStyleBackColor = true;
            this.Blista.Click += new System.EventHandler(this.Blista_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(9, 67);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(54, 13);
            this.lblnombre.TabIndex = 2;
            this.lblnombre.Text = "NOMBRE";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(290, 67);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(37, 13);
            this.lbledad.TabIndex = 3;
            this.lbledad.Text = "EDAD";
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(424, 67);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(32, 13);
            this.lblcorreo.TabIndex = 4;
            this.lblcorreo.Text = "MAIL";
            this.lblcorreo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 92);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(268, 92);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 6;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(398, 92);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(100, 20);
            this.txtcorreo.TabIndex = 7;
            // 
            // LBLresultado
            // 
            this.LBLresultado.AutoSize = true;
            this.LBLresultado.Location = new System.Drawing.Point(242, 151);
            this.LBLresultado.Name = "LBLresultado";
            this.LBLresultado.Size = new System.Drawing.Size(0, 13);
            this.LBLresultado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "CAPACITACION DE: ***THE MAGIC IN THE WORD***";
            // 
            // Bcargar
            // 
            this.Bcargar.Location = new System.Drawing.Point(655, 141);
            this.Bcargar.Name = "Bcargar";
            this.Bcargar.Size = new System.Drawing.Size(75, 23);
            this.Bcargar.TabIndex = 10;
            this.Bcargar.Text = "CARGAR";
            this.Bcargar.UseVisualStyleBackColor = true;
            this.Bcargar.Click += new System.EventHandler(this.Bcargar_Click);
            // 
            // lblape
            // 
            this.lblape.AutoSize = true;
            this.lblape.Location = new System.Drawing.Point(163, 67);
            this.lblape.Name = "lblape";
            this.lblape.Size = new System.Drawing.Size(59, 13);
            this.lblape.TabIndex = 11;
            this.lblape.Text = "APELLIDO";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(142, 92);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(100, 20);
            this.txtapellido.TabIndex = 12;
            // 
            // Bborrar
            // 
            this.Bborrar.Location = new System.Drawing.Point(655, 232);
            this.Bborrar.Name = "Bborrar";
            this.Bborrar.Size = new System.Drawing.Size(75, 23);
            this.Bborrar.TabIndex = 13;
            this.Bborrar.Text = "BORRAR";
            this.Bborrar.UseVisualStyleBackColor = true;
            // 
            // lbllista
            // 
            this.lbllista.AutoSize = true;
            this.lbllista.Location = new System.Drawing.Point(39, 197);
            this.lbllista.Name = "lbllista";
            this.lbllista.Size = new System.Drawing.Size(37, 13);
            this.lbllista.TabIndex = 14;
            this.lbllista.Text = "LISTA";
            // 
            // FrmCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllista);
            this.Controls.Add(this.Bborrar);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.lblape);
            this.Controls.Add(this.Bcargar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLresultado);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.Blista);
            this.Controls.Add(this.Bpresione);
            this.Name = "FrmCapacitacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bpresione;
        private System.Windows.Forms.Button Blista;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label LBLresultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bcargar;
        private System.Windows.Forms.Label lblape;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button Bborrar;
        private System.Windows.Forms.Label lbllista;
    }
}

