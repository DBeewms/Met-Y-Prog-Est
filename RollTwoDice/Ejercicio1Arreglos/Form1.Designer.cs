
namespace Ejercicio1Arreglos
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.dgvTablaResultados = new System.Windows.Forms.DataGridView();
            this.tbProbabilidades = new System.Windows.Forms.TextBox();
            this.tbProbabilidadesDe7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 22);
            this.label1.MinimumSize = new System.Drawing.Size(200, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tirar Dos Dados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLanzar
            // 
            this.btnLanzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLanzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanzar.Location = new System.Drawing.Point(530, 366);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(96, 43);
            this.btnLanzar.TabIndex = 1;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = false;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // dgvTablaResultados
            // 
            this.dgvTablaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaResultados.Location = new System.Drawing.Point(378, 100);
            this.dgvTablaResultados.Name = "dgvTablaResultados";
            this.dgvTablaResultados.Size = new System.Drawing.Size(385, 237);
            this.dgvTablaResultados.TabIndex = 3;
            this.dgvTablaResultados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaResultados_CellContentClick);
            // 
            // tbProbabilidades
            // 
            this.tbProbabilidades.Location = new System.Drawing.Point(39, 128);
            this.tbProbabilidades.Name = "tbProbabilidades";
            this.tbProbabilidades.Size = new System.Drawing.Size(288, 20);
            this.tbProbabilidades.TabIndex = 4;
            // 
            // tbProbabilidadesDe7
            // 
            this.tbProbabilidadesDe7.Location = new System.Drawing.Point(39, 207);
            this.tbProbabilidadesDe7.Name = "tbProbabilidadesDe7";
            this.tbProbabilidadesDe7.Size = new System.Drawing.Size(288, 20);
            this.tbProbabilidadesDe7.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Probabilidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Probabilidad de Suma de 7";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbProbabilidadesDe7);
            this.Controls.Add(this.tbProbabilidades);
            this.Controls.Add(this.dgvTablaResultados);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.DataGridView dgvTablaResultados;
        private System.Windows.Forms.TextBox tbProbabilidades;
        private System.Windows.Forms.TextBox tbProbabilidadesDe7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

