namespace EjerciciosPractica.Formularios
{
    partial class FormNombre
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombresNormales = new System.Windows.Forms.ListBox();
            this.lbNombresJ = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa Nombres para separar aquellos que inician por \"J\":";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbNombresNormales
            // 
            this.lbNombresNormales.FormattingEnabled = true;
            this.lbNombresNormales.Location = new System.Drawing.Point(52, 210);
            this.lbNombresNormales.Name = "lbNombresNormales";
            this.lbNombresNormales.Size = new System.Drawing.Size(210, 329);
            this.lbNombresNormales.TabIndex = 2;
            // 
            // lbNombresJ
            // 
            this.lbNombresJ.FormattingEnabled = true;
            this.lbNombresJ.Location = new System.Drawing.Point(306, 210);
            this.lbNombresJ.Name = "lbNombresJ";
            this.lbNombresJ.Size = new System.Drawing.Size(210, 329);
            this.lbNombresJ.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No inician por \"J\":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inician por \"J\":";
            // 
            // FormNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 564);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbNombresJ);
            this.Controls.Add(this.lbNombresNormales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormNombre";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbNombresNormales;
        private System.Windows.Forms.ListBox lbNombresJ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}