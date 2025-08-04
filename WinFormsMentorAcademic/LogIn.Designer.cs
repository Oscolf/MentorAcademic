namespace WinFormsMentorAcademic;

partial class LogIn
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
        lbl_email = new System.Windows.Forms.Label();
        lbl_password = new System.Windows.Forms.Label();
        tBx_correo = new System.Windows.Forms.TextBox();
        txB_password = new System.Windows.Forms.TextBox();
        btn_login = new System.Windows.Forms.Button();
        lbl_noAcc = new System.Windows.Forms.Label();
        lnkLbl_createAcc = new System.Windows.Forms.LinkLabel();
        btn_back = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        btn_verContrasena = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lbl_email
        // 
        lbl_email.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_email.Location = new System.Drawing.Point(265, 230);
        lbl_email.Name = "lbl_email";
        lbl_email.Size = new System.Drawing.Size(130, 35);
        lbl_email.TabIndex = 0;
        lbl_email.Text = "Correo: ";
        lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lbl_password
        // 
        lbl_password.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_password.Location = new System.Drawing.Point(230, 289);
        lbl_password.Name = "lbl_password";
        lbl_password.Size = new System.Drawing.Size(165, 38);
        lbl_password.TabIndex = 1;
        lbl_password.Text = "Contraseña:";
        lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // tBx_correo
        // 
        tBx_correo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        tBx_correo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tBx_correo.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        tBx_correo.Location = new System.Drawing.Point(401, 230);
        tBx_correo.Name = "tBx_correo";
        tBx_correo.Size = new System.Drawing.Size(273, 39);
        tBx_correo.TabIndex = 2;
        tBx_correo.Text = "ejemplo@email.com";
        tBx_correo.Click += txB_matricula_clicked;
        tBx_correo.TextChanged += txBx_TextChanged;
        // 
        // txB_password
        // 
        txB_password.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        txB_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txB_password.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        txB_password.Location = new System.Drawing.Point(401, 288);
        txB_password.Name = "txB_password";
        txB_password.Size = new System.Drawing.Size(273, 39);
        txB_password.TabIndex = 3;
        txB_password.UseSystemPasswordChar = true;
        txB_password.TextChanged += txBx_TextChanged;
        // 
        // btn_login
        // 
        btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btn_login.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        btn_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_login.Enabled = false;
        btn_login.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_login.Location = new System.Drawing.Point(419, 434);
        btn_login.Name = "btn_login";
        btn_login.Size = new System.Drawing.Size(218, 86);
        btn_login.TabIndex = 4;
        btn_login.Text = "Ingresar";
        btn_login.UseVisualStyleBackColor = false;
        btn_login.Click += btn_login_Click;
        // 
        // lbl_noAcc
        // 
        lbl_noAcc.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_noAcc.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_noAcc.Location = new System.Drawing.Point(364, 387);
        lbl_noAcc.Name = "lbl_noAcc";
        lbl_noAcc.Size = new System.Drawing.Size(196, 34);
        lbl_noAcc.TabIndex = 5;
        lbl_noAcc.Text = "¿No tienes una cuenta?";
        // 
        // lnkLbl_createAcc
        // 
        lnkLbl_createAcc.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)192)));
        lnkLbl_createAcc.Cursor = System.Windows.Forms.Cursors.Hand;
        lnkLbl_createAcc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lnkLbl_createAcc.LinkColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        lnkLbl_createAcc.Location = new System.Drawing.Point(550, 387);
        lnkLbl_createAcc.Name = "lnkLbl_createAcc";
        lnkLbl_createAcc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        lnkLbl_createAcc.Size = new System.Drawing.Size(124, 34);
        lnkLbl_createAcc.TabIndex = 6;
        lnkLbl_createAcc.TabStop = true;
        lnkLbl_createAcc.Text = "Crea una aquí";
        lnkLbl_createAcc.LinkClicked += lnkLbl_createAcc_LinkClicked;
        // 
        // btn_back
        // 
        btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btn_back.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        btn_back.Location = new System.Drawing.Point(12, 530);
        btn_back.Name = "btn_back";
        btn_back.Size = new System.Drawing.Size(151, 52);
        btn_back.TabIndex = 7;
        btn_back.Text = "Regresar";
        btn_back.UseVisualStyleBackColor = false;
        btn_back.Click += btn_back_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        label1.Location = new System.Drawing.Point(279, 78);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(472, 129);
        label1.TabIndex = 8;
        label1.Text = "Inicia sesión";
        // 
        // btn_verContrasena
        // 
        btn_verContrasena.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        btn_verContrasena.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        btn_verContrasena.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_verContrasena.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_verContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_verContrasena.Location = new System.Drawing.Point(691, 288);
        btn_verContrasena.Name = "btn_verContrasena";
        btn_verContrasena.Size = new System.Drawing.Size(122, 75);
        btn_verContrasena.TabIndex = 9;
        btn_verContrasena.Text = "Mostrar contraseña";
        btn_verContrasena.UseVisualStyleBackColor = false;
        btn_verContrasena.Click += btn_verContrasena_Click;
        // 
        // LogIn
        // 
        AcceptButton = btn_login;
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        CancelButton = btn_back;
        ClientSize = new System.Drawing.Size(1031, 602);
        Controls.Add(btn_verContrasena);
        Controls.Add(label1);
        Controls.Add(btn_back);
        Controls.Add(lnkLbl_createAcc);
        Controls.Add(lbl_noAcc);
        Controls.Add(btn_login);
        Controls.Add(txB_password);
        Controls.Add(tBx_correo);
        Controls.Add(lbl_password);
        Controls.Add(lbl_email);
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "Inicia sesión";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_verContrasena;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btn_back;

    private System.Windows.Forms.Label lbl_noAcc;
    private System.Windows.Forms.LinkLabel lnkLbl_createAcc;

    private System.Windows.Forms.Button btn_login;

    private System.Windows.Forms.Label lbl_email;
    private System.Windows.Forms.Label lbl_password;
    private System.Windows.Forms.TextBox tBx_correo;
    private System.Windows.Forms.TextBox txB_password;
    #endregion
}