namespace MiPrimerForm.Formularios
{
    partial class FrmProducto
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
            this.TabGrid = new System.Windows.Forms.TabPage();
            this.TabGeneral = new System.Windows.Forms.TabPage();
            this.TabRegistros = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.TabGeneral.SuspendLayout();
            this.TabRegistros.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGrid
            // 
            this.TabGrid.Location = new System.Drawing.Point(4, 22);
            this.TabGrid.Name = "TabGrid";
            this.TabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.TabGrid.Size = new System.Drawing.Size(704, 349);
            this.TabGrid.TabIndex = 1;
            this.TabGrid.Text = "Registros Guardados";
            this.TabGrid.UseVisualStyleBackColor = true;
            this.TabGrid.Click += new System.EventHandler(this.TabGrid_Click);
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.checkBox1);
            this.TabGeneral.Controls.Add(this.textBox3);
            this.TabGeneral.Controls.Add(this.textBox2);
            this.TabGeneral.Controls.Add(this.textBox1);
            this.TabGeneral.Controls.Add(this.label3);
            this.TabGeneral.Controls.Add(this.label2);
            this.TabGeneral.Controls.Add(this.label1);
            this.TabGeneral.Location = new System.Drawing.Point(4, 22);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TabGeneral.Size = new System.Drawing.Size(704, 349);
            this.TabGeneral.TabIndex = 0;
            this.TabGeneral.Text = "Datos del Producto";
            this.TabGeneral.UseVisualStyleBackColor = true;
            this.TabGeneral.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // TabRegistros
            // 
            this.TabRegistros.Controls.Add(this.TabGeneral);
            this.TabRegistros.Controls.Add(this.TabGrid);
            this.TabRegistros.Location = new System.Drawing.Point(41, 40);
            this.TabRegistros.Name = "TabRegistros";
            this.TabRegistros.SelectedIndex = 0;
            this.TabRegistros.Size = new System.Drawing.Size(712, 375);
            this.TabRegistros.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 73);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(101, 183);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabRegistros);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.TabGeneral.ResumeLayout(false);
            this.TabGeneral.PerformLayout();
            this.TabRegistros.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabGrid;
        private System.Windows.Forms.TabPage TabGeneral;
        private System.Windows.Forms.TabControl TabRegistros;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}