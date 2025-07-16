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
        txB_matricula = new System.Windows.Forms.TextBox();
        txB_password = new System.Windows.Forms.TextBox();
        btn_login = new System.Windows.Forms.Button();
        lbl_noAcc = new System.Windows.Forms.Label();
        lnkLbl_createAcc = new System.Windows.Forms.LinkLabel();
        btn_back = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lbl_email
        // 
        lbl_email.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_email.Location = new System.Drawing.Point(232, 135);
        lbl_email.Name = "lbl_email";
        lbl_email.Size = new System.Drawing.Size(77, 35);
        lbl_email.TabIndex = 0;
        lbl_email.Text = "Correo: ";
        lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // lbl_password
        // 
        lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_password.Location = new System.Drawing.Point(193, 170);
        lbl_password.Name = "lbl_password";
        lbl_password.Size = new System.Drawing.Size(116, 38);
        lbl_password.TabIndex = 1;
        lbl_password.Text = "Contraseña:";
        lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txB_matricula
        // 
        txB_matricula.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        txB_matricula.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        txB_matricula.Location = new System.Drawing.Point(315, 139);
        txB_matricula.Name = "txB_matricula";
        txB_matricula.Size = new System.Drawing.Size(273, 31);
        txB_matricula.TabIndex = 2;
        txB_matricula.Text = "ejemplo@email.com";
        txB_matricula.Click += txB_matricula_clicked;
        txB_matricula.TextChanged += txBx_TextChanged;
        // 
        // txB_password
        // 
        txB_password.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        txB_password.Location = new System.Drawing.Point(315, 177);
        txB_password.Name = "txB_password";
        txB_password.Size = new System.Drawing.Size(273, 31);
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
        btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_login.Location = new System.Drawing.Point(259, 318);
        btn_login.Name = "btn_login";
        btn_login.Size = new System.Drawing.Size(273, 86);
        btn_login.TabIndex = 4;
        btn_login.Text = "Ingresar";
        btn_login.UseVisualStyleBackColor = false;
        btn_login.Click += btn_login_Click;
        // 
        // lbl_noAcc
        // 
        lbl_noAcc.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_noAcc.Location = new System.Drawing.Point(193, 231);
        lbl_noAcc.Name = "lbl_noAcc";
        lbl_noAcc.Size = new System.Drawing.Size(196, 34);
        lbl_noAcc.TabIndex = 5;
        lbl_noAcc.Text = "¿No tienes una cuenta?";
        // 
        // lnkLbl_createAcc
        // 
        lnkLbl_createAcc.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)((byte)255)), ((int)((byte)192)), ((int)((byte)192)));
        lnkLbl_createAcc.Cursor = System.Windows.Forms.Cursors.Hand;
        lnkLbl_createAcc.LinkColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        lnkLbl_createAcc.Location = new System.Drawing.Point(443, 231);
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
        btn_back.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        btn_back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_back.Location = new System.Drawing.Point(12, 386);
        btn_back.Name = "btn_back";
        btn_back.Size = new System.Drawing.Size(151, 52);
        btn_back.TabIndex = 7;
        btn_back.Text = "Regresar";
        btn_back.UseVisualStyleBackColor = false;
        btn_back.Click += btn_back_Click;
        // 
        // LogIn
        // 
        AcceptButton = btn_login;
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        CancelButton = btn_back;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(btn_back);
        Controls.Add(lnkLbl_createAcc);
        Controls.Add(lbl_noAcc);
        Controls.Add(btn_login);
        Controls.Add(txB_password);
        Controls.Add(txB_matricula);
        Controls.Add(lbl_password);
        Controls.Add(lbl_email);
        MaximizeBox = false;
        MinimizeBox = false;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_back;

    private System.Windows.Forms.Label lbl_noAcc;
    private System.Windows.Forms.LinkLabel lnkLbl_createAcc;

    private System.Windows.Forms.Button btn_login;

    private System.Windows.Forms.Label lbl_email;
    private System.Windows.Forms.Label lbl_password;
    private System.Windows.Forms.TextBox txB_matricula;
    private System.Windows.Forms.TextBox txB_password;
    #endregion
}