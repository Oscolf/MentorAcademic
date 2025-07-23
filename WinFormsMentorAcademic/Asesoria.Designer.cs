namespace WinFormsMentorAcademic;

partial class Asesoria
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
        btn_exit = new System.Windows.Forms.Button();
        lbl_user = new System.Windows.Forms.Label();
        lbl_fullname = new System.Windows.Forms.Label();
        cmBx_Course = new System.Windows.Forms.ComboBox();
        grBx_Course = new System.Windows.Forms.GroupBox();
        btn_reservar = new System.Windows.Forms.Button();
        ltBx_profesores = new System.Windows.Forms.ListBox();
        ltBx_horarios = new System.Windows.Forms.ListBox();
        lbl_prfsr = new System.Windows.Forms.Label();
        lbl_asesoria = new System.Windows.Forms.Label();
        grBx_userInfo = new System.Windows.Forms.GroupBox();
        grBx_Course.SuspendLayout();
        grBx_userInfo.SuspendLayout();
        SuspendLayout();
        // 
        // btn_exit
        // 
        btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_exit.Location = new System.Drawing.Point(110, 170);
        btn_exit.Name = "btn_exit";
        btn_exit.Size = new System.Drawing.Size(166, 39);
        btn_exit.TabIndex = 1;
        btn_exit.Text = "Salir";
        btn_exit.UseVisualStyleBackColor = false;
        btn_exit.Click += btn_exit_Click;
        // 
        // lbl_user
        // 
        lbl_user.Location = new System.Drawing.Point(25, 46);
        lbl_user.Name = "lbl_user";
        lbl_user.Size = new System.Drawing.Size(243, 33);
        lbl_user.TabIndex = 2;
        lbl_user.Text = "Usuario: ";
        // 
        // lbl_fullname
        // 
        lbl_fullname.Location = new System.Drawing.Point(25, 89);
        lbl_fullname.Name = "lbl_fullname";
        lbl_fullname.Size = new System.Drawing.Size(251, 69);
        lbl_fullname.TabIndex = 3;
        lbl_fullname.Text = "Nombre: ";
        // 
        // cmBx_Course
        // 
        cmBx_Course.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        cmBx_Course.FormattingEnabled = true;
        cmBx_Course.Items.AddRange(new object[] { "Base de Datos", "Calculo integral", "Desarrollo del pensamiento y toma de decisiones", "Ingles III", "Programacion Orientada a Objetos", "Proyecto Integrador I", "Topicos De caldad Para El Diseño De Software" });
        cmBx_Course.Location = new System.Drawing.Point(16, 41);
        cmBx_Course.Name = "cmBx_Course";
        cmBx_Course.Size = new System.Drawing.Size(282, 33);
        cmBx_Course.TabIndex = 4;
        cmBx_Course.SelectedIndexChanged += cmBx_Course_SelectedIndexChanged;
        // 
        // grBx_Course
        // 
        grBx_Course.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        grBx_Course.Controls.Add(btn_reservar);
        grBx_Course.Controls.Add(ltBx_profesores);
        grBx_Course.Controls.Add(ltBx_horarios);
        grBx_Course.Controls.Add(cmBx_Course);
        grBx_Course.Controls.Add(lbl_prfsr);
        grBx_Course.Controls.Add(lbl_asesoria);
        grBx_Course.Location = new System.Drawing.Point(21, 36);
        grBx_Course.Name = "grBx_Course";
        grBx_Course.Size = new System.Drawing.Size(916, 612);
        grBx_Course.TabIndex = 5;
        grBx_Course.TabStop = false;
        grBx_Course.Text = "Seleccione una materia";
        // 
        // btn_reservar
        // 
        btn_reservar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_reservar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_reservar.Location = new System.Drawing.Point(728, 517);
        btn_reservar.Name = "btn_reservar";
        btn_reservar.Size = new System.Drawing.Size(177, 69);
        btn_reservar.TabIndex = 7;
        btn_reservar.Text = "Reservar";
        btn_reservar.UseVisualStyleBackColor = false;
        btn_reservar.Click += btn_reservar_Click;
        // 
        // ltBx_profesores
        // 
        ltBx_profesores.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        ltBx_profesores.FormattingEnabled = true;
        ltBx_profesores.Location = new System.Drawing.Point(342, 132);
        ltBx_profesores.Name = "ltBx_profesores";
        ltBx_profesores.Size = new System.Drawing.Size(370, 454);
        ltBx_profesores.TabIndex = 6;
        // 
        // ltBx_horarios
        // 
        ltBx_horarios.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        ltBx_horarios.FormattingEnabled = true;
        ltBx_horarios.Location = new System.Drawing.Point(21, 132);
        ltBx_horarios.Name = "ltBx_horarios";
        ltBx_horarios.Size = new System.Drawing.Size(300, 454);
        ltBx_horarios.TabIndex = 5;
        // 
        // lbl_prfsr
        // 
        lbl_prfsr.Location = new System.Drawing.Point(342, 94);
        lbl_prfsr.Name = "lbl_prfsr";
        lbl_prfsr.Size = new System.Drawing.Size(344, 35);
        lbl_prfsr.TabIndex = 1;
        lbl_prfsr.Text = "Profesor/a";
        lbl_prfsr.Visible = false;
        // 
        // lbl_asesoria
        // 
        lbl_asesoria.Location = new System.Drawing.Point(21, 94);
        lbl_asesoria.Name = "lbl_asesoria";
        lbl_asesoria.Size = new System.Drawing.Size(266, 35);
        lbl_asesoria.TabIndex = 0;
        lbl_asesoria.Text = "Horarios disponibles";
        lbl_asesoria.Visible = false;
        // 
        // grBx_userInfo
        // 
        grBx_userInfo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        grBx_userInfo.Controls.Add(lbl_fullname);
        grBx_userInfo.Controls.Add(lbl_user);
        grBx_userInfo.Controls.Add(btn_exit);
        grBx_userInfo.Location = new System.Drawing.Point(973, 36);
        grBx_userInfo.Name = "grBx_userInfo";
        grBx_userInfo.Size = new System.Drawing.Size(297, 243);
        grBx_userInfo.TabIndex = 6;
        grBx_userInfo.TabStop = false;
        grBx_userInfo.Text = "Información del Usuario";
        // 
        // Asesoria
        // 
        AcceptButton = btn_reservar;
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        CancelButton = btn_exit;
        ClientSize = new System.Drawing.Size(1326, 818);
        Controls.Add(grBx_userInfo);
        Controls.Add(grBx_Course);
        Text = "Genera tu asesoría";
        grBx_Course.ResumeLayout(false);
        grBx_userInfo.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox grBx_userInfo;

    private System.Windows.Forms.Button btn_reservar;

    private System.Windows.Forms.ListBox ltBx_horarios;
    private System.Windows.Forms.ListBox ltBx_profesores;

    private System.Windows.Forms.Label lbl_asesoria;

    private System.Windows.Forms.Label lbl_prfsr;

    private System.Windows.Forms.GroupBox grBx_Course;

    private System.Windows.Forms.ComboBox cmBx_Course;

    private System.Windows.Forms.Label lbl_user;
    private System.Windows.Forms.Label lbl_fullname;

    private System.Windows.Forms.Button btn_exit;

    #endregion
}