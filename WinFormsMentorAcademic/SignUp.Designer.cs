namespace WinFormsMentorAcademic
{
    partial class SignUp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btn_back = new System.Windows.Forms.Button();
            btn_signUp = new System.Windows.Forms.Button();
            tbx_correo = new System.Windows.Forms.TextBox();
            tBx_password = new System.Windows.Forms.TextBox();
            tbx_nombre = new System.Windows.Forms.TextBox();
            tbx_apellidos = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbl_nombre = new System.Windows.Forms.Label();
            lbl_apellidos = new System.Windows.Forms.Label();
            lbl_password = new System.Windows.Forms.Label();
            lbl_correo = new System.Windows.Forms.Label();
            btn_verContrasena = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
            btn_back.Location = new System.Drawing.Point(12, 660);
            btn_back.Name = "btn_back";
            btn_back.Size = new System.Drawing.Size(147, 56);
            btn_back.TabIndex = 5;
            btn_back.Text = "Regresar";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_signUp
            // 
            btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            btn_signUp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_signUp.Enabled = false;
            btn_signUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btn_signUp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_signUp.Location = new System.Drawing.Point(424, 561);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new System.Drawing.Size(245, 103);
            btn_signUp.TabIndex = 4;
            btn_signUp.Text = "Registrar";
            btn_signUp.UseVisualStyleBackColor = false;
            btn_signUp.Click += btn_signUp_Click;
            // 
            // tbx_correo
            // 
            tbx_correo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            tbx_correo.Font = new System.Drawing.Font("Segoe UI", 14F);
            tbx_correo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
            tbx_correo.Location = new System.Drawing.Point(612, 445);
            tbx_correo.Name = "tbx_correo";
            tbx_correo.Size = new System.Drawing.Size(421, 45);
            tbx_correo.TabIndex = 3;
            tbx_correo.TextChanged += tbx_TextChanged;
            // 
            // tBx_password
            // 
            tBx_password.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            tBx_password.Font = new System.Drawing.Font("Segoe UI", 14F);
            tBx_password.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
            tBx_password.Location = new System.Drawing.Point(89, 445);
            tBx_password.Name = "tBx_password";
            tBx_password.Size = new System.Drawing.Size(421, 45);
            tBx_password.TabIndex = 2;
            tBx_password.UseSystemPasswordChar = true;
            tBx_password.TextChanged += tbx_TextChanged;
            // 
            // tbx_nombre
            // 
            tbx_nombre.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            tbx_nombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            tbx_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
            tbx_nombre.Location = new System.Drawing.Point(89, 318);
            tbx_nombre.Name = "tbx_nombre";
            tbx_nombre.Size = new System.Drawing.Size(421, 45);
            tbx_nombre.TabIndex = 0;
            tbx_nombre.TextChanged += tbx_TextChanged;
            // 
            // tbx_apellidos
            // 
            tbx_apellidos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            tbx_apellidos.Font = new System.Drawing.Font("Segoe UI", 14F);
            tbx_apellidos.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
            tbx_apellidos.Location = new System.Drawing.Point(612, 318);
            tbx_apellidos.Name = "tbx_apellidos";
            tbx_apellidos.Size = new System.Drawing.Size(421, 45);
            tbx_apellidos.TabIndex = 1;
            tbx_apellidos.TextChanged += tbx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            label1.Location = new System.Drawing.Point(293, 114);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(533, 96);
            label1.TabIndex = 6;
            label1.Text = "Crea tu cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            label2.Location = new System.Drawing.Point(388, 210);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(345, 38);
            label2.TabIndex = 7;
            label2.Text = "Ingresa tus datos de registro";
            // 
            // lbl_nombre
            // 
            lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbl_nombre.Location = new System.Drawing.Point(89, 277);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new System.Drawing.Size(149, 26);
            lbl_nombre.TabIndex = 8;
            lbl_nombre.Text = "Nombre/s";
            // 
            // lbl_apellidos
            // 
            lbl_apellidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lbl_apellidos.Location = new System.Drawing.Point(612, 277);
            lbl_apellidos.Name = "lbl_apellidos";
            lbl_apellidos.Size = new System.Drawing.Size(136, 26);
            lbl_apellidos.TabIndex = 9;
            lbl_apellidos.Text = "Apellidos";
            // 
            // lbl_password
            // 
            lbl_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lbl_password.Location = new System.Drawing.Point(89, 405);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new System.Drawing.Size(180, 25);
            lbl_password.TabIndex = 10;
            lbl_password.Text = "Contraseña";
            // 
            // lbl_correo
            // 
            lbl_correo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lbl_correo.Location = new System.Drawing.Point(612, 405);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new System.Drawing.Size(160, 28);
            lbl_correo.TabIndex = 11;
            lbl_correo.Text = "Correo";
            // 
            // btn_verContrasena
            // 
            btn_verContrasena.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            btn_verContrasena.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btn_verContrasena.Enabled = false;
            btn_verContrasena.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btn_verContrasena.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_verContrasena.Location = new System.Drawing.Point(333, 399);
            btn_verContrasena.Name = "btn_verContrasena";
            btn_verContrasena.Size = new System.Drawing.Size(177, 40);
            btn_verContrasena.TabIndex = 12;
            btn_verContrasena.Text = "Ver Contraseña";
            btn_verContrasena.UseVisualStyleBackColor = false;
            btn_verContrasena.Click += button1_Click;
            // 
            // SignUp
            // 
            AcceptButton = btn_signUp;
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
            CancelButton = btn_back;
            ClientSize = new System.Drawing.Size(1115, 728);
            Controls.Add(btn_verContrasena);
            Controls.Add(lbl_correo);
            Controls.Add(lbl_password);
            Controls.Add(lbl_apellidos);
            Controls.Add(lbl_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbx_apellidos);
            Controls.Add(tbx_nombre);
            Controls.Add(tBx_password);
            Controls.Add(tbx_correo);
            Controls.Add(btn_signUp);
            Controls.Add(btn_back);
            ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Text = "Registro de cuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btn_verContrasena;

        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_correo;

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellidos;

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.TextBox tbx_correo;
        private System.Windows.Forms.TextBox tBx_password;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.TextBox tbx_apellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
