﻿namespace ejerciciosDeLaClase
{
    partial class POO
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MarcatextBox = new System.Windows.Forms.TextBox();
            this.ModelotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KmtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cochesGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cochesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MarcatextBox
            // 
            this.MarcatextBox.Location = new System.Drawing.Point(175, 41);
            this.MarcatextBox.Name = "MarcatextBox";
            this.MarcatextBox.Size = new System.Drawing.Size(154, 20);
            this.MarcatextBox.TabIndex = 2;
            // 
            // ModelotextBox
            // 
            this.ModelotextBox.Location = new System.Drawing.Point(175, 67);
            this.ModelotextBox.Name = "ModelotextBox";
            this.ModelotextBox.Size = new System.Drawing.Size(154, 20);
            this.ModelotextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(175, 93);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(154, 20);
            this.PreciotextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio";
            // 
            // KmtextBox
            // 
            this.KmtextBox.Location = new System.Drawing.Point(175, 121);
            this.KmtextBox.Name = "KmtextBox";
            this.KmtextBox.Size = new System.Drawing.Size(154, 20);
            this.KmtextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilometros";
            // 
            // cochesGridView
            // 
            this.cochesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cochesGridView.Location = new System.Drawing.Point(1, 210);
            this.cochesGridView.Name = "cochesGridView";
            this.cochesGridView.Size = new System.Drawing.Size(797, 228);
            this.cochesGridView.TabIndex = 9;
            // 
            // POO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cochesGridView);
            this.Controls.Add(this.KmtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModelotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MarcatextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "POO";
            this.Text = "POO";
            ((System.ComponentModel.ISupportInitialize)(this.cochesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MarcatextBox;
        private System.Windows.Forms.TextBox ModelotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox KmtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView cochesGridView;
    }
}