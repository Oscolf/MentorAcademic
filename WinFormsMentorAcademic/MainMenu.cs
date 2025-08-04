using MySql.Data.MySqlClient;
using SQLqueries;
namespace WinFormsMentorAcademic;
public partial class MainMenu : Form

{
    public MainMenu(User user)
    {
        InitializeComponent();
        lbl_name.Text = user.NombreCompleto;
        lbl_matr.Text = user.Matricula;
        lbl_welcome.Text = $"Bienvenid@ {user.NombreCompleto} \n Seleccione el servicio que desea utilizar";
    }

    private readonly string _connectionString = "server=localhost;port=3306;uid=root;database=mentoracademic;sslmode=none";

    private void btn_signout_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    private void btn_regresar_Click(object sender, EventArgs e)
    {
        tabControl.SelectedIndex = 0;

        btn_asesorias.Visible = true; btn_clubes.Visible = true;
        lbl_asesorias.Visible = true; lbl_clubes.Visible = true;

        btn_culturales.Visible = false; btn_culturales.Enabled = false;
        btn_deportivos.Visible = false; btn_deportivos.Enabled = false;

        lbl_welcome.Text = $"Bienvenid@ {lbl_name.Text}\n Seleccione el servicio que desea utilizar";
    }
    
    private void btn_config_Click(object sender, EventArgs e)
    {
        ltBx_AsesoriasReg.Items.Clear();
        
        SqlQueries configQueries = new SqlQueries(_connectionString);

        string cmd = "SELECT alumnos.* , clubes.nombre AS club_nombre " +
                     "FROM alumnos LEFT JOIN clubes ON alumnos.club_pertenece = clubes.idClub " +
                     $"WHERE matricula = '{lbl_matr.Text}';";

        MySqlDataReader alumnoReader = configQueries.ExecuteReader(cmd);

        alumnoReader.Read();

        txBx_FullName.Text = $"{alumnoReader["nombre"]} {alumnoReader["apellido"]}";
        txBx_Email.Text = alumnoReader["email"].ToString();
        txBx_Password.Text = alumnoReader["contasena"].ToString();
        txBx_ClubSigned.Text = alumnoReader["club_nombre"].ToString();

        alumnoReader.Dispose();

        cmd = "SELECT asesorias.estado, asesorias.fecha, asesorias.hora, profesores.nombre, profesores.apellido " +
              "FROM asesorias JOIN profesores JOIN alumnos " +
              "ON asesorias.idAlumno = alumnos.matricula AND asesorias.idProfesor = profesores.idProfesor " +
              $"WHERE asesorias.idAlumno = '{lbl_matr.Text}';";

        MySqlDataReader asesoriaReader = configQueries.ExecuteReader(cmd);

        while (asesoriaReader.Read())
        {
            ltBx_AsesoriasReg.Items.Add(
                $"Estado: {asesoriaReader["estado"]} >> {Convert.ToDateTime(asesoriaReader["fecha"]):yyyy-MM-dd} a las {asesoriaReader["hora"]} hrs | " +
                $"Impartida por: {asesoriaReader["nombre"]} {asesoriaReader["apellido"]}\n\n");
        }

        asesoriaReader.Dispose();
        configQueries.Get_Connection().Close();

        tabControl.SelectedIndex = 4;
    }

    //empieza tab principal

    private void btn_asesorias_Click(object sender, EventArgs e)
    {
        tabControl.SelectedIndex = 1;
    }

    private void btn_clubes_Click(object sender, EventArgs e)
    {
        btn_asesorias.Visible = false;
        btn_clubes.Visible = false;

        lbl_asesorias.Visible = false;
        lbl_clubes.Visible = false;

        btn_culturales.Visible = true; btn_culturales.Enabled = true;
        btn_deportivos.Visible = true; btn_deportivos.Enabled = true;

        lbl_welcome.Text = "Seleccione a qué tipo de club desea pertenecer";
    }

    private void btn_deportivos_Click(object sender, EventArgs e)
    {
        tabControl.SelectedIndex = 2;
    }

    private void btn_culturales_Click(object sender, EventArgs e)
    {
        tabControl.SelectedIndex = 3;
    }

    //termina tab principal

    //empieza tab asesorias
    
    List<int> _profIDs = new List<int>();
    List<string> _horarios = new List<string>();
    private void cmBx_Course_SelectedIndexChanged(object sender, EventArgs e)
    {
        ltBx_horarios.Items.Clear();    _horarios.Clear();
        ltBx_profesores.Items.Clear();  _profIDs.Clear();

        SqlQueries asesoriaQueries = new SqlQueries(_connectionString);

        string cmd = "SELECT profesores.idProfesor, profesores.nombre, profesores.apellido " +
                     "FROM profesores JOIN materias ON profesores.idMateria = materias.idMateria " +
                     $"WHERE materias.nombre = '{cmBx_Course.Text}';";

        MySqlDataReader reader = asesoriaQueries.ExecuteReader(cmd);

        while (reader.Read())
        {
            ltBx_profesores.Items.Add($"{reader["nombre"]} {reader["apellido"]}");
            _profIDs.Add(Convert.ToInt32(reader["idProfesor"]));
        }

        asesoriaQueries.Get_Connection().Close();
    }
    private void ltBx_profesores_SelectedIndexChanged(object sender, EventArgs e)
    {

        ltBx_horarios.Items.Clear();

        SqlQueries selHorarioQueries = new SqlQueries(_connectionString);
        string cmd = "SELECT horarios.dia, horarios.hora_inicio, horarios.hora_fin " +
                     "FROM profesores JOIN horarios ON profesores.idProfesor = horarios.idProfesor " +
                     $"WHERE profesores.idProfesor = '{_profIDs[ltBx_profesores.SelectedIndex]}';";

        MySqlDataReader reader = selHorarioQueries.ExecuteReader(cmd);

        while (reader.Read())
        {
            ltBx_horarios.Items.Add($"{reader["dia"]} {reader["hora_inicio"]} - {reader["hora_fin"]}");
            _horarios.Add(reader["hora_inicio"].ToString());
        }

        selHorarioQueries.Get_Connection().Close();
    }

    private void btn_reservar_Click(object sender, EventArgs e)
    {
        string profe = ltBx_profesores.SelectedItem.ToString();
        string materia = cmBx_Course.SelectedItem.ToString();
        string horario = ltBx_horarios.SelectedItem.ToString();
        string dia = dateTP_asesoria.Value.ToString("yy-MM-dd");
        string horaInicio = _horarios[ltBx_horarios.SelectedIndex]; 
        int profID = _profIDs[ltBx_profesores.SelectedIndex];

        Confirmacion confirmacion = 
            new Confirmacion(profe, materia, horario,dia, horaInicio, lbl_matr.Text, profID);
        
        confirmacion.Show();
    }
    //termina tab asesorias

    //empieza tab clubes deportivos

    private void btn_atletismo_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes atletismo = new ConfirmacionClubes(1, lbl_matr.Text, "Atletismo");
        atletismo.Show();
    }

    private void btn_basquetbol_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes basquetbol = new ConfirmacionClubes(2, lbl_matr.Text, "Basquetbol");
        basquetbol.Show();
    }

    private void btn_beisbol_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes beisbol = new ConfirmacionClubes(3, lbl_matr.Text, "Beisbol");
        beisbol.Show();
    }

    private void btn_crossfit_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes crossfit = new ConfirmacionClubes(4, lbl_matr.Text, "Crossfit");
        crossfit.Show();
    }

    private void btn_defensaPersonal_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes defensaPersonal = new ConfirmacionClubes(5, lbl_matr.Text, "Defensa Personal");
        defensaPersonal.Show();
    }

    private void btn_futbol_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes futbol = new ConfirmacionClubes(6, lbl_matr.Text, "Futbol");
        futbol.Show();
    }

    private void btn_karate_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes karate = new ConfirmacionClubes(7, lbl_matr.Text, "Karate");
        karate.Show();
    }

    private void btn_kendo_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes kendo = new ConfirmacionClubes(8, lbl_matr.Text, "Kendo");
        kendo.Show();
    }

    private void btn_taekwondo_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes taekwondo = new ConfirmacionClubes(9, lbl_matr.Text, "Taekwondo");
        taekwondo.Show();
    }

    private void btn_voleybol_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes voleybol = new ConfirmacionClubes(10, lbl_matr.Text, "Voleybol");
        voleybol.Show();
    }

    //termina tab clubes deportivos

    //empieza tab clubes culturales

    private void btn_ajedrez_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes ajedrez = new ConfirmacionClubes(11, lbl_matr.Text, "Ajedrez");
        ajedrez.Show();
    }

    private void btn_bandaGuerra_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes bandaGuerra = new ConfirmacionClubes(12, lbl_matr.Text, "Banda de Guerra");
        bandaGuerra.Show();
    }

    private void btn_danzaFolk_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes danzaFolk = new ConfirmacionClubes(13, lbl_matr.Text, "Danza Folklórica");
        danzaFolk.Show();
    }

    private void btn_porristas_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes porristas = new ConfirmacionClubes(14, lbl_matr.Text, "Porristas");
        porristas.Show();
    }

    private void btn_rondallaCanto_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes rondallaCanto = new ConfirmacionClubes(15, lbl_matr.Text, "Rondalla y Canto");
        rondallaCanto.Show();
    }

    private void btn_ritmosLatinos_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes ritmosLatinos = new ConfirmacionClubes(16, lbl_matr.Text, "Ritmos Latinos");
        ritmosLatinos.Show();
    }

    private void btn_regresarClubes_Click(object sender, EventArgs e)
    {
        tabControl.SelectedIndex = 0;

        btn_asesorias.Visible = true; btn_clubes.Visible = true;
        lbl_asesorias.Visible = true; lbl_clubes.Visible = true;

        btn_culturales.Visible = false; btn_culturales.Enabled = false;
        btn_deportivos.Visible = false; btn_deportivos.Enabled = false;

        lbl_welcome.Text = $"Bienvenid@ {lbl_name.Text}\n Seleccione el servicio que desea utilizar";
    }


    //termina tab clubes culturales

    //empieza tab configuracion

    private void btn_showPass_Click(object sender, EventArgs e)
    {
        txBx_Password.UseSystemPasswordChar = !txBx_Password.UseSystemPasswordChar;
    }
    private void btn_changePass_Click(object sender, EventArgs e)
    {
        if (txBx_Password.Enabled)
        {
            SqlQueries passwordQueries = new SqlQueries(_connectionString);

            string cmd = $"UPDATE alumnos SET contasena = '{txBx_Password.Text}' WHERE matricula = '{lbl_matr.Text}';";
            passwordQueries.GetCommand_and_ExecuteNonQuery(cmd);

            MessageBox.Show("Contraseña actualizada exitosamente.","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            passwordQueries.Get_Connection().Close();

            txBx_Password.Enabled = false;
        }
        txBx_Password.Enabled = true;
    }
    private void btn_deleteAcc_Click(object sender, EventArgs e)
    {
        bool confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar tu cuenta? Esta acción no se puede deshacer.", 
            "Confirme su acción", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        if (confirm)
        {
            SqlQueries deleteQueries = new SqlQueries(_connectionString);
            
            //delete foreign key constraint
            string cmd = $"DELETE FROM asesorias WHERE idAlumno = '{lbl_matr.Text}';";
            deleteQueries.GetCommand_and_ExecuteNonQuery(cmd);
            
            cmd = $"DELETE FROM alumnos WHERE matricula = '{lbl_matr.Text}';";
            deleteQueries.GetCommand_and_ExecuteNonQuery(cmd);        
            
            MessageBox.Show("Cuenta eliminada exitosamente.");
            
            deleteQueries.Get_Connection().Close();
            this.Close();
        }
    }
    
    private void btn_unsignClub_Click(object sender, EventArgs e)
    {
        bool confirm = MessageBox.Show($"¿Dar de baja del club {txBx_ClubSigned.Text}", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

        if (confirm)
        {
            SqlQueries unsignclubQueries = new SqlQueries(_connectionString);
            string cmd = $"UPDATE alumnos SET club_pertenece = NULL WHERE matricula = '{lbl_matr.Text}'";
            unsignclubQueries.GetCommand_and_ExecuteNonQuery(cmd);
            
            MessageBox.Show("Dado de baja del club exitosamente.");
            
            unsignclubQueries.Get_Connection().Close();
        }
    }
    
    //termina tab configuracion
    
}