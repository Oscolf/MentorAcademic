using System.Runtime.InteropServices.JavaScript;
using MySql.Data.MySqlClient;
using SQLqueries;

namespace WinFormsMentorAcademic;
public partial class Confirmacion : Form
{
    public Confirmacion(string profesor, string alumno, string materia, string horario, string hora_inicio, string matrAlumno, int profID)
    {
        InitializeComponent();

        lbl_ConfirmProfe.Text = profesor;
        lbl_ConfirmMateria.Text = materia;
        lbl_ConfirmHorario.Text = horario;
        lbl_ConfirmHorainicio.Text = hora_inicio;
        lbl_ConfirmProfID.Text = profID.ToString();
        lbl_ConfirmarMatr.Text = matrAlumno;
    }

    private void btn_print_Click(object sender, EventArgs e)
    {
        SqlQueries asesoriaQueries = new SqlQueries("server=localhost;" +
                                                   "port=3306;" +
                                                   "database=mentoracademic;" +
                                                   "uid=root;" +
                                                   "sslmode=none;");

        string fecha = DateTime.Now.ToString("yyyy-MM-dd");
        string cmd = $"INSERT INTO asesorias (idProfesor, idAlumno, hora, fecha, estado) " +
                     $"VALUES ('{lbl_ConfirmProfID.Text}','{lbl_ConfirmarMatr.Text}', '{lbl_ConfirmHorainicio.Text}', '{fecha}', 'Pendiente');";

        asesoriaQueries.GetCommand_and_ExecuteNonQuery(cmd);
        MessageBox.Show("Asesoría reservada exitosamente.");
        
        asesoriaQueries.Get_Connection().Close();
        this.Close();
    }
}
