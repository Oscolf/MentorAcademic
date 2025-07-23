using SQLqueries;
using MySql.Data.MySqlClient;

namespace WinFormsMentorAcademic;

public partial class LogIn : Form
{
    public LogIn()
    {
        InitializeComponent();
    }
    private void btn_login_Click(object sender, EventArgs e)
    {
        //Realizar una consulta a la base de datos para verificar las credenciales
        SqlQueries ConsultUser =  new SqlQueries("server=localhost;" +
                                                 "host=3306" +
                                                 "database=mentoracademic;" +
                                                 "uid=root");
        string cmd = $"SELECT * FROM alumnos WHERE email = {tBx_correo.Text} AND contrasena = {txB_password.Text};";
        
        MySqlDataReader reader = ConsultUser.ExecuteReader(cmd);
        
    }
    private void txB_matricula_clicked(object sender, EventArgs e)
    {
        if (tBx_correo.Text == "ejemplo@email.com")
            tBx_correo.Text = "";
        tBx_correo.ForeColor = Color.Black;
    }
    private void txBx_TextChanged(object sender, EventArgs e)
    {
        if (tBx_correo.Text != "" && txB_password.Text != "")
            btn_login.Enabled = true;
        else
            btn_login.Enabled = false;
    }

    private void btn_back_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void lnkLbl_createAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        SignUp registro = new SignUp();
        registro.Show();
        this.Hide();
    }
}