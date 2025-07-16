namespace WinFormsMentorAcademic;
public partial class MainMenu : Form

{
    public MainMenu(string userMatricula, string userName)
    {
        InitializeComponent();
        lbl_name.Text += userName;
        lbl_usr.Text += userMatricula;
        lbl_welcome.Text = $"¡Bienvenid@ {userName}! \n Seleccione el servicio que desea utilizar";
    }

    private void btn_signout_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btn_asesorias_Click(object sender, EventArgs e)
    {
        Asesoria asesorias = new Asesoria(lbl_usr.Text, lbl_name.Text);
        asesorias.Show();
        this.Hide();
    }

    private void btn_clubes_Click(object sender, EventArgs e)
    {
        btn_asesorias.Visible = false;
        btn_clubes.Visible = false;

        btn_culturales.Visible = true; btn_culturales.Enabled = true;
        btn_deportivos.Visible = true; btn_deportivos.Enabled = true;

        lbl_welcome.Text = "Seleccione a qué tipo de club desea pertenecer";
       
    }

    private void btn_deportivos_Click(object sender, EventArgs e)
    {
       Club2 deportivos = new Club2();
       deportivos.Show();
    }
    
    private void btn_culturales_Click(object sender, EventArgs e)
    {
        Club1 culturales = new Club1();
        culturales.Show();
    }
}