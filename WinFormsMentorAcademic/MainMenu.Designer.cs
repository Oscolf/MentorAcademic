using System.ComponentModel;

namespace WinFormsMentorAcademic;

partial class MainMenu
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
        btn_signout = new System.Windows.Forms.Button();
        btn_asesorias = new System.Windows.Forms.Button();
        btn_clubes = new System.Windows.Forms.Button();
        lbl_usr = new System.Windows.Forms.Label();
        lbl_name = new System.Windows.Forms.Label();
        btn_history = new System.Windows.Forms.Button();
        grBx_main = new System.Windows.Forms.GroupBox();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        btn_culturales = new System.Windows.Forms.Button();
        btn_deportivos = new System.Windows.Forms.Button();
        lbl_welcome = new System.Windows.Forms.Label();
        gbx_userInfo = new System.Windows.Forms.GroupBox();
        grBx_main.SuspendLayout();
        gbx_userInfo.SuspendLayout();
        SuspendLayout();
        // 
        // btn_signout
        // 
        btn_signout.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_signout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_signout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_signout.Location = new System.Drawing.Point(202, 260);
        btn_signout.Name = "btn_signout";
        btn_signout.Size = new System.Drawing.Size(218, 78);
        btn_signout.TabIndex = 2;
        btn_signout.Text = "Cerrar sesión";
        btn_signout.UseVisualStyleBackColor = false;
        btn_signout.Click += btn_signout_Click;
        // 
        // btn_asesorias
        // 
        btn_asesorias.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_asesorias.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_asesorias.Location = new System.Drawing.Point(41, 176);
        btn_asesorias.Name = "btn_asesorias";
        btn_asesorias.Size = new System.Drawing.Size(550, 660);
        btn_asesorias.TabIndex = 3;
        btn_asesorias.Text = "\r\n\r\nAsesorías\r\n";
        btn_asesorias.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        btn_asesorias.UseVisualStyleBackColor = false;
        btn_asesorias.Click += btn_asesorias_Click;
        // 
        // btn_clubes
        // 
        btn_clubes.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_clubes.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_clubes.Location = new System.Drawing.Point(606, 176);
        btn_clubes.Name = "btn_clubes";
        btn_clubes.Size = new System.Drawing.Size(550, 660);
        btn_clubes.TabIndex = 4;
        btn_clubes.Text = "\r\n\r\nInscribirte a un club";
        btn_clubes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        btn_clubes.UseVisualStyleBackColor = false;
        btn_clubes.Click += btn_clubes_Click;
        // 
        // lbl_usr
        // 
        lbl_usr.Location = new System.Drawing.Point(11, 152);
        lbl_usr.Name = "lbl_usr";
        lbl_usr.Size = new System.Drawing.Size(353, 43);
        lbl_usr.TabIndex = 5;
        lbl_usr.Text = "Matrícula: ";
        // 
        // lbl_name
        // 
        lbl_name.Location = new System.Drawing.Point(11, 38);
        lbl_name.Name = "lbl_name";
        lbl_name.Size = new System.Drawing.Size(362, 103);
        lbl_name.TabIndex = 6;
        lbl_name.Text = "Nombre: ";
        // 
        // btn_history
        // 
        btn_history.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_history.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_history.Location = new System.Drawing.Point(6, 260);
        btn_history.Name = "btn_history";
        btn_history.Size = new System.Drawing.Size(190, 78);
        btn_history.TabIndex = 7;
        btn_history.Text = "Historial";
        btn_history.UseVisualStyleBackColor = false;
        // 
        // grBx_main
        // 
        grBx_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        grBx_main.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        grBx_main.Controls.Add(label2);
        grBx_main.Controls.Add(label1);
        grBx_main.Controls.Add(btn_culturales);
        grBx_main.Controls.Add(btn_deportivos);
        grBx_main.Controls.Add(lbl_welcome);
        grBx_main.Controls.Add(btn_clubes);
        grBx_main.Controls.Add(btn_asesorias);
        grBx_main.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grBx_main.Location = new System.Drawing.Point(26, 33);
        grBx_main.Name = "grBx_main";
        grBx_main.Size = new System.Drawing.Size(1201, 860);
        grBx_main.TabIndex = 8;
        grBx_main.TabStop = false;
        grBx_main.Text = "Inicio";
        // 
        // label2
        // 
        label2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        label2.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(726, 389);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(292, 152);
        label2.TabIndex = 9;
        label2.Text = "Infórmate y únete a alguna actividad cultural o deportiva";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label2.Click += btn_clubes_Click;
        // 
        // label1
        // 
        label1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        label1.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(160, 378);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(292, 152);
        label1.TabIndex = 8;
        label1.Text = "Pide y organiza una asesoría con algún profesor";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        label1.Click += btn_asesorias_Click;
        // 
        // btn_culturales
        // 
        btn_culturales.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_culturales.Enabled = false;
        btn_culturales.Location = new System.Drawing.Point(606, 209);
        btn_culturales.Name = "btn_culturales";
        btn_culturales.Size = new System.Drawing.Size(550, 570);
        btn_culturales.TabIndex = 7;
        btn_culturales.Text = "Culturales";
        btn_culturales.UseVisualStyleBackColor = false;
        btn_culturales.Visible = false;
        btn_culturales.Click += btn_culturales_Click;
        // 
        // btn_deportivos
        // 
        btn_deportivos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_deportivos.Enabled = false;
        btn_deportivos.Location = new System.Drawing.Point(41, 209);
        btn_deportivos.Name = "btn_deportivos";
        btn_deportivos.Size = new System.Drawing.Size(550, 567);
        btn_deportivos.TabIndex = 6;
        btn_deportivos.Text = "Deportivos";
        btn_deportivos.UseVisualStyleBackColor = false;
        btn_deportivos.Visible = false;
        btn_deportivos.Click += btn_deportivos_Click;
        // 
        // lbl_welcome
        // 
        lbl_welcome.AutoSize = true;
        lbl_welcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_welcome.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        lbl_welcome.Location = new System.Drawing.Point(202, 75);
        lbl_welcome.Name = "lbl_welcome";
        lbl_welcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        lbl_welcome.Size = new System.Drawing.Size(797, 54);
        lbl_welcome.TabIndex = 5;
        lbl_welcome.Text = "Bienvenid@ [usuario] Seleccione un servicio";
        lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // gbx_userInfo
        // 
        gbx_userInfo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        gbx_userInfo.Controls.Add(lbl_name);
        gbx_userInfo.Controls.Add(lbl_usr);
        gbx_userInfo.Controls.Add(btn_signout);
        gbx_userInfo.Controls.Add(btn_history);
        gbx_userInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbx_userInfo.Location = new System.Drawing.Point(1282, 33);
        gbx_userInfo.Name = "gbx_userInfo";
        gbx_userInfo.Size = new System.Drawing.Size(426, 344);
        gbx_userInfo.TabIndex = 9;
        gbx_userInfo.TabStop = false;
        gbx_userInfo.Text = "Información del Usuario";
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        CancelButton = btn_signout;
        ClientSize = new System.Drawing.Size(1740, 942);
        Controls.Add(gbx_userInfo);
        Controls.Add(grBx_main);
        Text = "Menú Principal";
        grBx_main.ResumeLayout(false);
        grBx_main.PerformLayout();
        gbx_userInfo.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.GroupBox gbx_userInfo;

    private System.Windows.Forms.Button btn_deportivos;
    private System.Windows.Forms.Button btn_culturales;

    private System.Windows.Forms.Label lbl_welcome;

    private System.Windows.Forms.GroupBox grBx_main;

    private System.Windows.Forms.Button btn_history;

    private System.Windows.Forms.Label lbl_usr;

    private System.Windows.Forms.Label lbl_name;

    private System.Windows.Forms.Button btn_asesorias;
    private System.Windows.Forms.Button btn_clubes;


    private System.Windows.Forms.Button btn_signout;

    #endregion
}