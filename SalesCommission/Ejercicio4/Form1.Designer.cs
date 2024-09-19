
namespace Ejercicio4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnComprobarRango = new System.Windows.Forms.Button();
            this.tbVentas = new System.Windows.Forms.TextBox();
            this.tbSalario = new System.Windows.Forms.TextBox();
            this.lbListaRangos = new System.Windows.Forms.ListBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango de Salarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ventas en $:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salario en $:";
            // 
            // btnComprobarRango
            // 
            this.btnComprobarRango.Location = new System.Drawing.Point(46, 256);
            this.btnComprobarRango.Name = "btnComprobarRango";
            this.btnComprobarRango.Size = new System.Drawing.Size(100, 57);
            this.btnComprobarRango.TabIndex = 3;
            this.btnComprobarRango.Text = "Comprobar";
            this.btnComprobarRango.UseVisualStyleBackColor = true;
            this.btnComprobarRango.Click += new System.EventHandler(this.btnComprobarRango_Click);
            // 
            // tbVentas
            // 
            this.tbVentas.Location = new System.Drawing.Point(46, 132);
            this.tbVentas.Name = "tbVentas";
            this.tbVentas.Size = new System.Drawing.Size(100, 20);
            this.tbVentas.TabIndex = 4;
            // 
            // tbSalario
            // 
            this.tbSalario.Location = new System.Drawing.Point(46, 207);
            this.tbSalario.Name = "tbSalario";
            this.tbSalario.Size = new System.Drawing.Size(100, 20);
            this.tbSalario.TabIndex = 5;
            // 
            // lbListaRangos
            // 
            this.lbListaRangos.FormattingEnabled = true;
            this.lbListaRangos.Location = new System.Drawing.Point(214, 102);
            this.lbListaRangos.Name = "lbListaRangos";
            this.lbListaRangos.Size = new System.Drawing.Size(323, 303);
            this.lbListaRangos.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.lbListaRangos);
            this.Controls.Add(this.tbSalario);
            this.Controls.Add(this.tbVentas);
            this.Controls.Add(this.btnComprobarRango);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnComprobarRango;
        private System.Windows.Forms.TextBox tbVentas;
        private System.Windows.Forms.TextBox tbSalario;
        private System.Windows.Forms.ListBox lbListaRangos;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

