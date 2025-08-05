using System.ComponentModel;

namespace WinFormsMentorAcademic;

partial class StartMenu
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        lbl_Novedades = new System.Windows.Forms.Label();
        grBx_RedesSociales = new System.Windows.Forms.GroupBox();
        btn_twitter = new System.Windows.Forms.Button();
        btn_youtube = new System.Windows.Forms.Button();
        btn_instagram = new System.Windows.Forms.Button();
        btn_facebook = new System.Windows.Forms.Button();
        vScBr_redesSociales = new System.Windows.Forms.VScrollBar();
        btn_login = new System.Windows.Forms.Button();
        gBx_noticiasComunicados = new System.Windows.Forms.GroupBox();
        tbCtrl_noticiasOcomunicados = new System.Windows.Forms.TabControl();
        tbPg_noticias = new System.Windows.Forms.TabPage();
        tbPg_comunicados = new System.Windows.Forms.TabPage();
        btn_signup = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        grBx_RedesSociales.SuspendLayout();
        gBx_noticiasComunicados.SuspendLayout();
        tbCtrl_noticiasOcomunicados.SuspendLayout();
        SuspendLayout();
        // 
        // lbl_Novedades
        // 
        lbl_Novedades.AutoSize = true;
        lbl_Novedades.BackColor = System.Drawing.Color.Transparent;
        lbl_Novedades.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_Novedades.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_Novedades.Location = new System.Drawing.Point(25, 28);
        lbl_Novedades.Name = "lbl_Novedades";
        lbl_Novedades.Size = new System.Drawing.Size(640, 96);
        lbl_Novedades.TabIndex = 0;
        lbl_Novedades.Text = "MentorAcademic";
        // 
        // grBx_RedesSociales
        // 
        grBx_RedesSociales.Controls.Add(btn_twitter);
        grBx_RedesSociales.Controls.Add(btn_youtube);
        grBx_RedesSociales.Controls.Add(btn_instagram);
        grBx_RedesSociales.Controls.Add(btn_facebook);
        grBx_RedesSociales.Controls.Add(vScBr_redesSociales);
        grBx_RedesSociales.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grBx_RedesSociales.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        grBx_RedesSociales.Location = new System.Drawing.Point(35, 187);
        grBx_RedesSociales.Name = "grBx_RedesSociales";
        grBx_RedesSociales.Size = new System.Drawing.Size(532, 563);
        grBx_RedesSociales.TabIndex = 1;
        grBx_RedesSociales.TabStop = false;
        grBx_RedesSociales.Text = "Redes Sociales";
        // 
        // btn_twitter
        // 
        btn_twitter.BackColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        btn_twitter.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_twitter.Location = new System.Drawing.Point(25, 760);
        btn_twitter.Name = "btn_twitter";
        btn_twitter.Size = new System.Drawing.Size(444, 225);
        btn_twitter.TabIndex = 4;
        btn_twitter.Text = "X";
        btn_twitter.UseVisualStyleBackColor = false;
        // 
        // btn_youtube
        // 
        btn_youtube.BackColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        btn_youtube.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_youtube.Location = new System.Drawing.Point(25, 520);
        btn_youtube.Name = "btn_youtube";
        btn_youtube.Size = new System.Drawing.Size(444, 225);
        btn_youtube.TabIndex = 3;
        btn_youtube.Text = "YouTube";
        btn_youtube.UseVisualStyleBackColor = false;
        // 
        // btn_instagram
        // 
        btn_instagram.BackColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        btn_instagram.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_instagram.Location = new System.Drawing.Point(25, 280);
        btn_instagram.Name = "btn_instagram";
        btn_instagram.Size = new System.Drawing.Size(444, 225);
        btn_instagram.TabIndex = 2;
        btn_instagram.Text = "Instagram";
        btn_instagram.UseVisualStyleBackColor = false;
        // 
        // btn_facebook
        // 
        btn_facebook.BackColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        btn_facebook.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_facebook.Location = new System.Drawing.Point(25, 40);
        btn_facebook.Name = "btn_facebook";
        btn_facebook.Size = new System.Drawing.Size(444, 225);
        btn_facebook.TabIndex = 1;
        btn_facebook.Text = "Facebook";
        btn_facebook.UseVisualStyleBackColor = false;
        btn_facebook.Click += btn_facebook_Click;
        // 
        // vScBr_redesSociales
        // 
        vScBr_redesSociales.Cursor = System.Windows.Forms.Cursors.Hand;
        vScBr_redesSociales.Dock = System.Windows.Forms.DockStyle.Right;
        vScBr_redesSociales.Location = new System.Drawing.Point(502, 46);
        vScBr_redesSociales.Name = "vScBr_redesSociales";
        vScBr_redesSociales.Size = new System.Drawing.Size(27, 514);
        vScBr_redesSociales.TabIndex = 0;
        vScBr_redesSociales.Scroll += vScrollBar1_Scroll;
        // 
        // btn_login
        // 
        btn_login.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        btn_login.Location = new System.Drawing.Point(949, 28);
        btn_login.Name = "btn_login";
        btn_login.Size = new System.Drawing.Size(261, 54);
        btn_login.TabIndex = 2;
        btn_login.Text = "Iniciar Sesión";
        btn_login.UseVisualStyleBackColor = false;
        btn_login.Click += btn_login_Click;
        // 
        // gBx_noticiasComunicados
        // 
        gBx_noticiasComunicados.Controls.Add(tbCtrl_noticiasOcomunicados);
        gBx_noticiasComunicados.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        gBx_noticiasComunicados.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        gBx_noticiasComunicados.Location = new System.Drawing.Point(626, 187);
        gBx_noticiasComunicados.Name = "gBx_noticiasComunicados";
        gBx_noticiasComunicados.Size = new System.Drawing.Size(587, 563);
        gBx_noticiasComunicados.TabIndex = 4;
        gBx_noticiasComunicados.TabStop = false;
        gBx_noticiasComunicados.Text = "Noticias y Comunicados";
        // 
        // tbCtrl_noticiasOcomunicados
        // 
        tbCtrl_noticiasOcomunicados.Controls.Add(tbPg_noticias);
        tbCtrl_noticiasOcomunicados.Controls.Add(tbPg_comunicados);
        tbCtrl_noticiasOcomunicados.Dock = System.Windows.Forms.DockStyle.Fill;
        tbCtrl_noticiasOcomunicados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tbCtrl_noticiasOcomunicados.Location = new System.Drawing.Point(3, 46);
        tbCtrl_noticiasOcomunicados.Name = "tbCtrl_noticiasOcomunicados";
        tbCtrl_noticiasOcomunicados.SelectedIndex = 0;
        tbCtrl_noticiasOcomunicados.Size = new System.Drawing.Size(581, 514);
        tbCtrl_noticiasOcomunicados.TabIndex = 0;
        // 
        // tbPg_noticias
        // 
        tbPg_noticias.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        tbPg_noticias.Location = new System.Drawing.Point(4, 41);
        tbPg_noticias.Name = "tbPg_noticias";
        tbPg_noticias.Padding = new System.Windows.Forms.Padding(3);
        tbPg_noticias.Size = new System.Drawing.Size(573, 469);
        tbPg_noticias.TabIndex = 0;
        tbPg_noticias.Text = "Noticias";
        // 
        // tbPg_comunicados
        // 
        tbPg_comunicados.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        tbPg_comunicados.Location = new System.Drawing.Point(4, 41);
        tbPg_comunicados.Name = "tbPg_comunicados";
        tbPg_comunicados.Padding = new System.Windows.Forms.Padding(3);
        tbPg_comunicados.Size = new System.Drawing.Size(573, 469);
        tbPg_comunicados.TabIndex = 1;
        tbPg_comunicados.Text = "Comunicados";
        // 
        // btn_signup
        // 
        btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_signup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_signup.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        btn_signup.Location = new System.Drawing.Point(952, 118);
        btn_signup.Name = "btn_signup";
        btn_signup.Size = new System.Drawing.Size(261, 54);
        btn_signup.TabIndex = 5;
        btn_signup.Text = "Registrarse";
        btn_signup.UseVisualStyleBackColor = false;
        btn_signup.Click += btn_signup_Click;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.Transparent;
        label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        label1.Location = new System.Drawing.Point(1016, 85);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(136, 30);
        label1.TabIndex = 6;
        label1.Text = "¿Eres nuev@?";
        // 
        // StartMenu
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        ClientSize = new System.Drawing.Size(1256, 771);
        Controls.Add(label1);
        Controls.Add(btn_signup);
        Controls.Add(grBx_RedesSociales);
        Controls.Add(gBx_noticiasComunicados);
        Controls.Add(btn_login);
        Controls.Add(lbl_Novedades);
        Text = "Bienvenida";
        grBx_RedesSociales.ResumeLayout(false);
        gBx_noticiasComunicados.ResumeLayout(false);
        tbCtrl_noticiasOcomunicados.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btn_signup;

    private System.Windows.Forms.GroupBox gBx_noticiasComunicados;
    private System.Windows.Forms.TabControl tbCtrl_noticiasOcomunicados;
    private System.Windows.Forms.TabPage tbPg_noticias;
    private System.Windows.Forms.TabPage tbPg_comunicados;

    private System.Windows.Forms.Button btn_twitter;

    private System.Windows.Forms.Button btn_youtube;

    private System.Windows.Forms.Button btn_instagram;

    private System.Windows.Forms.Button btn_facebook;

    private System.Windows.Forms.Button btn_login;

    private System.Windows.Forms.VScrollBar vScBr_redesSociales;

    private System.Windows.Forms.GroupBox grBx_RedesSociales;

    private System.Windows.Forms.Label lbl_Novedades;

    #endregion
}