
namespace Ejercicio1
{
    partial class Form1
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
            this.lblInputNumeros = new System.Windows.Forms.Label();
            this.tbNumeros = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInputNumeros
            // 
            this.lblInputNumeros.AutoSize = true;
            this.lblInputNumeros.Location = new System.Drawing.Point(39, 33);
            this.lblInputNumeros.Name = "lblInputNumeros";
            this.lblInputNumeros.Size = new System.Drawing.Size(160, 13);
            this.lblInputNumeros.TabIndex = 0;
            this.lblInputNumeros.Text = "Ingresa Numeros para Sumarlos:";
            this.lblInputNumeros.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbNumeros
            // 
            this.tbNumeros.Location = new System.Drawing.Point(42, 65);
            this.tbNumeros.Name = "tbNumeros";
            this.tbNumeros.Size = new System.Drawing.Size(100, 20);
            this.tbNumeros.TabIndex = 1;
            this.tbNumeros.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(39, 255);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "0";
            this.lblResultado.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(42, 113);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.Location = new System.Drawing.Point(42, 161);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(100, 23);
            this.btnFinal.TabIndex = 4;
            this.btnFinal.Text = "Finalizar";
            this.btnFinal.UseVisualStyleBackColor = true;
            this.btnFinal.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 299);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinal);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.tbNumeros);
            this.Controls.Add(this.lblInputNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputNumeros;
        private System.Windows.Forms.TextBox tbNumeros;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Label label2;
    }
}

