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
        
    }
    private void txB_matricula_clicked(object sender, EventArgs e)
    {
        if (txB_matricula.Text == "ejemplo@email.com")
            txB_matricula.Text = "";
        txB_matricula.ForeColor = Color.Black;
    }
    private void txBx_TextChanged(object sender, EventArgs e)
    {
        if (txB_matricula.Text != "" && txB_password.Text != "")
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