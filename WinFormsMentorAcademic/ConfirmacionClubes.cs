using MySql.Data.MySqlClient;
using SQLqueries;
namespace WinFormsMentorAcademic;

public partial class ConfirmacionClubes : Form
{
    public ConfirmacionClubes(int clubID, string userMatr, string clubName)
    {
        InitializeComponent();
        lbl_matr.Text = userMatr;
        lbl_clubSel.Text += clubName;
        lbl_clubID.Text = clubID.ToString();
    }

    private void btn_send_Click(object sender, EventArgs e)
    {
        SqlQueries clubesQuery = new SqlQueries("server=localhost; port=3306; " +
                                        "database=mentoracademic; user=root;");

        string cmd = 
            $"UPDATE alumnos SET club_pertenece = '{lbl_clubID.Text}', nss = '{tBx_ssn.Text}'," + 
            $"numero_telefono = '{tBx_cellphoneNum.Text}' WHERE matricula = '{lbl_matr.Text}';";

        clubesQuery.GetCommand_and_ExecuteNonQuery(cmd);

        MessageBox.Show("Se ha registrado correctamente en el club");
        this.Close();
    }

    private void btn_regresar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}