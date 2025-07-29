using MySql.Data.MySqlClient;
using SQLqueries;
namespace WinFormsMentorAcademic;

public partial class ConfirmacionClubes : Form
{
    public ConfirmacionClubes(String clubName, string userMatr)
    {
        InitializeComponent();
        lbl_clubSel.Text = clubName;
        lbl_matr.Text = userMatr;

    }

    private void btn_send_Click(object sender, EventArgs e)
    {
        SqlQueries clubesQuery = new SqlQueries("server=localhost; port=3306; " +
                                        "database=mentor_academic; user=root;");

        // FIXME: Agregar telefono

        string cmd = $"UPDATE alumnos SET club_pertenece = '{lbl_clubSel.Text}', nss = '{tBz_ssn.Text}'" +
        $"WHERE matricula = '{lbl_matr.Text}';";

        clubesQuery.GetCommand_and_ExecuteNonQuery(cmd);

        MessageBox.Show("Se ha registrado correctamente en el club");
    }
}