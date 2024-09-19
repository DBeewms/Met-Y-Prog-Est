
namespace Ejercicio2
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
            this.tbAsientoVuelo = new System.Windows.Forms.TextBox();
            this.cmbSeccionAvion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReservarAsiento = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAsientoVuelo
            // 
            this.tbAsientoVuelo.Location = new System.Drawing.Point(289, 78);
            this.tbAsientoVuelo.Name = "tbAsientoVuelo";
            this.tbAsientoVuelo.Size = new System.Drawing.Size(100, 20);
            this.tbAsientoVuelo.TabIndex = 0;
            // 
            // cmbSeccionAvion
            // 
            this.cmbSeccionAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeccionAvion.FormattingEnabled = true;
            this.cmbSeccionAvion.Items.AddRange(new object[] {
            "Fumadores",
            "No Fumadores"});
            this.cmbSeccionAvion.Location = new System.Drawing.Point(289, 134);
            this.cmbSeccionAvion.Name = "cmbSeccionAvion";
            this.cmbSeccionAvion.Size = new System.Drawing.Size(121, 21);
            this.cmbSeccionAvion.TabIndex = 1;
            this.cmbSeccionAvion.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Asiento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seccion del Avión:";
            // 
            // btnReservarAsiento
            // 
            this.btnReservarAsiento.Location = new System.Drawing.Point(289, 194);
            this.btnReservarAsiento.Name = "btnReservarAsiento";
            this.btnReservarAsiento.Size = new System.Drawing.Size(121, 49);
            this.btnReservarAsiento.TabIndex = 4;
            this.btnReservarAsiento.Text = "Reservar";
            this.btnReservarAsiento.UseVisualStyleBackColor = true;
            this.btnReservarAsiento.Click += new System.EventHandler(this.btnReservarAsiento_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reservar Asiento de Vuelo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReservarAsiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSeccionAvion);
            this.Controls.Add(this.tbAsientoVuelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAsientoVuelo;
        private System.Windows.Forms.ComboBox cmbSeccionAvion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReservarAsiento;
        private System.Windows.Forms.Label label3;
    }
}

