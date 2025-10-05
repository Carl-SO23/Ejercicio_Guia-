namespace WindowsFormsApplication1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonBonito = new System.Windows.Forms.Button();
            this.buttonLongitud = new System.Windows.Forms.Button();
            this.buttonAltura = new System.Windows.Forms.Button();
            this.buttonPalindromo = new System.Windows.Forms.Button();
            this.buttonMayusculas = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(25, 20);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(163, 23);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonBonito
            // 
            this.buttonBonito.Location = new System.Drawing.Point(25, 60);
            this.buttonBonito.Name = "buttonBonito";
            this.buttonBonito.Size = new System.Drawing.Size(163, 23);
            this.buttonBonito.TabIndex = 1;
            this.buttonBonito.Text = "¿Es bonito?";
            this.buttonBonito.UseVisualStyleBackColor = true;
            this.buttonBonito.Click += new System.EventHandler(this.buttonBonito_Click);
            // 
            // buttonLongitud
            // 
            this.buttonLongitud.Location = new System.Drawing.Point(25, 90);
            this.buttonLongitud.Name = "buttonLongitud";
            this.buttonLongitud.Size = new System.Drawing.Size(163, 23);
            this.buttonLongitud.TabIndex = 2;
            this.buttonLongitud.Text = "Longitud del nombre";
            this.buttonLongitud.UseVisualStyleBackColor = true;
            this.buttonLongitud.Click += new System.EventHandler(this.buttonLongitud_Click);
            // 
            // buttonAltura
            // 
            this.buttonAltura.Location = new System.Drawing.Point(25, 120);
            this.buttonAltura.Name = "buttonAltura";
            this.buttonAltura.Size = new System.Drawing.Size(163, 23);
            this.buttonAltura.TabIndex = 3;
            this.buttonAltura.Text = "¿Soy alto?";
            this.buttonAltura.UseVisualStyleBackColor = true;
            this.buttonAltura.Click += new System.EventHandler(this.buttonAltura_Click);
            // 
            // buttonPalindromo
            // 
            this.buttonPalindromo.Location = new System.Drawing.Point(25, 150);
            this.buttonPalindromo.Name = "buttonPalindromo";
            this.buttonPalindromo.Size = new System.Drawing.Size(163, 23);
            this.buttonPalindromo.TabIndex = 4;
            this.buttonPalindromo.Text = "¿Es palíndromo?";
            this.buttonPalindromo.UseVisualStyleBackColor = true;
            this.buttonPalindromo.Click += new System.EventHandler(this.buttonPalindromo_Click);
            // 
            // buttonMayusculas
            // 
            this.buttonMayusculas.Location = new System.Drawing.Point(25, 180);
            this.buttonMayusculas.Name = "buttonMayusculas";
            this.buttonMayusculas.Size = new System.Drawing.Size(163, 23);
            this.buttonMayusculas.TabIndex = 5;
            this.buttonMayusculas.Text = "A mayúsculas";
            this.buttonMayusculas.UseVisualStyleBackColor = true;
            this.buttonMayusculas.Click += new System.EventHandler(this.buttonMayusculas_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(210, 60);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(150, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(210, 120);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(150, 20);
            this.textBoxAltura.TabIndex = 7;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.textBoxAltura);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonMayusculas);
            this.Controls.Add(this.buttonPalindromo);
            this.Controls.Add(this.buttonAltura);
            this.Controls.Add(this.buttonLongitud);
            this.Controls.Add(this.buttonBonito);
            this.Controls.Add(this.buttonConectar);
            this.Name = "Form1";
            this.Text = "Cliente Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonBonito;
        private System.Windows.Forms.Button buttonLongitud;
        private System.Windows.Forms.Button buttonAltura;
        private System.Windows.Forms.Button buttonPalindromo;
        private System.Windows.Forms.Button buttonMayusculas;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxAltura;
    }
}
