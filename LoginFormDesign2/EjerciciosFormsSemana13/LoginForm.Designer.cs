namespace EjerciciosFormsSemana13
{
    partial class LoginForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbUser = new MetroFramework.Controls.MetroTextBox();
            this.tbPass = new MetroFramework.Controls.MetroTextBox();
            this.btnIniciar = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(72, 129);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuario:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(72, 208);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // tbUser
            // 
            // 
            // 
            // 
            this.tbUser.CustomButton.Image = null;
            this.tbUser.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tbUser.CustomButton.Name = "";
            this.tbUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUser.CustomButton.TabIndex = 1;
            this.tbUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUser.CustomButton.UseSelectable = true;
            this.tbUser.CustomButton.Visible = false;
            this.tbUser.Lines = new string[0];
            this.tbUser.Location = new System.Drawing.Point(194, 125);
            this.tbUser.MaxLength = 32767;
            this.tbUser.Name = "tbUser";
            this.tbUser.PasswordChar = '\0';
            this.tbUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUser.SelectedText = "";
            this.tbUser.SelectionLength = 0;
            this.tbUser.SelectionStart = 0;
            this.tbUser.ShortcutsEnabled = true;
            this.tbUser.Size = new System.Drawing.Size(194, 23);
            this.tbUser.TabIndex = 2;
            this.tbUser.UseSelectable = true;
            this.tbUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPass
            // 
            // 
            // 
            // 
            this.tbPass.CustomButton.Image = null;
            this.tbPass.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.tbPass.CustomButton.Name = "";
            this.tbPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPass.CustomButton.TabIndex = 1;
            this.tbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPass.CustomButton.UseSelectable = true;
            this.tbPass.CustomButton.Visible = false;
            this.tbPass.Lines = new string[0];
            this.tbPass.Location = new System.Drawing.Point(194, 204);
            this.tbPass.MaxLength = 32767;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPass.SelectedText = "";
            this.tbPass.SelectionLength = 0;
            this.tbPass.SelectionStart = 0;
            this.tbPass.ShortcutsEnabled = true;
            this.tbPass.Size = new System.Drawing.Size(194, 23);
            this.tbPass.TabIndex = 3;
            this.tbPass.UseSelectable = true;
            this.tbPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnIniciar
            // 
            this.btnIniciar.ActiveControl = null;
            this.btnIniciar.Location = new System.Drawing.Point(72, 283);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(316, 55);
            this.btnIniciar.TabIndex = 4;
            this.btnIniciar.Text = "Iniciar Sesión";
            this.btnIniciar.UseSelectable = true;
            this.btnIniciar.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 425);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "LoginForm";
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbUser;
        private MetroFramework.Controls.MetroTextBox tbPass;
        private MetroFramework.Controls.MetroTile btnIniciar;
    }
}

