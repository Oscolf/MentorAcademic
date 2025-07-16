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
            tbx_contraseña = new System.Windows.Forms.TextBox();
            tbx_nombre = new System.Windows.Forms.TextBox();
            tbx_apellidos = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lbl_nombre = new System.Windows.Forms.Label();
            lbl_apellidos = new System.Windows.Forms.Label();
            lbl_password = new System.Windows.Forms.Label();
            lbl_correo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            btn_back.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_back.Location = new System.Drawing.Point(12, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new System.Drawing.Size(163, 52);
            btn_back.TabIndex = 0;
            btn_back.Text = "Regresar";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // btn_signUp
            // 
            btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            btn_signUp.Enabled = false;
            btn_signUp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            btn_signUp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            btn_signUp.Location = new System.Drawing.Point(285, 378);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.Size = new System.Drawing.Size(217, 68);
            btn_signUp.TabIndex = 1;
            btn_signUp.Text = "Registrar";
            btn_signUp.UseVisualStyleBackColor = false;
            btn_signUp.Click += btn_signUp_Click;
            // 
            // tbx_correo
            // 
            tbx_correo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            tbx_correo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            tbx_correo.Location = new System.Drawing.Point(430, 306);
            tbx_correo.Name = "tbx_correo";
            tbx_correo.Size = new System.Drawing.Size(271, 31);
            tbx_correo.TabIndex = 2;
            tbx_correo.TextChanged += tbx_TextChanged;
            // 
            // tbx_contraseña
            // 
            tbx_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            tbx_contraseña.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            tbx_contraseña.Location = new System.Drawing.Point(83, 306);
            tbx_contraseña.Name = "tbx_contraseña";
            tbx_contraseña.Size = new System.Drawing.Size(271, 31);
            tbx_contraseña.TabIndex = 3;
            tbx_contraseña.UseSystemPasswordChar = true;
            tbx_contraseña.TextChanged += tbx_TextChanged;
            // 
            // tbx_nombre
            // 
            tbx_nombre.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            tbx_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            tbx_nombre.Location = new System.Drawing.Point(83, 214);
            tbx_nombre.Name = "tbx_nombre";
            tbx_nombre.Size = new System.Drawing.Size(271, 31);
            tbx_nombre.TabIndex = 4;
            tbx_nombre.TextChanged += tbx_TextChanged;
            // 
            // tbx_apellidos
            // 
            tbx_apellidos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
            tbx_apellidos.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            tbx_apellidos.Location = new System.Drawing.Point(430, 214);
            tbx_apellidos.Name = "tbx_apellidos";
            tbx_apellidos.Size = new System.Drawing.Size(271, 31);
            tbx_apellidos.TabIndex = 5;
            tbx_apellidos.TextChanged += tbx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            label1.Location = new System.Drawing.Point(181, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(412, 74);
            label1.TabIndex = 6;
            label1.Text = "Crea tu cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            label2.Location = new System.Drawing.Point(262, 139);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(289, 30);
            label2.TabIndex = 7;
            label2.Text = "Ingresa tus datos de registro";
            // 
            // lbl_nombre
            // 
            lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbl_nombre.Location = new System.Drawing.Point(83, 185);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new System.Drawing.Size(149, 26);
            lbl_nombre.TabIndex = 8;
            lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellidos
            // 
            lbl_apellidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbl_apellidos.Location = new System.Drawing.Point(430, 185);
            lbl_apellidos.Name = "lbl_apellidos";
            lbl_apellidos.Size = new System.Drawing.Size(136, 26);
            lbl_apellidos.TabIndex = 9;
            lbl_apellidos.Text = "Apellidos";
            // 
            // lbl_password
            // 
            lbl_password.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbl_password.Location = new System.Drawing.Point(83, 278);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new System.Drawing.Size(180, 25);
            lbl_password.TabIndex = 10;
            lbl_password.Text = "Contraseña";
            // 
            // lbl_correo
            // 
            lbl_correo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            lbl_correo.Location = new System.Drawing.Point(433, 275);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new System.Drawing.Size(160, 28);
            lbl_correo.TabIndex = 11;
            lbl_correo.Text = "Correo";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
            ClientSize = new System.Drawing.Size(831, 550);
            Controls.Add(lbl_correo);
            Controls.Add(lbl_password);
            Controls.Add(lbl_apellidos);
            Controls.Add(lbl_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbx_apellidos);
            Controls.Add(tbx_nombre);
            Controls.Add(tbx_contraseña);
            Controls.Add(tbx_correo);
            Controls.Add(btn_signUp);
            Controls.Add(btn_back);
            ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_correo;

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_apellidos;

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.TextBox tbx_correo;
        private System.Windows.Forms.TextBox tbx_contraseña;
        private System.Windows.Forms.TextBox tbx_nombre;
        private System.Windows.Forms.TextBox tbx_apellidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
