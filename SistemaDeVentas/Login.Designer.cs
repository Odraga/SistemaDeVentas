
namespace SistemaDeVentas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.pictureBoxEnviar = new System.Windows.Forms.PictureBox();
            this.pictureBoxUsuario = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnviar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsuario.Location = new System.Drawing.Point(64, 239);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(84, 24);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuario :";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.BackColor = System.Drawing.Color.Transparent;
            this.labelContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelContrasena.Location = new System.Drawing.Point(64, 294);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(116, 24);
            this.labelContrasena.TabIndex = 4;
            this.labelContrasena.Text = "Contraseña :";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Location = new System.Drawing.Point(68, 267);
            this.textBoxUsuario.MaxLength = 12;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(164, 20);
            this.textBoxUsuario.TabIndex = 5;
            this.textBoxUsuario.Tag = "";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContrasena.Location = new System.Drawing.Point(68, 321);
            this.textBoxContrasena.MaxLength = 60;
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(164, 20);
            this.textBoxContrasena.TabIndex = 6;
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCopyright.Location = new System.Drawing.Point(56, 428);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(199, 13);
            this.labelCopyright.TabIndex = 8;
            this.labelCopyright.Text = "® 2021 - Todos los derechos reservados";
            // 
            // pictureBoxEnviar
            // 
            this.pictureBoxEnviar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEnviar.Image = global::SistemaDeVentas.Properties.Resources.sending;
            this.pictureBoxEnviar.Location = new System.Drawing.Point(125, 369);
            this.pictureBoxEnviar.Name = "pictureBoxEnviar";
            this.pictureBoxEnviar.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnviar.TabIndex = 7;
            this.pictureBoxEnviar.TabStop = false;
            this.pictureBoxEnviar.Click += new System.EventHandler(this.pictureBoxEnviar_Click);
            // 
            // pictureBoxUsuario
            // 
            this.pictureBoxUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUsuario.Image = global::SistemaDeVentas.Properties.Resources.user;
            this.pictureBoxUsuario.Location = new System.Drawing.Point(68, 60);
            this.pictureBoxUsuario.Name = "pictureBoxUsuario";
            this.pictureBoxUsuario.Size = new System.Drawing.Size(164, 166);
            this.pictureBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUsuario.TabIndex = 2;
            this.pictureBoxUsuario.TabStop = false;
            // 
            // pictureBoxMinimizar
            // 
            this.pictureBoxMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimizar.Image = global::SistemaDeVentas.Properties.Resources.vector;
            this.pictureBoxMinimizar.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMinimizar.Name = "pictureBoxMinimizar";
            this.pictureBoxMinimizar.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimizar.TabIndex = 1;
            this.pictureBoxMinimizar.TabStop = false;
            this.pictureBoxMinimizar.Click += new System.EventHandler(this.pictureBoxMinimizar_Click);
            // 
            // pictureBoxCerrar
            // 
            this.pictureBoxCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCerrar.Image = global::SistemaDeVentas.Properties.Resources.close;
            this.pictureBoxCerrar.Location = new System.Drawing.Point(238, 12);
            this.pictureBoxCerrar.Name = "pictureBoxCerrar";
            this.pictureBoxCerrar.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCerrar.TabIndex = 0;
            this.pictureBoxCerrar.TabStop = false;
            this.pictureBoxCerrar.Click += new System.EventHandler(this.pictureBoxCerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.pictureBoxEnviar);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelContrasena);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.pictureBoxUsuario);
            this.Controls.Add(this.pictureBoxMinimizar);
            this.Controls.Add(this.pictureBoxCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnviar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCerrar;
        private System.Windows.Forms.PictureBox pictureBoxMinimizar;
        private System.Windows.Forms.PictureBox pictureBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.PictureBox pictureBoxEnviar;
        private System.Windows.Forms.Label labelCopyright;
    }
}

