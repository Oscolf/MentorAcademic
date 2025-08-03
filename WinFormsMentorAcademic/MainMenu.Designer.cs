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
        btn_signout = new Button();
        tabControl = new TabControl();
        tabMainMenu = new TabPage();
        groupBox1 = new GroupBox();
        btn_culturales = new Button();
        btn_deportivos = new Button();
        lbl_welcome = new Label();
        lbl_asesorias = new Label();
        lbl_clubes = new Label();
        btn_asesorias = new Button();
        btn_clubes = new Button();
        tabAsesorias = new TabPage();
        grBx_Course = new GroupBox();
        lbl_HorarioSel = new Label();
        lbl_profID = new Label();
        btn_reservar = new Button();
        ltBx_profesores = new ListBox();
        ltBx_horarios = new ListBox();
        cmBx_Course = new ComboBox();
        lbl_prfsr = new Label();
        lbl_asesoria = new Label();
        tabClubDeportivo = new TabPage();
        btn_regresarClubes = new Button();
        btn_voleybol = new Button();
        btn_beisbol = new Button();
        btn_kendo = new Button();
        btn_futbol = new Button();
        btn_crossfit = new Button();
        btn_karate = new Button();
        btn_basquetbol = new Button();
        btn_atletismo = new Button();
        btn_defensaPersonal = new Button();
        btn_taekwondo = new Button();
        tabClubCultural = new TabPage();
        btn_regresar = new Button();
        btn_ritmosLatinos = new Button();
        btn_porristas = new Button();
        btn_bandaGuerra = new Button();
        btn_ajedrez = new Button();
        btn_rondallaCanto = new Button();
        btn_danzaFolk = new Button();
        tabUser = new TabPage();
        grBx_userConfig = new GroupBox();
        btn_changePass = new Button();
        btn_showPass = new Button();
        ltBx_AsesoriasReg = new ListBox();
        txBx_ClubSigned = new TextBox();
        txBx_Password = new TextBox();
        txBx_Email = new TextBox();
        txBx_FullName = new TextBox();
        lbl_profileAsesorias = new Label();
        lbl_profileClubs = new Label();
        lbl_profilePassword = new Label();
        lbl_profileEmail = new Label();
        lbl_profileName = new Label();
        grBx_Usuario = new GroupBox();
        btn_config = new Button();
        lbl_nameText = new Label();
        lbl_matrText = new Label();
        lbl_name = new Label();
        lbl_matr = new Label();
        tabControl.SuspendLayout();
        tabMainMenu.SuspendLayout();
        groupBox1.SuspendLayout();
        tabAsesorias.SuspendLayout();
        grBx_Course.SuspendLayout();
        tabClubDeportivo.SuspendLayout();
        tabClubCultural.SuspendLayout();
        tabUser.SuspendLayout();
        grBx_userConfig.SuspendLayout();
        grBx_Usuario.SuspendLayout();
        SuspendLayout();
        // 
        // btn_signout
        // 
        btn_signout.BackColor = Color.FromArgb(218, 241, 222);
        btn_signout.DialogResult = DialogResult.Cancel;
        btn_signout.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_signout.Location = new Point(194, 211);
        btn_signout.Name = "btn_signout";
        btn_signout.Size = new Size(172, 84);
        btn_signout.TabIndex = 2;
        btn_signout.Text = "Cerrar sesión";
        btn_signout.UseVisualStyleBackColor = false;
        btn_signout.Click += btn_signout_Click;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabMainMenu);
        tabControl.Controls.Add(tabAsesorias);
        tabControl.Controls.Add(tabClubDeportivo);
        tabControl.Controls.Add(tabClubCultural);
        tabControl.Controls.Add(tabUser);
        tabControl.Dock = DockStyle.Top;
        tabControl.Location = new Point(0, 0);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(1826, 1216);
        tabControl.TabIndex = 10;
        // 
        // tabMainMenu
        // 
        tabMainMenu.BackColor = Color.FromArgb(35, 83, 71);
        tabMainMenu.Controls.Add(groupBox1);
        tabMainMenu.Location = new Point(4, 34);
        tabMainMenu.Name = "tabMainMenu";
        tabMainMenu.Padding = new Padding(3);
        tabMainMenu.Size = new Size(1818, 1178);
        tabMainMenu.TabIndex = 0;
        tabMainMenu.Text = "Menú Principal";
        // 
        // groupBox1
        // 
        groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        groupBox1.BackColor = Color.FromArgb(142, 182, 155);
        groupBox1.Controls.Add(btn_culturales);
        groupBox1.Controls.Add(btn_deportivos);
        groupBox1.Controls.Add(lbl_welcome);
        groupBox1.Controls.Add(lbl_asesorias);
        groupBox1.Controls.Add(lbl_clubes);
        groupBox1.Controls.Add(btn_asesorias);
        groupBox1.Controls.Add(btn_clubes);
        groupBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        groupBox1.Location = new Point(17, 28);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(1361, 1077);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        groupBox1.Text = "Inicio";
        // 
        // btn_culturales
        // 
        btn_culturales.BackColor = Color.FromArgb(218, 241, 222);
        btn_culturales.Enabled = false;
        btn_culturales.Location = new Point(50, 312);
        btn_culturales.Name = "btn_culturales";
        btn_culturales.Size = new Size(550, 570);
        btn_culturales.TabIndex = 7;
        btn_culturales.Text = "Culturales";
        btn_culturales.UseVisualStyleBackColor = false;
        btn_culturales.Visible = false;
        btn_culturales.Click += btn_culturales_Click;
        // 
        // btn_deportivos
        // 
        btn_deportivos.BackColor = Color.FromArgb(218, 241, 222);
        btn_deportivos.Enabled = false;
        btn_deportivos.Location = new Point(703, 312);
        btn_deportivos.Name = "btn_deportivos";
        btn_deportivos.Size = new Size(550, 567);
        btn_deportivos.TabIndex = 6;
        btn_deportivos.Text = "Deportivos";
        btn_deportivos.UseVisualStyleBackColor = false;
        btn_deportivos.Visible = false;
        btn_deportivos.Click += btn_deportivos_Click;
        // 
        // lbl_welcome
        // 
        lbl_welcome.AutoSize = true;
        lbl_welcome.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbl_welcome.ForeColor = Color.FromArgb(22, 56, 50);
        lbl_welcome.Location = new Point(240, 51);
        lbl_welcome.Name = "lbl_welcome";
        lbl_welcome.RightToLeft = RightToLeft.Yes;
        lbl_welcome.Size = new Size(797, 54);
        lbl_welcome.TabIndex = 5;
        lbl_welcome.Text = "Bienvenid@ [usuario] Seleccione un servicio";
        lbl_welcome.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_asesorias
        // 
        lbl_asesorias.BackColor = Color.FromArgb(218, 241, 222);
        lbl_asesorias.Font = new Font("Segoe UI Semilight", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lbl_asesorias.Location = new Point(176, 552);
        lbl_asesorias.Name = "lbl_asesorias";
        lbl_asesorias.Size = new Size(292, 152);
        lbl_asesorias.TabIndex = 8;
        lbl_asesorias.Text = "Pide y organiza una asesoría con algún profesor";
        lbl_asesorias.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_clubes
        // 
        lbl_clubes.BackColor = Color.FromArgb(218, 241, 222);
        lbl_clubes.Font = new Font("Segoe UI Semilight", 16F, FontStyle.Italic, GraphicsUnit.Point, 0);
        lbl_clubes.Location = new Point(838, 574);
        lbl_clubes.Name = "lbl_clubes";
        lbl_clubes.Size = new Size(292, 152);
        lbl_clubes.TabIndex = 9;
        lbl_clubes.Text = "Infórmate y únete a alguna actividad cultural o deportiva";
        lbl_clubes.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btn_asesorias
        // 
        btn_asesorias.BackColor = Color.FromArgb(218, 241, 222);
        btn_asesorias.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_asesorias.Location = new Point(50, 260);
        btn_asesorias.Name = "btn_asesorias";
        btn_asesorias.Size = new Size(550, 660);
        btn_asesorias.TabIndex = 3;
        btn_asesorias.Text = "\r\n\r\nAsesorías\r\n";
        btn_asesorias.TextAlign = ContentAlignment.TopCenter;
        btn_asesorias.UseVisualStyleBackColor = false;
        btn_asesorias.Click += btn_asesorias_Click;
        // 
        // btn_clubes
        // 
        btn_clubes.BackColor = Color.FromArgb(218, 241, 222);
        btn_clubes.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_clubes.Location = new Point(703, 253);
        btn_clubes.Name = "btn_clubes";
        btn_clubes.Size = new Size(550, 660);
        btn_clubes.TabIndex = 4;
        btn_clubes.Text = "\r\n\r\nInscribirte a un club";
        btn_clubes.TextAlign = ContentAlignment.TopCenter;
        btn_clubes.UseVisualStyleBackColor = false;
        btn_clubes.Click += btn_clubes_Click;
        // 
        // tabAsesorias
        // 
        tabAsesorias.BackColor = Color.FromArgb(35, 83, 71);
        tabAsesorias.Controls.Add(grBx_Course);
        tabAsesorias.Location = new Point(4, 34);
        tabAsesorias.Name = "tabAsesorias";
        tabAsesorias.Padding = new Padding(3);
        tabAsesorias.Size = new Size(1818, 1178);
        tabAsesorias.TabIndex = 1;
        tabAsesorias.Text = "Programar Asesorías";
        // 
        // grBx_Course
        // 
        grBx_Course.BackColor = Color.FromArgb(142, 182, 155);
        grBx_Course.Controls.Add(lbl_HorarioSel);
        grBx_Course.Controls.Add(lbl_profID);
        grBx_Course.Controls.Add(btn_reservar);
        grBx_Course.Controls.Add(ltBx_profesores);
        grBx_Course.Controls.Add(ltBx_horarios);
        grBx_Course.Controls.Add(cmBx_Course);
        grBx_Course.Controls.Add(lbl_prfsr);
        grBx_Course.Controls.Add(lbl_asesoria);
        grBx_Course.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        grBx_Course.Location = new Point(23, 24);
        grBx_Course.Name = "grBx_Course";
        grBx_Course.Size = new Size(1293, 1080);
        grBx_Course.TabIndex = 6;
        grBx_Course.TabStop = false;
        grBx_Course.Text = "Seleccione una materia";
        // 
        // lbl_HorarioSel
        // 
        lbl_HorarioSel.AutoSize = true;
        lbl_HorarioSel.Location = new Point(1068, 131);
        lbl_HorarioSel.Name = "lbl_HorarioSel";
        lbl_HorarioSel.Size = new Size(143, 38);
        lbl_HorarioSel.TabIndex = 9;
        lbl_HorarioSel.Text = "horarioSel";
        lbl_HorarioSel.Visible = false;
        // 
        // lbl_profID
        // 
        lbl_profID.AutoSize = true;
        lbl_profID.Location = new Point(488, 123);
        lbl_profID.Name = "lbl_profID";
        lbl_profID.Size = new Size(95, 38);
        lbl_profID.TabIndex = 8;
        lbl_profID.Text = "profID";
        lbl_profID.Visible = false;
        // 
        // btn_reservar
        // 
        btn_reservar.BackColor = Color.FromArgb(218, 241, 222);
        btn_reservar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_reservar.Location = new Point(1052, 942);
        btn_reservar.Name = "btn_reservar";
        btn_reservar.Size = new Size(177, 69);
        btn_reservar.TabIndex = 7;
        btn_reservar.Text = "Reservar";
        btn_reservar.UseVisualStyleBackColor = false;
        btn_reservar.Click += btn_reservar_Click;
        // 
        // ltBx_profesores
        // 
        ltBx_profesores.BackColor = Color.FromArgb(218, 241, 222);
        ltBx_profesores.FormattingEnabled = true;
        ltBx_profesores.Location = new Point(9, 172);
        ltBx_profesores.Name = "ltBx_profesores";
        ltBx_profesores.Size = new Size(574, 764);
        ltBx_profesores.TabIndex = 6;
        ltBx_profesores.SelectedIndexChanged += ltBx_profesores_SelectedIndexChanged;
        // 
        // ltBx_horarios
        // 
        ltBx_horarios.BackColor = Color.FromArgb(218, 241, 222);
        ltBx_horarios.FormattingEnabled = true;
        ltBx_horarios.Location = new Point(623, 172);
        ltBx_horarios.Name = "ltBx_horarios";
        ltBx_horarios.Size = new Size(572, 764);
        ltBx_horarios.TabIndex = 5;
        // 
        // cmBx_Course
        // 
        cmBx_Course.BackColor = Color.FromArgb(218, 241, 222);
        cmBx_Course.FormattingEnabled = true;
        cmBx_Course.Items.AddRange(new object[] { "Base de Datos", "Calculo integral", "Desarrollo Del Pensamiento Y Toma De Decisiones", "Inglés III", "Programacion Orientada a Objetos", "Proyecto Integrador I", "Tópicos De Calidad Para El Diseño De Software" });
        cmBx_Course.Location = new Point(6, 45);
        cmBx_Course.Name = "cmBx_Course";
        cmBx_Course.Size = new Size(282, 46);
        cmBx_Course.TabIndex = 4;
        cmBx_Course.SelectedIndexChanged += cmBx_Course_SelectedIndexChanged;
        // 
        // lbl_prfsr
        // 
        lbl_prfsr.Location = new Point(9, 123);
        lbl_prfsr.Name = "lbl_prfsr";
        lbl_prfsr.Size = new Size(161, 35);
        lbl_prfsr.TabIndex = 1;
        lbl_prfsr.Text = "Profesor/a";
        // 
        // lbl_asesoria
        // 
        lbl_asesoria.Location = new Point(614, 123);
        lbl_asesoria.Name = "lbl_asesoria";
        lbl_asesoria.Size = new Size(266, 35);
        lbl_asesoria.TabIndex = 0;
        lbl_asesoria.Text = "Horarios disponibles";
        // 
        // tabClubDeportivo
        // 
        tabClubDeportivo.BackColor = Color.FromArgb(35, 83, 71);
        tabClubDeportivo.Controls.Add(btn_regresarClubes);
        tabClubDeportivo.Controls.Add(btn_voleybol);
        tabClubDeportivo.Controls.Add(btn_beisbol);
        tabClubDeportivo.Controls.Add(btn_kendo);
        tabClubDeportivo.Controls.Add(btn_futbol);
        tabClubDeportivo.Controls.Add(btn_crossfit);
        tabClubDeportivo.Controls.Add(btn_karate);
        tabClubDeportivo.Controls.Add(btn_basquetbol);
        tabClubDeportivo.Controls.Add(btn_atletismo);
        tabClubDeportivo.Controls.Add(btn_defensaPersonal);
        tabClubDeportivo.Controls.Add(btn_taekwondo);
        tabClubDeportivo.Location = new Point(4, 34);
        tabClubDeportivo.Name = "tabClubDeportivo";
        tabClubDeportivo.Size = new Size(1818, 1178);
        tabClubDeportivo.TabIndex = 2;
        tabClubDeportivo.Text = "Inscribirse a un Club Deportivo";
        // 
        // btn_regresarClubes
        // 
        btn_regresarClubes.BackColor = Color.FromArgb(218, 241, 222);
        btn_regresarClubes.DialogResult = DialogResult.Cancel;
        btn_regresarClubes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_regresarClubes.Location = new Point(946, 863);
        btn_regresarClubes.Name = "btn_regresarClubes";
        btn_regresarClubes.Size = new Size(300, 100);
        btn_regresarClubes.TabIndex = 21;
        btn_regresarClubes.Text = "Regresar";
        btn_regresarClubes.UseVisualStyleBackColor = false;
        btn_regresarClubes.Click += btn_regresarClubes_Click;
        // 
        // btn_voleybol
        // 
        btn_voleybol.BackgroundImage = Fondos.voleybol;
        btn_voleybol.BackgroundImageLayout = ImageLayout.Stretch;
        btn_voleybol.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_voleybol.ForeColor = SystemColors.ButtonHighlight;
        btn_voleybol.Location = new Point(339, 663);
        btn_voleybol.Name = "btn_voleybol";
        btn_voleybol.Size = new Size(300, 300);
        btn_voleybol.TabIndex = 20;
        btn_voleybol.Text = "Voleybol";
        btn_voleybol.UseVisualStyleBackColor = true;
        btn_voleybol.Click += btn_voleybol_Click;
        // 
        // btn_beisbol
        // 
        btn_beisbol.BackgroundImage = Fondos.beisbol;
        btn_beisbol.BackgroundImageLayout = ImageLayout.Stretch;
        btn_beisbol.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_beisbol.ForeColor = SystemColors.ButtonHighlight;
        btn_beisbol.Location = new Point(645, 51);
        btn_beisbol.Name = "btn_beisbol";
        btn_beisbol.Size = new Size(300, 300);
        btn_beisbol.TabIndex = 19;
        btn_beisbol.Text = "Beisbol";
        btn_beisbol.UseVisualStyleBackColor = true;
        btn_beisbol.Click += btn_beisbol_Click;
        // 
        // btn_kendo
        // 
        btn_kendo.BackgroundImage = Fondos.kendo;
        btn_kendo.BackgroundImageLayout = ImageLayout.Stretch;
        btn_kendo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_kendo.ForeColor = SystemColors.ButtonHighlight;
        btn_kendo.Location = new Point(946, 357);
        btn_kendo.Name = "btn_kendo";
        btn_kendo.Size = new Size(300, 300);
        btn_kendo.TabIndex = 18;
        btn_kendo.Text = "Kendo";
        btn_kendo.UseVisualStyleBackColor = true;
        btn_kendo.Click += btn_kendo_Click;
        // 
        // btn_futbol
        // 
        btn_futbol.BackgroundImage = Fondos.futbol;
        btn_futbol.BackgroundImageLayout = ImageLayout.Stretch;
        btn_futbol.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_futbol.ForeColor = SystemColors.ButtonHighlight;
        btn_futbol.Location = new Point(339, 357);
        btn_futbol.Name = "btn_futbol";
        btn_futbol.Size = new Size(300, 300);
        btn_futbol.TabIndex = 17;
        btn_futbol.Text = "Futbol";
        btn_futbol.UseVisualStyleBackColor = true;
        btn_futbol.Click += btn_futbol_Click;
        // 
        // btn_crossfit
        // 
        btn_crossfit.BackgroundImage = Fondos.crossfit;
        btn_crossfit.BackgroundImageLayout = ImageLayout.Stretch;
        btn_crossfit.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_crossfit.ForeColor = SystemColors.ButtonHighlight;
        btn_crossfit.Location = new Point(951, 51);
        btn_crossfit.Name = "btn_crossfit";
        btn_crossfit.Size = new Size(300, 300);
        btn_crossfit.TabIndex = 16;
        btn_crossfit.Text = "Crossfit";
        btn_crossfit.UseVisualStyleBackColor = true;
        btn_crossfit.Click += btn_crossfit_Click;
        // 
        // btn_karate
        // 
        btn_karate.BackgroundImage = Fondos.karate;
        btn_karate.BackgroundImageLayout = ImageLayout.Stretch;
        btn_karate.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_karate.ForeColor = SystemColors.ButtonHighlight;
        btn_karate.Location = new Point(645, 357);
        btn_karate.Name = "btn_karate";
        btn_karate.Size = new Size(300, 300);
        btn_karate.TabIndex = 14;
        btn_karate.Text = "Karate";
        btn_karate.UseVisualStyleBackColor = true;
        btn_karate.Click += btn_karate_Click;
        // 
        // btn_basquetbol
        // 
        btn_basquetbol.BackgroundImage = Fondos.basquetbol;
        btn_basquetbol.BackgroundImageLayout = ImageLayout.Stretch;
        btn_basquetbol.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_basquetbol.ForeColor = SystemColors.ButtonHighlight;
        btn_basquetbol.Location = new Point(339, 51);
        btn_basquetbol.Name = "btn_basquetbol";
        btn_basquetbol.Size = new Size(300, 300);
        btn_basquetbol.TabIndex = 13;
        btn_basquetbol.Text = "Basquetbol";
        btn_basquetbol.UseVisualStyleBackColor = true;
        btn_basquetbol.Click += btn_basquetbol_Click;
        // 
        // btn_atletismo
        // 
        btn_atletismo.BackgroundImage = Fondos.atletismo;
        btn_atletismo.BackgroundImageLayout = ImageLayout.Stretch;
        btn_atletismo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_atletismo.ForeColor = SystemColors.ButtonHighlight;
        btn_atletismo.Location = new Point(33, 51);
        btn_atletismo.Name = "btn_atletismo";
        btn_atletismo.Size = new Size(300, 300);
        btn_atletismo.TabIndex = 12;
        btn_atletismo.Text = "Atletísmo";
        btn_atletismo.UseVisualStyleBackColor = true;
        btn_atletismo.Click += btn_atletismo_Click;
        // 
        // btn_defensaPersonal
        // 
        btn_defensaPersonal.BackgroundImage = Fondos.defensa_personal;
        btn_defensaPersonal.BackgroundImageLayout = ImageLayout.Stretch;
        btn_defensaPersonal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_defensaPersonal.ForeColor = SystemColors.ButtonHighlight;
        btn_defensaPersonal.Location = new Point(33, 357);
        btn_defensaPersonal.Name = "btn_defensaPersonal";
        btn_defensaPersonal.Size = new Size(300, 300);
        btn_defensaPersonal.TabIndex = 15;
        btn_defensaPersonal.Text = "Defensa personal";
        btn_defensaPersonal.UseVisualStyleBackColor = true;
        btn_defensaPersonal.Click += btn_defensaPersonal_Click;
        // 
        // btn_taekwondo
        // 
        btn_taekwondo.BackgroundImage = Fondos.danza_folklorica;
        btn_taekwondo.BackgroundImageLayout = ImageLayout.Stretch;
        btn_taekwondo.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_taekwondo.ForeColor = SystemColors.ButtonHighlight;
        btn_taekwondo.Location = new Point(33, 663);
        btn_taekwondo.Name = "btn_taekwondo";
        btn_taekwondo.Size = new Size(300, 300);
        btn_taekwondo.TabIndex = 11;
        btn_taekwondo.Text = "Tae-kwon-do";
        btn_taekwondo.UseVisualStyleBackColor = true;
        btn_taekwondo.Click += btn_taekwondo_Click;
        // 
        // tabClubCultural
        // 
        tabClubCultural.BackColor = Color.FromArgb(35, 83, 71);
        tabClubCultural.Controls.Add(btn_regresar);
        tabClubCultural.Controls.Add(btn_ritmosLatinos);
        tabClubCultural.Controls.Add(btn_porristas);
        tabClubCultural.Controls.Add(btn_bandaGuerra);
        tabClubCultural.Controls.Add(btn_ajedrez);
        tabClubCultural.Controls.Add(btn_rondallaCanto);
        tabClubCultural.Controls.Add(btn_danzaFolk);
        tabClubCultural.Location = new Point(4, 34);
        tabClubCultural.Name = "tabClubCultural";
        tabClubCultural.Size = new Size(1818, 1178);
        tabClubCultural.TabIndex = 4;
        tabClubCultural.Text = "Inscribirse a un club cultural";
        // 
        // btn_regresar
        // 
        btn_regresar.BackColor = Color.FromArgb(218, 241, 222);
        btn_regresar.DialogResult = DialogResult.Cancel;
        btn_regresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_regresar.Location = new Point(940, 850);
        btn_regresar.Name = "btn_regresar";
        btn_regresar.Size = new Size(300, 100);
        btn_regresar.TabIndex = 13;
        btn_regresar.Text = "Regresar";
        btn_regresar.UseVisualStyleBackColor = false;
        btn_regresar.Visible = false;
        // 
        // btn_ritmosLatinos
        // 
        btn_ritmosLatinos.BackColor = Color.Black;
        btn_ritmosLatinos.BackgroundImage = Fondos.ritmos_latinos;
        btn_ritmosLatinos.BackgroundImageLayout = ImageLayout.Stretch;
        btn_ritmosLatinos.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_ritmosLatinos.ForeColor = SystemColors.ButtonHighlight;
        btn_ritmosLatinos.Location = new Point(840, 358);
        btn_ritmosLatinos.Name = "btn_ritmosLatinos";
        btn_ritmosLatinos.Size = new Size(400, 300);
        btn_ritmosLatinos.TabIndex = 12;
        btn_ritmosLatinos.Text = "Ritmos Latinos";
        btn_ritmosLatinos.UseVisualStyleBackColor = false;
        btn_ritmosLatinos.Click += btn_ritmosLatinos_Click;
        // 
        // btn_porristas
        // 
        btn_porristas.BackColor = Color.Black;
        btn_porristas.BackgroundImage = Fondos.porristas;
        btn_porristas.BackgroundImageLayout = ImageLayout.Stretch;
        btn_porristas.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_porristas.ForeColor = SystemColors.ButtonHighlight;
        btn_porristas.Location = new Point(28, 358);
        btn_porristas.Name = "btn_porristas";
        btn_porristas.Size = new Size(400, 300);
        btn_porristas.TabIndex = 10;
        btn_porristas.Text = "Porristas";
        btn_porristas.UseVisualStyleBackColor = false;
        btn_porristas.Click += btn_porristas_Click;
        // 
        // btn_bandaGuerra
        // 
        btn_bandaGuerra.BackColor = Color.Black;
        btn_bandaGuerra.BackgroundImage = Fondos.minion_tarolero;
        btn_bandaGuerra.BackgroundImageLayout = ImageLayout.Stretch;
        btn_bandaGuerra.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_bandaGuerra.ForeColor = SystemColors.ButtonHighlight;
        btn_bandaGuerra.Location = new Point(434, 52);
        btn_bandaGuerra.Name = "btn_bandaGuerra";
        btn_bandaGuerra.Size = new Size(400, 300);
        btn_bandaGuerra.TabIndex = 9;
        btn_bandaGuerra.Text = "Banda de guerra";
        btn_bandaGuerra.UseVisualStyleBackColor = false;
        btn_bandaGuerra.Click += btn_bandaGuerra_Click;
        // 
        // btn_ajedrez
        // 
        btn_ajedrez.BackColor = Color.Black;
        btn_ajedrez.BackgroundImage = Fondos.ajedrez;
        btn_ajedrez.BackgroundImageLayout = ImageLayout.Stretch;
        btn_ajedrez.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_ajedrez.ForeColor = SystemColors.ButtonHighlight;
        btn_ajedrez.Location = new Point(28, 52);
        btn_ajedrez.Name = "btn_ajedrez";
        btn_ajedrez.Size = new Size(400, 300);
        btn_ajedrez.TabIndex = 8;
        btn_ajedrez.Text = "Ajedrez";
        btn_ajedrez.UseVisualStyleBackColor = false;
        btn_ajedrez.Click += btn_ajedrez_Click;
        // 
        // btn_rondallaCanto
        // 
        btn_rondallaCanto.BackColor = Color.Black;
        btn_rondallaCanto.BackgroundImage = Fondos.rondalla_y_canto;
        btn_rondallaCanto.BackgroundImageLayout = ImageLayout.Stretch;
        btn_rondallaCanto.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_rondallaCanto.ForeColor = SystemColors.ButtonHighlight;
        btn_rondallaCanto.Location = new Point(434, 358);
        btn_rondallaCanto.Name = "btn_rondallaCanto";
        btn_rondallaCanto.Size = new Size(400, 300);
        btn_rondallaCanto.TabIndex = 11;
        btn_rondallaCanto.Text = "Rondalla y canto";
        btn_rondallaCanto.UseVisualStyleBackColor = false;
        btn_rondallaCanto.Click += btn_rondallaCanto_Click;
        // 
        // btn_danzaFolk
        // 
        btn_danzaFolk.BackColor = Color.Black;
        btn_danzaFolk.BackgroundImage = Fondos.danza_folklorica;
        btn_danzaFolk.BackgroundImageLayout = ImageLayout.Stretch;
        btn_danzaFolk.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_danzaFolk.ForeColor = SystemColors.ButtonHighlight;
        btn_danzaFolk.Location = new Point(840, 52);
        btn_danzaFolk.Name = "btn_danzaFolk";
        btn_danzaFolk.Size = new Size(400, 300);
        btn_danzaFolk.TabIndex = 7;
        btn_danzaFolk.Text = "Danza Folklórica";
        btn_danzaFolk.UseVisualStyleBackColor = false;
        btn_danzaFolk.Click += btn_danzaFolk_Click;
        // 
        // tabUser
        // 
        tabUser.BackColor = Color.FromArgb(35, 83, 71);
        tabUser.Controls.Add(grBx_userConfig);
        tabUser.Location = new Point(4, 34);
        tabUser.Name = "tabUser";
        tabUser.Size = new Size(1818, 1178);
        tabUser.TabIndex = 3;
        tabUser.Text = "Configuración de Usuario";
        // 
        // grBx_userConfig
        // 
        grBx_userConfig.BackColor = Color.FromArgb(142, 182, 155);
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
        grBx_userConfig.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        grBx_userConfig.Location = new Point(25, 36);
        grBx_userConfig.Name = "grBx_userConfig";
        grBx_userConfig.Size = new Size(1381, 1034);
        grBx_userConfig.TabIndex = 3;
        grBx_userConfig.TabStop = false;
        grBx_userConfig.Text = "Perfil de Usuario";
        // 
        // btn_changePass
        // 
        btn_changePass.Location = new Point(537, 242);
        btn_changePass.Name = "btn_changePass";
        btn_changePass.Size = new Size(186, 42);
        btn_changePass.TabIndex = 11;
        btn_changePass.Text = "Modificar";
        btn_changePass.UseVisualStyleBackColor = true;
        // 
        // btn_showPass
        // 
        btn_showPass.Location = new Point(291, 242);
        btn_showPass.Name = "btn_showPass";
        btn_showPass.Size = new Size(240, 42);
        btn_showPass.TabIndex = 10;
        btn_showPass.Text = "Mostrar contraseña";
        btn_showPass.UseVisualStyleBackColor = true;
        btn_showPass.Click += btn_showPass_Click;
        // 
        // ltBx_AsesoriasReg
        // 
        ltBx_AsesoriasReg.FormattingEnabled = true;
        ltBx_AsesoriasReg.Location = new Point(24, 435);
        ltBx_AsesoriasReg.Name = "ltBx_AsesoriasReg";
        ltBx_AsesoriasReg.Size = new Size(1313, 484);
        ltBx_AsesoriasReg.TabIndex = 9;
        // 
        // txBx_ClubSigned
        // 
        txBx_ClubSigned.Location = new Point(291, 303);
        txBx_ClubSigned.Name = "txBx_ClubSigned";
        txBx_ClubSigned.Size = new Size(338, 39);
        txBx_ClubSigned.TabIndex = 8;
        // 
        // txBx_Password
        // 
        txBx_Password.Location = new Point(291, 197);
        txBx_Password.Name = "txBx_Password";
        txBx_Password.Size = new Size(432, 39);
        txBx_Password.TabIndex = 7;
        txBx_Password.UseSystemPasswordChar = true;
        // 
        // txBx_Email
        // 
        txBx_Email.Location = new Point(291, 142);
        txBx_Email.Name = "txBx_Email";
        txBx_Email.Size = new Size(432, 39);
        txBx_Email.TabIndex = 6;
        // 
        // txBx_FullName
        // 
        txBx_FullName.Location = new Point(291, 85);
        txBx_FullName.Name = "txBx_FullName";
        txBx_FullName.Size = new Size(605, 39);
        txBx_FullName.TabIndex = 5;
        // 
        // lbl_profileAsesorias
        // 
        lbl_profileAsesorias.AutoSize = true;
        lbl_profileAsesorias.Location = new Point(24, 377);
        lbl_profileAsesorias.Name = "lbl_profileAsesorias";
        lbl_profileAsesorias.Size = new Size(251, 32);
        lbl_profileAsesorias.TabIndex = 4;
        lbl_profileAsesorias.Text = "Registro de Asesorías: ";
        // 
        // lbl_profileClubs
        // 
        lbl_profileClubs.AutoSize = true;
        lbl_profileClubs.Location = new Point(113, 306);
        lbl_profileClubs.Name = "lbl_profileClubs";
        lbl_profileClubs.Size = new Size(159, 32);
        lbl_profileClubs.TabIndex = 3;
        lbl_profileClubs.Text = "Club inscrito: ";
        // 
        // lbl_profilePassword
        // 
        lbl_profilePassword.AutoSize = true;
        lbl_profilePassword.Location = new Point(126, 197);
        lbl_profilePassword.Name = "lbl_profilePassword";
        lbl_profilePassword.Size = new Size(146, 32);
        lbl_profilePassword.TabIndex = 2;
        lbl_profilePassword.Text = "Contraseña: ";
        // 
        // lbl_profileEmail
        // 
        lbl_profileEmail.AutoSize = true;
        lbl_profileEmail.Location = new Point(50, 142);
        lbl_profileEmail.Name = "lbl_profileEmail";
        lbl_profileEmail.Size = new Size(222, 32);
        lbl_profileEmail.TabIndex = 1;
        lbl_profileEmail.Text = "Correo Electrónico: ";
        // 
        // lbl_profileName
        // 
        lbl_profileName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        lbl_profileName.AutoSize = true;
        lbl_profileName.Location = new Point(53, 85);
        lbl_profileName.Name = "lbl_profileName";
        lbl_profileName.Size = new Size(222, 32);
        lbl_profileName.TabIndex = 0;
        lbl_profileName.Text = "Nombre completo: ";
        // 
        // grBx_Usuario
        // 
        grBx_Usuario.BackColor = Color.FromArgb(142, 182, 155);
        grBx_Usuario.Controls.Add(btn_config);
        grBx_Usuario.Controls.Add(lbl_nameText);
        grBx_Usuario.Controls.Add(btn_signout);
        grBx_Usuario.Controls.Add(lbl_matrText);
        grBx_Usuario.Controls.Add(lbl_name);
        grBx_Usuario.Controls.Add(lbl_matr);
        grBx_Usuario.Location = new Point(1429, 31);
        grBx_Usuario.Name = "grBx_Usuario";
        grBx_Usuario.Size = new Size(372, 303);
        grBx_Usuario.TabIndex = 10;
        grBx_Usuario.TabStop = false;
        grBx_Usuario.Text = "Usuario";
        // 
        // btn_config
        // 
        btn_config.BackColor = Color.FromArgb(218, 241, 222);
        btn_config.DialogResult = DialogResult.Cancel;
        btn_config.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_config.Location = new Point(6, 211);
        btn_config.Name = "btn_config";
        btn_config.Size = new Size(182, 84);
        btn_config.TabIndex = 4;
        btn_config.Text = "Entrar al Perfil";
        btn_config.UseVisualStyleBackColor = false;
        btn_config.Click += btn_config_Click;
        // 
        // lbl_nameText
        // 
        lbl_nameText.AutoSize = true;
        lbl_nameText.Location = new Point(19, 99);
        lbl_nameText.Name = "lbl_nameText";
        lbl_nameText.Size = new Size(82, 25);
        lbl_nameText.TabIndex = 3;
        lbl_nameText.Text = "Nombre:";
        // 
        // lbl_matrText
        // 
        lbl_matrText.AutoSize = true;
        lbl_matrText.Location = new Point(19, 58);
        lbl_matrText.Name = "lbl_matrText";
        lbl_matrText.Size = new Size(88, 25);
        lbl_matrText.TabIndex = 2;
        lbl_matrText.Text = "Matrícula:";
        // 
        // lbl_name
        // 
        lbl_name.AutoSize = true;
        lbl_name.Location = new Point(107, 99);
        lbl_name.Name = "lbl_name";
        lbl_name.Size = new Size(152, 25);
        lbl_name.TabIndex = 1;
        lbl_name.Text = "Nombre Genérico";
        // 
        // lbl_matr
        // 
        lbl_matr.AutoSize = true;
        lbl_matr.Location = new Point(113, 58);
        lbl_matr.Name = "lbl_matr";
        lbl_matr.Size = new Size(113, 25);
        lbl_matr.TabIndex = 0;
        lbl_matr.Text = "UTP0000000";
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(35, 83, 71);
        CancelButton = btn_signout;
        ClientSize = new Size(1826, 1207);
        Controls.Add(grBx_Usuario);
        Controls.Add(tabControl);
        Name = "MainMenu";
        Text = "Menú Principal";
        tabControl.ResumeLayout(false);
        tabMainMenu.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tabAsesorias.ResumeLayout(false);
        grBx_Course.ResumeLayout(false);
        grBx_Course.PerformLayout();
        tabClubDeportivo.ResumeLayout(false);
        tabClubCultural.ResumeLayout(false);
        tabUser.ResumeLayout(false);
        grBx_userConfig.ResumeLayout(false);
        grBx_userConfig.PerformLayout();
        grBx_Usuario.ResumeLayout(false);
        grBx_Usuario.PerformLayout();
        ResumeLayout(false);
    }


    private System.Windows.Forms.Button btn_signout;

    #endregion
    private ToolStripLabel toolStripButton1;
    private ToolStripButton toolStripButton2;
    private System.Windows.Forms.TabControl tabControl;
    private TabPage tabMainMenu;
    private TabPage tabClubDeportivo;
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
    private GroupBox grBx_Course;
    private Button btn_reservar;
    private ListBox ltBx_profesores;
    private ListBox ltBx_horarios;
    private System.Windows.Forms.ComboBox cmBx_Course;
    private System.Windows.Forms.Label lbl_prfsr;
    private System.Windows.Forms.Label lbl_asesoria;
    private TabPage tabClubCultural;
    private Button btn_regresar;
    private Button btn_ritmosLatinos;
    private Button btn_porristas;
    private Button btn_bandaGuerra;
    private Button btn_ajedrez;
    private Button btn_rondallaCanto;
    private Button btn_danzaFolk;
    private Button btn_regresarClubes;
    private Button btn_voleybol;
    private Button btn_beisbol;
    private Button btn_kendo;
    private Button btn_futbol;
    private Button btn_crossfit;
    private Button btn_karate;
    private Button btn_basquetbol;
    private Button btn_atletismo;
    private Button btn_defensaPersonal;
    private Button btn_taekwondo;
    private GroupBox grBx_userConfig;
    private GroupBox grBx_Usuario;
    private Label lbl_matr;
    private Label lbl_name;
    private Label lbl_nameText;
    private Label lbl_matrText;
    private Button btn_config;
    private Label lbl_profilePassword;
    private Label lbl_profileEmail;
    private Label lbl_profileName;
    private Label lbl_profileAsesorias;
    private Label lbl_profileClubs;
    private TextBox txBx_FullName;
    private TextBox txBx_Email;
    private ListBox ltBx_AsesoriasReg;
    private TextBox txBx_ClubSigned;
    private TextBox txBx_Password;
    private Button btn_changePass;
    private Button btn_showPass;
    private Label lbl_profID;
    private Label lbl_HorarioSel;
}