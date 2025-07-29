using MySql.Data.MySqlClient;
using SQLqueries;
namespace WinFormsMentorAcademic;

public partial class ConfirmacionClubes : Form
{
    public ConfirmacionClubes(String clubName)
    {
        InitializeComponent();
        lbl_clubSel.Text = clubName;
    }

    private void btn_send_Click(object sender, EventArgs e)
    {
        SqlQueries clubesQuery = new SqlQueries("server=localhost; port=3306; " +
                                        "database=mentor_academic; user=root;");

        string cmd = $"UPDATE alumnos SET club_pertenece = '{lbl_clubSel.Text}' ";
        //$"WHERE matricula = '{User.Matricula}';";
    }
}