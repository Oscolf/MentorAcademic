using SQLqueries;

namespace WinFormsMentorAcademic;
public partial class Confirmacion : Form
{
    public Confirmacion(string profesor, string materia, string horario, string dia, string horaInicio, string matrAlumno, int profId)
    {
        InitializeComponent();

        lbl_ConfirmProfe.Text = profesor;
        lbl_ConfirmMateria.Text = materia;
        lbl_ConfirmHorario.Text = horario;
        lbl_ConfirmarMatr.Text = matrAlumno;
        lbl_Confirmdate.Text = dia;
        
        lbl_ConfirmHorainicio.Text = horaInicio;
        lbl_ConfirmProfID.Text = profId.ToString();
    }

    private readonly string _connectionString = "server=localhost;port=3306;user=root;database=mentoracademic;sslmode=none;";
    private void btn_print_Click(object sender, EventArgs e)
    {
        SqlQueries asesoriaQueries = new SqlQueries(_connectionString);
        
        string cmd = $"INSERT INTO asesorias (idProfesor, idAlumno, hora, fecha, estado) " +
                     $"VALUES ('{lbl_ConfirmProfID.Text}','{lbl_ConfirmarMatr.Text}', '{lbl_ConfirmHorainicio.Text}', '{lbl_Confirmdate.Text}', 'Pendiente');";
        
        asesoriaQueries.GetCommand_and_ExecuteNonQuery(cmd);
        
        MessageBox.Show("Asesoría reservada exitosamente.");
        
        asesoriaQueries.Get_Connection().Close();
        this.Close();
    }

    private void btn_back_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
