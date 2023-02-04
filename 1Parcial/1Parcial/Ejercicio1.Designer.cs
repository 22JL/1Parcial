namespace _1Parcial
{
    partial class Ejercicio1
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
            this.components = new System.ComponentModel.Container();
            this.validarbutton = new System.Windows.Forms.Button();
            this.Número = new System.Windows.Forms.Label();
            this.num1textBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // validarbutton
            // 
            this.validarbutton.Location = new System.Drawing.Point(193, 108);
            this.validarbutton.Name = "validarbutton";
            this.validarbutton.Size = new System.Drawing.Size(167, 44);
            this.validarbutton.TabIndex = 0;
            this.validarbutton.Text = "Validar";
            this.validarbutton.UseVisualStyleBackColor = true;
            this.validarbutton.Click += new System.EventHandler(this.validarbutton_Click);
            // 
            // Número
            // 
            this.Número.AutoSize = true;
            this.Número.Location = new System.Drawing.Point(190, 55);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(44, 13);
            this.Número.TabIndex = 1;
            this.Número.Text = "Número";
            // 
            // num1textBox
            // 
            this.num1textBox.Location = new System.Drawing.Point(249, 52);
            this.num1textBox.Name = "num1textBox";
            this.num1textBox.Size = new System.Drawing.Size(111, 20);
            this.num1textBox.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.num1textBox);
            this.Controls.Add(this.Número);
            this.Controls.Add(this.validarbutton);
            this.Name = "Ejercicio1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button validarbutton;
        private System.Windows.Forms.Label Número;
        private System.Windows.Forms.TextBox num1textBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

