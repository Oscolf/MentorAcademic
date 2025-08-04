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
        tabControl = new System.Windows.Forms.TabControl();
        tabMainMenu = new System.Windows.Forms.TabPage();
        groupBox1 = new System.Windows.Forms.GroupBox();
        btn_culturales = new System.Windows.Forms.Button();
        btn_deportivos = new System.Windows.Forms.Button();
        lbl_welcome = new System.Windows.Forms.Label();
        lbl_asesorias = new System.Windows.Forms.Label();
        lbl_clubes = new System.Windows.Forms.Label();
        btn_asesorias = new System.Windows.Forms.Button();
        btn_clubes = new System.Windows.Forms.Button();
        tabAsesorias = new System.Windows.Forms.TabPage();
        grBx_Course = new System.Windows.Forms.GroupBox();
        btn_asesoriaRegresar = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        dateTP_asesoria = new System.Windows.Forms.DateTimePicker();
        lbl_HorarioSel = new System.Windows.Forms.Label();
        lbl_profID = new System.Windows.Forms.Label();
        btn_reservar = new System.Windows.Forms.Button();
        ltBx_profesores = new System.Windows.Forms.ListBox();
        ltBx_horarios = new System.Windows.Forms.ListBox();
        cmBx_Course = new System.Windows.Forms.ComboBox();
        lbl_prfsr = new System.Windows.Forms.Label();
        lbl_asesoria = new System.Windows.Forms.Label();
        tabClubDeportivo = new System.Windows.Forms.TabPage();
        grBx_deportivos = new System.Windows.Forms.GroupBox();
        btn_regresarClubes = new System.Windows.Forms.Button();
        btn_voleybol = new System.Windows.Forms.Button();
        btn_beisbol = new System.Windows.Forms.Button();
        btn_kendo = new System.Windows.Forms.Button();
        btn_futbol = new System.Windows.Forms.Button();
        btn_crossfit = new System.Windows.Forms.Button();
        btn_karate = new System.Windows.Forms.Button();
        btn_basquetbol = new System.Windows.Forms.Button();
        btn_atletismo = new System.Windows.Forms.Button();
        btn_defensaPersonal = new System.Windows.Forms.Button();
        btn_taekwondo = new System.Windows.Forms.Button();
        tabClubCultural = new System.Windows.Forms.TabPage();
        grBx_culturales = new System.Windows.Forms.GroupBox();
        btn_regresar = new System.Windows.Forms.Button();
        btn_ritmosLatinos = new System.Windows.Forms.Button();
        btn_porristas = new System.Windows.Forms.Button();
        btn_bandaGuerra = new System.Windows.Forms.Button();
        btn_ajedrez = new System.Windows.Forms.Button();
        btn_rondallaCanto = new System.Windows.Forms.Button();
        btn_danzaFolk = new System.Windows.Forms.Button();
        tabUser = new System.Windows.Forms.TabPage();
        grBx_userConfig = new System.Windows.Forms.GroupBox();
        btn_unsignClub = new System.Windows.Forms.Button();
        btn_deleteAcc = new System.Windows.Forms.Button();
        btn_changePass = new System.Windows.Forms.Button();
        btn_showPass = new System.Windows.Forms.Button();
        ltBx_AsesoriasReg = new System.Windows.Forms.ListBox();
        txBx_ClubSigned = new System.Windows.Forms.TextBox();
        txBx_Password = new System.Windows.Forms.TextBox();
        txBx_Email = new System.Windows.Forms.TextBox();
        txBx_FullName = new System.Windows.Forms.TextBox();
        lbl_profileAsesorias = new System.Windows.Forms.Label();
        lbl_profileClubs = new System.Windows.Forms.Label();
        lbl_profilePassword = new System.Windows.Forms.Label();
        lbl_profileEmail = new System.Windows.Forms.Label();
        lbl_profileName = new System.Windows.Forms.Label();
        grBx_Usuario = new System.Windows.Forms.GroupBox();
        btn_config = new System.Windows.Forms.Button();
        lbl_nameText = new System.Windows.Forms.Label();
        lbl_matrText = new System.Windows.Forms.Label();
        lbl_name = new System.Windows.Forms.Label();
        lbl_matr = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        tabControl.SuspendLayout();
        tabMainMenu.SuspendLayout();
        groupBox1.SuspendLayout();
        tabAsesorias.SuspendLayout();
        grBx_Course.SuspendLayout();
        tabClubDeportivo.SuspendLayout();
        grBx_deportivos.SuspendLayout();
        tabClubCultural.SuspendLayout();
        grBx_culturales.SuspendLayout();
        tabUser.SuspendLayout();
        grBx_userConfig.SuspendLayout();
        grBx_Usuario.SuspendLayout();
        SuspendLayout();
        // 
        // btn_signout
        // 
        btn_signout.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_signout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_signout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_signout.Location = new System.Drawing.Point(194, 211);
        btn_signout.Name = "btn_signout";
        btn_signout.Size = new System.Drawing.Size(172, 84);
        btn_signout.TabIndex = 2;
        btn_signout.Text = "Cerrar sesión";
        btn_signout.UseVisualStyleBackColor = false;
        btn_signout.Click += btn_signout_Click;
        // 
        // tabControl
        // 
        tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
        tabControl.Controls.Add(tabMainMenu);
        tabControl.Controls.Add(tabAsesorias);
        tabControl.Controls.Add(tabClubDeportivo);
        tabControl.Controls.Add(tabClubCultural);
        tabControl.Controls.Add(tabUser);
        tabControl.Dock = System.Windows.Forms.DockStyle.Top;
        tabControl.Location = new System.Drawing.Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new System.Drawing.Size(1826, 1216);
        tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
        tabControl.TabIndex = 10;
        // 
        // tabMainMenu
        // 
        tabMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        tabMainMenu.Controls.Add(groupBox1);
        tabMainMenu.Location = new System.Drawing.Point(4, 37);
        tabMainMenu.Name = "tabMainMenu";
        tabMainMenu.Padding = new System.Windows.Forms.Padding(3);
        tabMainMenu.Size = new System.Drawing.Size(1818, 1175);
        tabMainMenu.TabIndex = 0;
        tabMainMenu.Text = "Menú Principal";
        // 
        // groupBox1
        // 
        groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        groupBox1.Controls.Add(btn_culturales);
        groupBox1.Controls.Add(btn_deportivos);
        groupBox1.Controls.Add(lbl_welcome);
        groupBox1.Controls.Add(lbl_asesorias);
        groupBox1.Controls.Add(lbl_clubes);
        groupBox1.Controls.Add(btn_asesorias);
        groupBox1.Controls.Add(btn_clubes);
        groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        groupBox1.Location = new System.Drawing.Point(17, 28);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(1361, 1077);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        groupBox1.Text = "Inicio";
        // 
        // btn_culturales
        // 
        btn_culturales.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_culturales.Enabled = false;
        btn_culturales.Location = new System.Drawing.Point(50, 312);
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
        btn_deportivos.Location = new System.Drawing.Point(703, 312);
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
        lbl_welcome.Location = new System.Drawing.Point(240, 51);
        lbl_welcome.Name = "lbl_welcome";
        lbl_welcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        lbl_welcome.Size = new System.Drawing.Size(797, 54);
        lbl_welcome.TabIndex = 5;
        lbl_welcome.Text = "Bienvenid@ [usuario] Seleccione un servicio";
        lbl_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lbl_asesorias
        // 
        lbl_asesorias.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_asesorias.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_asesorias.Location = new System.Drawing.Point(176, 552);
        lbl_asesorias.Name = "lbl_asesorias";
        lbl_asesorias.Size = new System.Drawing.Size(292, 152);
        lbl_asesorias.TabIndex = 8;
        lbl_asesorias.Text = "Pide y organiza una asesoría con algún profesor";
        lbl_asesorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // lbl_clubes
        // 
        lbl_clubes.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_clubes.Font = new System.Drawing.Font("Segoe UI Semilight", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_clubes.Location = new System.Drawing.Point(838, 574);
        lbl_clubes.Name = "lbl_clubes";
        lbl_clubes.Size = new System.Drawing.Size(292, 152);
        lbl_clubes.TabIndex = 9;
        lbl_clubes.Text = "Infórmate y únete a alguna actividad cultural o deportiva";
        lbl_clubes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btn_asesorias
        // 
        btn_asesorias.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_asesorias.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_asesorias.Location = new System.Drawing.Point(50, 260);
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
        btn_clubes.Location = new System.Drawing.Point(703, 253);
        btn_clubes.Name = "btn_clubes";
        btn_clubes.Size = new System.Drawing.Size(550, 660);
        btn_clubes.TabIndex = 4;
        btn_clubes.Text = "\r\n\r\nInscribirte a un club";
        btn_clubes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        btn_clubes.UseVisualStyleBackColor = false;
        btn_clubes.Click += btn_clubes_Click;
        // 
        // tabAsesorias
        // 
        tabAsesorias.BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        tabAsesorias.Controls.Add(grBx_Course);
        tabAsesorias.Location = new System.Drawing.Point(4, 37);
        tabAsesorias.Name = "tabAsesorias";
        tabAsesorias.Padding = new System.Windows.Forms.Padding(3);
        tabAsesorias.Size = new System.Drawing.Size(1818, 1175);
        tabAsesorias.TabIndex = 1;
        tabAsesorias.Text = "Programar Asesorías";
        // 
        // grBx_Course
        // 
        grBx_Course.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        grBx_Course.Controls.Add(btn_asesoriaRegresar);
        grBx_Course.Controls.Add(label1);
        grBx_Course.Controls.Add(dateTP_asesoria);
        grBx_Course.Controls.Add(lbl_HorarioSel);
        grBx_Course.Controls.Add(lbl_profID);
        grBx_Course.Controls.Add(btn_reservar);
        grBx_Course.Controls.Add(ltBx_profesores);
        grBx_Course.Controls.Add(ltBx_horarios);
        grBx_Course.Controls.Add(cmBx_Course);
        grBx_Course.Controls.Add(lbl_prfsr);
        grBx_Course.Controls.Add(lbl_asesoria);
        grBx_Course.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grBx_Course.Location = new System.Drawing.Point(23, 24);
        grBx_Course.Name = "grBx_Course";
        grBx_Course.Size = new System.Drawing.Size(1228, 1080);
        grBx_Course.TabIndex = 6;
        grBx_Course.TabStop = false;
        grBx_Course.Text = "Seleccione una materia";
        // 
        // btn_asesoriaRegresar
        // 
        btn_asesoriaRegresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_asesoriaRegresar.Location = new System.Drawing.Point(6, 1017);
        btn_asesoriaRegresar.Name = "btn_asesoriaRegresar";
        btn_asesoriaRegresar.Size = new System.Drawing.Size(253, 57);
        btn_asesoriaRegresar.TabIndex = 12;
        btn_asesoriaRegresar.Text = "Regresar";
        btn_asesoriaRegresar.UseVisualStyleBackColor = false;
        btn_asesoriaRegresar.Click += btn_regresar_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(624, 588);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(424, 45);
        label1.TabIndex = 11;
        label1.Text = "Seleccione el día a reservar";
        // 
        // dateTP_asesoria
        // 
        dateTP_asesoria.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        dateTP_asesoria.Location = new System.Drawing.Point(623, 636);
        dateTP_asesoria.Name = "dateTP_asesoria";
        dateTP_asesoria.Size = new System.Drawing.Size(570, 45);
        dateTP_asesoria.TabIndex = 10;
        // 
        // lbl_HorarioSel
        // 
        lbl_HorarioSel.AutoSize = true;
        lbl_HorarioSel.Location = new System.Drawing.Point(1068, 131);
        lbl_HorarioSel.Name = "lbl_HorarioSel";
        lbl_HorarioSel.Size = new System.Drawing.Size(143, 38);
        lbl_HorarioSel.TabIndex = 9;
        lbl_HorarioSel.Text = "horarioSel";
        lbl_HorarioSel.Visible = false;
        // 
        // lbl_profID
        // 
        lbl_profID.AutoSize = true;
        lbl_profID.Location = new System.Drawing.Point(488, 123);
        lbl_profID.Name = "lbl_profID";
        lbl_profID.Size = new System.Drawing.Size(95, 38);
        lbl_profID.TabIndex = 8;
        lbl_profID.Text = "profID";
        lbl_profID.Visible = false;
        // 
        // btn_reservar
        // 
        btn_reservar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_reservar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_reservar.Location = new System.Drawing.Point(970, 947);
        btn_reservar.Name = "btn_reservar";
        btn_reservar.Size = new System.Drawing.Size(252, 127);
        btn_reservar.TabIndex = 7;
        btn_reservar.Text = "Reservar";
        btn_reservar.UseVisualStyleBackColor = false;
        btn_reservar.Click += btn_reservar_Click;
        // 
        // ltBx_profesores
        // 
        ltBx_profesores.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        ltBx_profesores.FormattingEnabled = true;
        ltBx_profesores.Location = new System.Drawing.Point(9, 172);
        ltBx_profesores.Name = "ltBx_profesores";
        ltBx_profesores.Size = new System.Drawing.Size(574, 384);
        ltBx_profesores.TabIndex = 6;
        ltBx_profesores.SelectedIndexChanged += ltBx_profesores_SelectedIndexChanged;
        // 
        // ltBx_horarios
        // 
        ltBx_horarios.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        ltBx_horarios.FormattingEnabled = true;
        ltBx_horarios.Location = new System.Drawing.Point(623, 172);
        ltBx_horarios.Name = "ltBx_horarios";
        ltBx_horarios.Size = new System.Drawing.Size(572, 384);
        ltBx_horarios.TabIndex = 5;
        // 
        // cmBx_Course
        // 
        cmBx_Course.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        cmBx_Course.FormattingEnabled = true;
        cmBx_Course.Items.AddRange(new object[] { "Base de Datos", "Calculo integral", "Desarrollo Del Pensamiento Y Toma De Decisiones", "Inglés III", "Programacion Orientada a Objetos", "Proyecto Integrador I", "Tópicos De Calidad Para El Diseño De Software" });
        cmBx_Course.Location = new System.Drawing.Point(6, 45);
        cmBx_Course.Name = "cmBx_Course";
        cmBx_Course.Size = new System.Drawing.Size(577, 46);
        cmBx_Course.TabIndex = 4;
        cmBx_Course.SelectedIndexChanged += cmBx_Course_SelectedIndexChanged;
        // 
        // lbl_prfsr
        // 
        lbl_prfsr.Location = new System.Drawing.Point(9, 123);
        lbl_prfsr.Name = "lbl_prfsr";
        lbl_prfsr.Size = new System.Drawing.Size(161, 35);
        lbl_prfsr.TabIndex = 1;
        lbl_prfsr.Text = "Profesor/a";
        // 
        // lbl_asesoria
        // 
        lbl_asesoria.Location = new System.Drawing.Point(614, 123);
        lbl_asesoria.Name = "lbl_asesoria";
        lbl_asesoria.Size = new System.Drawing.Size(266, 35);
        lbl_asesoria.TabIndex = 0;
        lbl_asesoria.Text = "Horarios disponibles";
        // 
        // tabClubDeportivo
        // 
        tabClubDeportivo.BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        tabClubDeportivo.Controls.Add(grBx_deportivos);
        tabClubDeportivo.Location = new System.Drawing.Point(4, 37);
        tabClubDeportivo.Name = "tabClubDeportivo";
        tabClubDeportivo.Size = new System.Drawing.Size(1818, 1175);
        tabClubDeportivo.TabIndex = 2;
        tabClubDeportivo.Text = "Inscribirse a un Club Deportivo";
        // 
        // grBx_deportivos
        // 
        grBx_deportivos.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        grBx_deportivos.Controls.Add(btn_regresarClubes);
        grBx_deportivos.Controls.Add(btn_voleybol);
        grBx_deportivos.Controls.Add(btn_beisbol);
        grBx_deportivos.Controls.Add(btn_kendo);
        grBx_deportivos.Controls.Add(btn_futbol);
        grBx_deportivos.Controls.Add(btn_crossfit);
        grBx_deportivos.Controls.Add(btn_karate);
        grBx_deportivos.Controls.Add(btn_basquetbol);
        grBx_deportivos.Controls.Add(btn_atletismo);
        grBx_deportivos.Controls.Add(btn_defensaPersonal);
        grBx_deportivos.Controls.Add(btn_taekwondo);
        grBx_deportivos.Location = new System.Drawing.Point(13, 29);
        grBx_deportivos.Name = "grBx_deportivos";
        grBx_deportivos.Size = new System.Drawing.Size(1364, 1006);
        grBx_deportivos.TabIndex = 22;
        grBx_deportivos.TabStop = false;
        grBx_deportivos.Text = "Seleccione un club";
        // 
        // btn_regresarClubes
        // 
        btn_regresarClubes.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_regresarClubes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_regresarClubes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_regresarClubes.Location = new System.Drawing.Point(940, 851);
        btn_regresarClubes.Name = "btn_regresarClubes";
        btn_regresarClubes.Size = new System.Drawing.Size(300, 100);
        btn_regresarClubes.TabIndex = 21;
        btn_regresarClubes.Text = "Regresar";
        btn_regresarClubes.UseVisualStyleBackColor = false;
        btn_regresarClubes.Click += btn_regresar_Click;
        // 
        // btn_voleybol
        // 
        btn_voleybol.BackgroundImage = global::WinFormsMentorAcademic.Fondos.voleybol;
        btn_voleybol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_voleybol.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_voleybol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_voleybol.Location = new System.Drawing.Point(329, 665);
        btn_voleybol.Name = "btn_voleybol";
        btn_voleybol.Size = new System.Drawing.Size(300, 300);
        btn_voleybol.TabIndex = 20;
        btn_voleybol.Text = "Voleybol";
        btn_voleybol.UseVisualStyleBackColor = true;
        btn_voleybol.Click += btn_voleybol_Click;
        // 
        // btn_beisbol
        // 
        btn_beisbol.BackgroundImage = global::WinFormsMentorAcademic.Fondos.beisbol;
        btn_beisbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_beisbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_beisbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_beisbol.Location = new System.Drawing.Point(635, 52);
        btn_beisbol.Name = "btn_beisbol";
        btn_beisbol.Size = new System.Drawing.Size(300, 300);
        btn_beisbol.TabIndex = 19;
        btn_beisbol.Text = "Beisbol";
        btn_beisbol.UseVisualStyleBackColor = true;
        btn_beisbol.Click += btn_beisbol_Click;
        // 
        // btn_kendo
        // 
        btn_kendo.BackgroundImage = global::WinFormsMentorAcademic.Fondos.kendo;
        btn_kendo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_kendo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_kendo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_kendo.Location = new System.Drawing.Point(941, 358);
        btn_kendo.Name = "btn_kendo";
        btn_kendo.Size = new System.Drawing.Size(300, 300);
        btn_kendo.TabIndex = 18;
        btn_kendo.Text = "Kendo";
        btn_kendo.UseVisualStyleBackColor = true;
        btn_kendo.Click += btn_kendo_Click;
        // 
        // btn_futbol
        // 
        btn_futbol.BackgroundImage = global::WinFormsMentorAcademic.Fondos.futbol;
        btn_futbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_futbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_futbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_futbol.Location = new System.Drawing.Point(329, 358);
        btn_futbol.Name = "btn_futbol";
        btn_futbol.Size = new System.Drawing.Size(300, 300);
        btn_futbol.TabIndex = 17;
        btn_futbol.Text = "Futbol";
        btn_futbol.UseVisualStyleBackColor = true;
        btn_futbol.Click += btn_futbol_Click;
        // 
        // btn_crossfit
        // 
        btn_crossfit.BackgroundImage = global::WinFormsMentorAcademic.Fondos.crossfit;
        btn_crossfit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_crossfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_crossfit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_crossfit.Location = new System.Drawing.Point(941, 52);
        btn_crossfit.Name = "btn_crossfit";
        btn_crossfit.Size = new System.Drawing.Size(300, 300);
        btn_crossfit.TabIndex = 16;
        btn_crossfit.Text = "Crossfit";
        btn_crossfit.UseVisualStyleBackColor = true;
        btn_crossfit.Click += btn_crossfit_Click;
        // 
        // btn_karate
        // 
        btn_karate.BackgroundImage = global::WinFormsMentorAcademic.Fondos.karate;
        btn_karate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_karate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_karate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_karate.Location = new System.Drawing.Point(635, 358);
        btn_karate.Name = "btn_karate";
        btn_karate.Size = new System.Drawing.Size(300, 300);
        btn_karate.TabIndex = 14;
        btn_karate.Text = "Karate";
        btn_karate.UseVisualStyleBackColor = true;
        btn_karate.Click += btn_karate_Click;
        // 
        // btn_basquetbol
        // 
        btn_basquetbol.BackgroundImage = global::WinFormsMentorAcademic.Fondos.basquetbol;
        btn_basquetbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_basquetbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_basquetbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_basquetbol.Location = new System.Drawing.Point(329, 52);
        btn_basquetbol.Name = "btn_basquetbol";
        btn_basquetbol.Size = new System.Drawing.Size(300, 300);
        btn_basquetbol.TabIndex = 13;
        btn_basquetbol.Text = "Basquetbol";
        btn_basquetbol.UseVisualStyleBackColor = true;
        btn_basquetbol.Click += btn_basquetbol_Click;
        // 
        // btn_atletismo
        // 
        btn_atletismo.BackgroundImage = global::WinFormsMentorAcademic.Fondos.atletismo;
        btn_atletismo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_atletismo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_atletismo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_atletismo.Location = new System.Drawing.Point(23, 52);
        btn_atletismo.Name = "btn_atletismo";
        btn_atletismo.Size = new System.Drawing.Size(300, 300);
        btn_atletismo.TabIndex = 12;
        btn_atletismo.Text = "Atletísmo";
        btn_atletismo.UseVisualStyleBackColor = true;
        btn_atletismo.Click += btn_atletismo_Click;
        // 
        // btn_defensaPersonal
        // 
        btn_defensaPersonal.BackgroundImage = global::WinFormsMentorAcademic.Fondos.defensa_personal;
        btn_defensaPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_defensaPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_defensaPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_defensaPersonal.Location = new System.Drawing.Point(23, 358);
        btn_defensaPersonal.Name = "btn_defensaPersonal";
        btn_defensaPersonal.Size = new System.Drawing.Size(300, 300);
        btn_defensaPersonal.TabIndex = 15;
        btn_defensaPersonal.Text = "Defensa personal";
        btn_defensaPersonal.UseVisualStyleBackColor = true;
        btn_defensaPersonal.Click += btn_defensaPersonal_Click;
        // 
        // btn_taekwondo
        // 
        btn_taekwondo.BackgroundImage = global::WinFormsMentorAcademic.Fondos.danza_folklorica;
        btn_taekwondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_taekwondo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_taekwondo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_taekwondo.Location = new System.Drawing.Point(23, 665);
        btn_taekwondo.Name = "btn_taekwondo";
        btn_taekwondo.Size = new System.Drawing.Size(300, 300);
        btn_taekwondo.TabIndex = 11;
        btn_taekwondo.Text = "Tae-kwon-do";
        btn_taekwondo.UseVisualStyleBackColor = true;
        btn_taekwondo.Click += btn_taekwondo_Click;
        // 
        // tabClubCultural
        // 
        tabClubCultural.BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        tabClubCultural.Controls.Add(grBx_culturales);
        tabClubCultural.Location = new System.Drawing.Point(4, 37);
        tabClubCultural.Name = "tabClubCultural";
        tabClubCultural.Size = new System.Drawing.Size(1818, 1175);
        tabClubCultural.TabIndex = 4;
        tabClubCultural.Text = "Inscribirse a un club cultural";
        // 
        // grBx_culturales
        // 
        grBx_culturales.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        grBx_culturales.Controls.Add(btn_regresar);
        grBx_culturales.Controls.Add(btn_ritmosLatinos);
        grBx_culturales.Controls.Add(btn_porristas);
        grBx_culturales.Controls.Add(btn_bandaGuerra);
        grBx_culturales.Controls.Add(btn_ajedrez);
        grBx_culturales.Controls.Add(btn_rondallaCanto);
        grBx_culturales.Controls.Add(btn_danzaFolk);
        grBx_culturales.Location = new System.Drawing.Point(12, 17);
        grBx_culturales.Name = "grBx_culturales";
        grBx_culturales.Size = new System.Drawing.Size(1292, 907);
        grBx_culturales.TabIndex = 14;
        grBx_culturales.TabStop = false;
        grBx_culturales.Text = "Seleccione un club";
        // 
        // btn_regresar
        // 
        btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_regresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_regresar.Location = new System.Drawing.Point(927, 761);
        btn_regresar.Name = "btn_regresar";
        btn_regresar.Size = new System.Drawing.Size(300, 100);
        btn_regresar.TabIndex = 13;
        btn_regresar.Text = "Regresar";
        btn_regresar.UseVisualStyleBackColor = false;
        btn_regresar.Click += btn_regresar_Click;
        // 
        // btn_ritmosLatinos
        // 
        btn_ritmosLatinos.BackColor = System.Drawing.Color.Black;
        btn_ritmosLatinos.BackgroundImage = global::WinFormsMentorAcademic.Fondos.ritmos_latinos;
        btn_ritmosLatinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_ritmosLatinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_ritmosLatinos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_ritmosLatinos.Location = new System.Drawing.Point(827, 359);
        btn_ritmosLatinos.Name = "btn_ritmosLatinos";
        btn_ritmosLatinos.Size = new System.Drawing.Size(400, 300);
        btn_ritmosLatinos.TabIndex = 12;
        btn_ritmosLatinos.Text = "Ritmos Latinos";
        btn_ritmosLatinos.UseVisualStyleBackColor = false;
        btn_ritmosLatinos.Click += btn_ritmosLatinos_Click;
        // 
        // btn_porristas
        // 
        btn_porristas.BackColor = System.Drawing.Color.Black;
        btn_porristas.BackgroundImage = global::WinFormsMentorAcademic.Fondos.porristas;
        btn_porristas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_porristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_porristas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_porristas.Location = new System.Drawing.Point(15, 359);
        btn_porristas.Name = "btn_porristas";
        btn_porristas.Size = new System.Drawing.Size(400, 300);
        btn_porristas.TabIndex = 10;
        btn_porristas.Text = "Porristas";
        btn_porristas.UseVisualStyleBackColor = false;
        btn_porristas.Click += btn_porristas_Click;
        // 
        // btn_bandaGuerra
        // 
        btn_bandaGuerra.BackColor = System.Drawing.Color.Black;
        btn_bandaGuerra.BackgroundImage = global::WinFormsMentorAcademic.Fondos.minion_tarolero;
        btn_bandaGuerra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_bandaGuerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_bandaGuerra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_bandaGuerra.Location = new System.Drawing.Point(421, 53);
        btn_bandaGuerra.Name = "btn_bandaGuerra";
        btn_bandaGuerra.Size = new System.Drawing.Size(400, 300);
        btn_bandaGuerra.TabIndex = 9;
        btn_bandaGuerra.Text = "Banda de guerra";
        btn_bandaGuerra.UseVisualStyleBackColor = false;
        btn_bandaGuerra.Click += btn_bandaGuerra_Click;
        // 
        // btn_ajedrez
        // 
        btn_ajedrez.BackColor = System.Drawing.Color.Black;
        btn_ajedrez.BackgroundImage = global::WinFormsMentorAcademic.Fondos.ajedrez;
        btn_ajedrez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_ajedrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_ajedrez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_ajedrez.Location = new System.Drawing.Point(15, 53);
        btn_ajedrez.Name = "btn_ajedrez";
        btn_ajedrez.Size = new System.Drawing.Size(400, 300);
        btn_ajedrez.TabIndex = 8;
        btn_ajedrez.Text = "Ajedrez";
        btn_ajedrez.UseVisualStyleBackColor = false;
        btn_ajedrez.Click += btn_ajedrez_Click;
        // 
        // btn_rondallaCanto
        // 
        btn_rondallaCanto.BackColor = System.Drawing.Color.Black;
        btn_rondallaCanto.BackgroundImage = global::WinFormsMentorAcademic.Fondos.rondalla_y_canto;
        btn_rondallaCanto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_rondallaCanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_rondallaCanto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_rondallaCanto.Location = new System.Drawing.Point(421, 359);
        btn_rondallaCanto.Name = "btn_rondallaCanto";
        btn_rondallaCanto.Size = new System.Drawing.Size(400, 300);
        btn_rondallaCanto.TabIndex = 11;
        btn_rondallaCanto.Text = "Rondalla y canto";
        btn_rondallaCanto.UseVisualStyleBackColor = false;
        btn_rondallaCanto.Click += btn_rondallaCanto_Click;
        // 
        // btn_danzaFolk
        // 
        btn_danzaFolk.BackColor = System.Drawing.Color.Black;
        btn_danzaFolk.BackgroundImage = global::WinFormsMentorAcademic.Fondos.danza_folklorica;
        btn_danzaFolk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_danzaFolk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_danzaFolk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_danzaFolk.Location = new System.Drawing.Point(827, 53);
        btn_danzaFolk.Name = "btn_danzaFolk";
        btn_danzaFolk.Size = new System.Drawing.Size(400, 300);
        btn_danzaFolk.TabIndex = 7;
        btn_danzaFolk.Text = "Danza Folklórica";
        btn_danzaFolk.UseVisualStyleBackColor = false;
        btn_danzaFolk.Click += btn_danzaFolk_Click;
        // 
        // tabUser
        // 
        tabUser.BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        tabUser.Controls.Add(grBx_userConfig);
        tabUser.Location = new System.Drawing.Point(4, 37);
        tabUser.Name = "tabUser";
        tabUser.Size = new System.Drawing.Size(1818, 1175);
        tabUser.TabIndex = 3;
        tabUser.Text = "Configuración de Usuario";
        // 
        // grBx_userConfig
        // 
        grBx_userConfig.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        grBx_userConfig.Controls.Add(button1);
        grBx_userConfig.Controls.Add(btn_unsignClub);
        grBx_userConfig.Controls.Add(btn_deleteAcc);
        grBx_userConfig.Controls.Add(btn_changePass);
        grBx_userConfig.Controls.Add(btn_showPass);
        grBx_userConfig.Controls.Add(ltBx_AsesoriasReg);
        grBx_userConfig.Controls.Add(txBx_ClubSigned);
        grBx_userConfig.Controls.Add(txBx_Password);
        grBx_userConfig.Controls.Add(txBx_Email);
        grBx_userConfig.Controls.Add(txBx_FullName);
        grBx_userConfig.Controls.Add(lbl_profileAsesorias);
        grBx_userConfig.Controls.Add(lbl_profileClubs);
        grBx_userConfig.Controls.Add(lbl_profilePassword);
        grBx_userConfig.Controls.Add(lbl_profileEmail);
        grBx_userConfig.Controls.Add(lbl_profileName);
        grBx_userConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        grBx_userConfig.Location = new System.Drawing.Point(25, 36);
        grBx_userConfig.Name = "grBx_userConfig";
        grBx_userConfig.Size = new System.Drawing.Size(1381, 1034);
        grBx_userConfig.TabIndex = 3;
        grBx_userConfig.TabStop = false;
        grBx_userConfig.Text = "Perfil de Usuario";
        // 
        // btn_unsignClub
        // 
        btn_unsignClub.Location = new System.Drawing.Point(657, 315);
        btn_unsignClub.Name = "btn_unsignClub";
        btn_unsignClub.Size = new System.Drawing.Size(214, 38);
        btn_unsignClub.TabIndex = 13;
        btn_unsignClub.Text = "Dar club de baja";
        btn_unsignClub.UseVisualStyleBackColor = true;
        btn_unsignClub.Click += btn_unsignClub_Click;
        // 
        // btn_deleteAcc
        // 
        btn_deleteAcc.Location = new System.Drawing.Point(1096, 961);
        btn_deleteAcc.Name = "btn_deleteAcc";
        btn_deleteAcc.Size = new System.Drawing.Size(241, 54);
        btn_deleteAcc.TabIndex = 12;
        btn_deleteAcc.Text = "Eliminar Cuenta";
        btn_deleteAcc.UseVisualStyleBackColor = true;
        btn_deleteAcc.Click += btn_deleteAcc_Click;
        // 
        // btn_changePass
        // 
        btn_changePass.Location = new System.Drawing.Point(537, 249);
        btn_changePass.Name = "btn_changePass";
        btn_changePass.Size = new System.Drawing.Size(186, 42);
        btn_changePass.TabIndex = 11;
        btn_changePass.Text = "Modificar";
        btn_changePass.UseVisualStyleBackColor = true;
        btn_changePass.Click += btn_changePass_Click;
        // 
        // btn_showPass
        // 
        btn_showPass.Location = new System.Drawing.Point(291, 249);
        btn_showPass.Name = "btn_showPass";
        btn_showPass.Size = new System.Drawing.Size(240, 42);
        btn_showPass.TabIndex = 10;
        btn_showPass.Text = "Mostrar contraseña";
        btn_showPass.UseVisualStyleBackColor = true;
        btn_showPass.Click += btn_showPass_Click;
        // 
        // ltBx_AsesoriasReg
        // 
        ltBx_AsesoriasReg.FormattingEnabled = true;
        ltBx_AsesoriasReg.Location = new System.Drawing.Point(24, 435);
        ltBx_AsesoriasReg.Name = "ltBx_AsesoriasReg";
        ltBx_AsesoriasReg.Size = new System.Drawing.Size(1313, 484);
        ltBx_AsesoriasReg.TabIndex = 9;
        // 
        // txBx_ClubSigned
        // 
        txBx_ClubSigned.Enabled = false;
        txBx_ClubSigned.Location = new System.Drawing.Point(291, 315);
        txBx_ClubSigned.Name = "txBx_ClubSigned";
        txBx_ClubSigned.Size = new System.Drawing.Size(338, 39);
        txBx_ClubSigned.TabIndex = 8;
        // 
        // txBx_Password
        // 
        txBx_Password.Enabled = false;
        txBx_Password.Location = new System.Drawing.Point(291, 204);
        txBx_Password.Name = "txBx_Password";
        txBx_Password.Size = new System.Drawing.Size(432, 39);
        txBx_Password.TabIndex = 7;
        txBx_Password.UseSystemPasswordChar = true;
        // 
        // txBx_Email
        // 
        txBx_Email.Enabled = false;
        txBx_Email.Location = new System.Drawing.Point(291, 142);
        txBx_Email.Name = "txBx_Email";
        txBx_Email.Size = new System.Drawing.Size(432, 39);
        txBx_Email.TabIndex = 6;
        // 
        // txBx_FullName
        // 
        txBx_FullName.Enabled = false;
        txBx_FullName.Location = new System.Drawing.Point(291, 85);
        txBx_FullName.Name = "txBx_FullName";
        txBx_FullName.Size = new System.Drawing.Size(432, 39);
        txBx_FullName.TabIndex = 5;
        // 
        // lbl_profileAsesorias
        // 
        lbl_profileAsesorias.AutoSize = true;
        lbl_profileAsesorias.Location = new System.Drawing.Point(21, 381);
        lbl_profileAsesorias.Name = "lbl_profileAsesorias";
        lbl_profileAsesorias.Size = new System.Drawing.Size(251, 32);
        lbl_profileAsesorias.TabIndex = 4;
        lbl_profileAsesorias.Text = "Registro de Asesorías: ";
        // 
        // lbl_profileClubs
        // 
        lbl_profileClubs.AutoSize = true;
        lbl_profileClubs.Location = new System.Drawing.Point(113, 318);
        lbl_profileClubs.Name = "lbl_profileClubs";
        lbl_profileClubs.Size = new System.Drawing.Size(159, 32);
        lbl_profileClubs.TabIndex = 3;
        lbl_profileClubs.Text = "Club inscrito: ";
        // 
        // lbl_profilePassword
        // 
        lbl_profilePassword.AutoSize = true;
        lbl_profilePassword.Enabled = false;
        lbl_profilePassword.Location = new System.Drawing.Point(126, 204);
        lbl_profilePassword.Name = "lbl_profilePassword";
        lbl_profilePassword.Size = new System.Drawing.Size(146, 32);
        lbl_profilePassword.TabIndex = 2;
        lbl_profilePassword.Text = "Contraseña: ";
        // 
        // lbl_profileEmail
        // 
        lbl_profileEmail.AutoSize = true;
        lbl_profileEmail.Location = new System.Drawing.Point(50, 142);
        lbl_profileEmail.Name = "lbl_profileEmail";
        lbl_profileEmail.Size = new System.Drawing.Size(222, 32);
        lbl_profileEmail.TabIndex = 1;
        lbl_profileEmail.Text = "Correo Electrónico: ";
        // 
        // lbl_profileName
        // 
        lbl_profileName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
        lbl_profileName.AutoSize = true;
        lbl_profileName.Location = new System.Drawing.Point(53, 85);
        lbl_profileName.Name = "lbl_profileName";
        lbl_profileName.Size = new System.Drawing.Size(222, 32);
        lbl_profileName.TabIndex = 0;
        lbl_profileName.Text = "Nombre completo: ";
        // 
        // grBx_Usuario
        // 
        grBx_Usuario.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        grBx_Usuario.Controls.Add(btn_config);
        grBx_Usuario.Controls.Add(lbl_nameText);
        grBx_Usuario.Controls.Add(btn_signout);
        grBx_Usuario.Controls.Add(lbl_matrText);
        grBx_Usuario.Controls.Add(lbl_name);
        grBx_Usuario.Controls.Add(lbl_matr);
        grBx_Usuario.Location = new System.Drawing.Point(1429, 31);
        grBx_Usuario.Name = "grBx_Usuario";
        grBx_Usuario.Size = new System.Drawing.Size(372, 303);
        grBx_Usuario.TabIndex = 10;
        grBx_Usuario.TabStop = false;
        grBx_Usuario.Text = "Usuario";
        // 
        // btn_config
        // 
        btn_config.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_config.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_config.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_config.Location = new System.Drawing.Point(6, 211);
        btn_config.Name = "btn_config";
        btn_config.Size = new System.Drawing.Size(182, 84);
        btn_config.TabIndex = 4;
        btn_config.Text = "Entrar al Perfil";
        btn_config.UseVisualStyleBackColor = false;
        btn_config.Click += btn_config_Click;
        // 
        // lbl_nameText
        // 
        lbl_nameText.AutoSize = true;
        lbl_nameText.Location = new System.Drawing.Point(19, 99);
        lbl_nameText.Name = "lbl_nameText";
        lbl_nameText.Size = new System.Drawing.Size(82, 25);
        lbl_nameText.TabIndex = 3;
        lbl_nameText.Text = "Nombre:";
        // 
        // lbl_matrText
        // 
        lbl_matrText.AutoSize = true;
        lbl_matrText.Location = new System.Drawing.Point(19, 58);
        lbl_matrText.Name = "lbl_matrText";
        lbl_matrText.Size = new System.Drawing.Size(88, 25);
        lbl_matrText.TabIndex = 2;
        lbl_matrText.Text = "Matrícula:";
        // 
        // lbl_name
        // 
        lbl_name.AutoSize = true;
        lbl_name.Location = new System.Drawing.Point(107, 99);
        lbl_name.Name = "lbl_name";
        lbl_name.Size = new System.Drawing.Size(152, 25);
        lbl_name.TabIndex = 1;
        lbl_name.Text = "Nombre Genérico";
        // 
        // lbl_matr
        // 
        lbl_matr.AutoSize = true;
        lbl_matr.Location = new System.Drawing.Point(113, 58);
        lbl_matr.Name = "lbl_matr";
        lbl_matr.Size = new System.Drawing.Size(113, 25);
        lbl_matr.TabIndex = 0;
        lbl_matr.Text = "UTP0000000";
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.Location = new System.Drawing.Point(24, 952);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(300, 73);
        button1.TabIndex = 22;
        button1.Text = "Regresar";
        button1.UseVisualStyleBackColor = false;
        button1.Click += btn_regresar_Click;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        CancelButton = btn_signout;
        ClientSize = new System.Drawing.Size(1826, 1207);
        Controls.Add(grBx_Usuario);
        Controls.Add(tabControl);
        Text = "Menú Principal";
        tabControl.ResumeLayout(false);
        tabMainMenu.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tabAsesorias.ResumeLayout(false);
        grBx_Course.ResumeLayout(false);
        grBx_Course.PerformLayout();
        tabClubDeportivo.ResumeLayout(false);
        grBx_deportivos.ResumeLayout(false);
        tabClubCultural.ResumeLayout(false);
        grBx_culturales.ResumeLayout(false);
        tabUser.ResumeLayout(false);
        grBx_userConfig.ResumeLayout(false);
        grBx_userConfig.PerformLayout();
        grBx_Usuario.ResumeLayout(false);
        grBx_Usuario.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.DateTimePicker dateTP_asesoria;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_asesoriaRegresar;

    private System.Windows.Forms.GroupBox grBx_culturales;

    private System.Windows.Forms.GroupBox grBx_deportivos;

    private System.Windows.Forms.Button btn_unsignClub;

    private System.Windows.Forms.Button btn_deleteAcc;


    private System.Windows.Forms.Button btn_signout;

    #endregion
    private ToolStripLabel toolStripButton1;
    private ToolStripButton toolStripButton2;
    private System.Windows.Forms.TabControl tabControl;
    private TabPage tabMainMenu;
    private System.Windows.Forms.TabPage tabClubDeportivo;
    private TabPage tabUser;
    private GroupBox groupBox1;
    private Button btn_culturales;
    private Button btn_deportivos;
    private Label lbl_welcome;
    private Label lbl_asesorias;
    private Label lbl_clubes;
    private Button btn_asesorias;
    private Button btn_clubes;
    private TabPage tabAsesorias;
    private System.Windows.Forms.GroupBox grBx_Course;
    private System.Windows.Forms.Button btn_reservar;
    private System.Windows.Forms.ListBox ltBx_profesores;
    private System.Windows.Forms.ListBox ltBx_horarios;
    private System.Windows.Forms.ComboBox cmBx_Course;
    private System.Windows.Forms.Label lbl_prfsr;
    private System.Windows.Forms.Label lbl_asesoria;
    private System.Windows.Forms.TabPage tabClubCultural;
    private System.Windows.Forms.Button btn_regresar;
    private System.Windows.Forms.Button btn_ritmosLatinos;
    private System.Windows.Forms.Button btn_porristas;
    private System.Windows.Forms.Button btn_bandaGuerra;
    private System.Windows.Forms.Button btn_ajedrez;
    private System.Windows.Forms.Button btn_rondallaCanto;
    private System.Windows.Forms.Button btn_danzaFolk;
    private System.Windows.Forms.Button btn_regresarClubes;
    private System.Windows.Forms.Button btn_voleybol;
    private System.Windows.Forms.Button btn_beisbol;
    private System.Windows.Forms.Button btn_kendo;
    private System.Windows.Forms.Button btn_futbol;
    private System.Windows.Forms.Button btn_crossfit;
    private System.Windows.Forms.Button btn_karate;
    private System.Windows.Forms.Button btn_basquetbol;
    private System.Windows.Forms.Button btn_atletismo;
    private System.Windows.Forms.Button btn_defensaPersonal;
    private System.Windows.Forms.Button btn_taekwondo;
    private System.Windows.Forms.GroupBox grBx_userConfig;
    private GroupBox grBx_Usuario;
    private Label lbl_matr;
    private Label lbl_name;
    private Label lbl_nameText;
    private Label lbl_matrText;
    private Button btn_config;
    private System.Windows.Forms.Label lbl_profilePassword;
    private Label lbl_profileEmail;
    private Label lbl_profileName;
    private System.Windows.Forms.Label lbl_profileAsesorias;
    private System.Windows.Forms.Label lbl_profileClubs;
    private System.Windows.Forms.TextBox txBx_FullName;
    private System.Windows.Forms.TextBox txBx_Email;
    private ListBox ltBx_AsesoriasReg;
    private System.Windows.Forms.TextBox txBx_ClubSigned;
    private System.Windows.Forms.TextBox txBx_Password;
    private System.Windows.Forms.Button btn_changePass;
    private System.Windows.Forms.Button btn_showPass;
    private Label lbl_profID;
    private Label lbl_HorarioSel;
}