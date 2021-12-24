
namespace SistemaDeVentas
{
    partial class SistemaDeVentas
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
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.groupBoxPermisos = new System.Windows.Forms.GroupBox();
            this.radioButtonAdministrador = new System.Windows.Forms.RadioButton();
            this.radioButtonUsuario = new System.Windows.Forms.RadioButton();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.labelConContrasena = new System.Windows.Forms.Label();
            this.textBoxConContrasena = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.groupBoxPermisos.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.AllowUserToAddRows = false;
            this.dataGridViewDB.AllowUserToDeleteRows = false;
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Location = new System.Drawing.Point(1, 332);
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.ReadOnly = true;
            this.dataGridViewDB.Size = new System.Drawing.Size(494, 187);
            this.dataGridViewDB.TabIndex = 0;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelUsuario.Location = new System.Drawing.Point(3, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(84, 24);
            this.labelUsuario.TabIndex = 4;
            this.labelUsuario.Text = "Usuario :";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombre.Location = new System.Drawing.Point(3, 150);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(89, 24);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.BackColor = System.Drawing.Color.Transparent;
            this.labelContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelContrasena.Location = new System.Drawing.Point(3, 50);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(116, 24);
            this.labelContrasena.TabIndex = 6;
            this.labelContrasena.Text = "Contraseña :";
            // 
            // groupBoxPermisos
            // 
            this.groupBoxPermisos.Controls.Add(this.radioButtonAdministrador);
            this.groupBoxPermisos.Controls.Add(this.radioButtonUsuario);
            this.groupBoxPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBoxPermisos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxPermisos.Location = new System.Drawing.Point(12, 226);
            this.groupBoxPermisos.Name = "groupBoxPermisos";
            this.groupBoxPermisos.Size = new System.Drawing.Size(182, 100);
            this.groupBoxPermisos.TabIndex = 7;
            this.groupBoxPermisos.TabStop = false;
            this.groupBoxPermisos.Text = "Permisos de";
            // 
            // radioButtonAdministrador
            // 
            this.radioButtonAdministrador.AutoSize = true;
            this.radioButtonAdministrador.Location = new System.Drawing.Point(6, 65);
            this.radioButtonAdministrador.Name = "radioButtonAdministrador";
            this.radioButtonAdministrador.Size = new System.Drawing.Size(144, 28);
            this.radioButtonAdministrador.TabIndex = 1;
            this.radioButtonAdministrador.TabStop = true;
            this.radioButtonAdministrador.Text = "Administrador";
            this.radioButtonAdministrador.UseVisualStyleBackColor = true;
            // 
            // radioButtonUsuario
            // 
            this.radioButtonUsuario.AutoSize = true;
            this.radioButtonUsuario.Location = new System.Drawing.Point(7, 31);
            this.radioButtonUsuario.Name = "radioButtonUsuario";
            this.radioButtonUsuario.Size = new System.Drawing.Size(92, 28);
            this.radioButtonUsuario.TabIndex = 0;
            this.radioButtonUsuario.TabStop = true;
            this.radioButtonUsuario.Text = "Usuario";
            this.radioButtonUsuario.UseVisualStyleBackColor = true;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Location = new System.Drawing.Point(3, 27);
            this.textBoxUsuario.MaxLength = 12;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(164, 20);
            this.textBoxUsuario.TabIndex = 6;
            this.textBoxUsuario.Tag = "";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Location = new System.Drawing.Point(3, 177);
            this.textBoxNombre.MaxLength = 12;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(164, 20);
            this.textBoxNombre.TabIndex = 8;
            this.textBoxNombre.Tag = "";
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContrasena.Location = new System.Drawing.Point(3, 77);
            this.textBoxContrasena.MaxLength = 12;
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(164, 20);
            this.textBoxContrasena.TabIndex = 9;
            this.textBoxContrasena.Tag = "";
            // 
            // labelConContrasena
            // 
            this.labelConContrasena.AutoSize = true;
            this.labelConContrasena.BackColor = System.Drawing.Color.Transparent;
            this.labelConContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConContrasena.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelConContrasena.Location = new System.Drawing.Point(3, 100);
            this.labelConContrasena.Name = "labelConContrasena";
            this.labelConContrasena.Size = new System.Drawing.Size(116, 24);
            this.labelConContrasena.TabIndex = 11;
            this.labelConContrasena.Text = "Contraseña :";
            // 
            // textBoxConContrasena
            // 
            this.textBoxConContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConContrasena.Location = new System.Drawing.Point(3, 127);
            this.textBoxConContrasena.MaxLength = 12;
            this.textBoxConContrasena.Name = "textBoxConContrasena";
            this.textBoxConContrasena.PasswordChar = '*';
            this.textBoxConContrasena.Size = new System.Drawing.Size(164, 20);
            this.textBoxConContrasena.TabIndex = 12;
            this.textBoxConContrasena.Tag = "";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelUsuario);
            this.flowLayoutPanel1.Controls.Add(this.textBoxUsuario);
            this.flowLayoutPanel1.Controls.Add(this.labelContrasena);
            this.flowLayoutPanel1.Controls.Add(this.textBoxContrasena);
            this.flowLayoutPanel1.Controls.Add(this.labelConContrasena);
            this.flowLayoutPanel1.Controls.Add(this.textBoxConContrasena);
            this.flowLayoutPanel1.Controls.Add(this.labelNombre);
            this.flowLayoutPanel1.Controls.Add(this.textBoxNombre);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 208);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAdd.Image = global::SistemaDeVentas.Properties.Resources.plus;
            this.pictureBoxAdd.Location = new System.Drawing.Point(15, 44);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdd.TabIndex = 0;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // pictureBoxRefresh
            // 
            this.pictureBoxRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRefresh.Image = global::SistemaDeVentas.Properties.Resources.refresh;
            this.pictureBoxRefresh.Location = new System.Drawing.Point(15, 141);
            this.pictureBoxRefresh.Name = "pictureBoxRefresh";
            this.pictureBoxRefresh.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefresh.TabIndex = 1;
            this.pictureBoxRefresh.TabStop = false;
            this.pictureBoxRefresh.Click += new System.EventHandler(this.pictureBoxRefresh_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExit.Image = global::SistemaDeVentas.Properties.Resources.cerrar_sesion;
            this.pictureBoxExit.Location = new System.Drawing.Point(15, 240);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 2;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.pictureBoxExit);
            this.panel1.Controls.Add(this.pictureBoxRefresh);
            this.panel1.Controls.Add(this.pictureBoxAdd);
            this.panel1.Location = new System.Drawing.Point(367, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 336);
            this.panel1.TabIndex = 10;
            // 
            // SistemaDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(496, 520);
            this.Controls.Add(this.groupBoxPermisos);
            this.Controls.Add(this.dataGridViewDB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(496, 520);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(496, 520);
            this.Name = "SistemaDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SistemaDeVentas";
            this.Load += new System.EventHandler(this.SistemaDeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.groupBoxPermisos.ResumeLayout(false);
            this.groupBoxPermisos.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDB;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.GroupBox groupBoxPermisos;
        private System.Windows.Forms.RadioButton radioButtonAdministrador;
        private System.Windows.Forms.RadioButton radioButtonUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Label labelConContrasena;
        private System.Windows.Forms.TextBox textBoxConContrasena;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.PictureBox pictureBoxRefresh;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panel1;
    }
}