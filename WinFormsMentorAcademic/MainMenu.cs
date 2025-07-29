namespace WinFormsMentorAcademic;
public partial class MainMenu : Form

{
    public MainMenu(User user)
    {
        InitializeComponent();
        lbl_name.Text += user.NombreCompleto;
        lbl_usr.Text += user.Matricula;
        lbl_welcome.Text = $"Bienvenid@ {user.NombreCompleto} \n Seleccione el servicio que desea utilizar";
    }


    private void btn_signout_Click(object sender, EventArgs e)
    {
        this.Close();
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

    private void btn_settings_Click(object sender, EventArgs e)
    {
        tabControl.SelectedIndex = 4;
    }

    //termina tab principal

    //empieza tab asesorias

    private void cmBx_Course_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btn_reservar_Click(object sender, EventArgs e)
    {
        Confirmacion confirmacion = new Confirmacion();
        confirmacion.Show();
    }


    //termina tab asesorias

    //empieza tab clubes deportivos

    private void btn_atletismo_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes atletismo = new ConfirmacionClubes("Atletísmo");
        atletismo.Show();
    }

    private void btn_basquetbol_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes basquetbol = new ConfirmacionClubes("Basquetbol");
        basquetbol.Show();
    }

    private void btn_beisbol_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes beisbol = new ConfirmacionClubes("Beisbol");
        beisbol.Show();
    }

    private void btn_crossfit_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes crossfit = new ConfirmacionClubes("Crossfit");
        crossfit.Show();
    }

    private void btn_defensaPersonal_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes defensaPersonal = new ConfirmacionClubes("Defensa Personal");
        defensaPersonal.Show();
    }

    private void btn_futbol_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes futbol = new ConfirmacionClubes("Futbol");
        futbol.Show();
    }

    private void btn_karate_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes karate = new ConfirmacionClubes("Karate");
        karate.Show();
    }

    private void btn_kendo_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes kendo = new ConfirmacionClubes("Kendo");
        kendo.Show();
    }

    private void btn_taekwondo_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes taekwondo = new ConfirmacionClubes("Tae-kwon-do");
        taekwondo.Show();
    }

    private void btn_voleybol_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes voleybol = new ConfirmacionClubes("Voleybol");
        voleybol.Show();
    }

    //termina tab clubes deportivos

    //empieza tab clubes culturales

    private void btn_ajedrez_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes ajedrez = new ConfirmacionClubes("Ajedrez");
        ajedrez.Show();
    }

    private void btn_bandaGuerra_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes bandaGuerra = new ConfirmacionClubes("Banda de Guerra");
        bandaGuerra.Show();
    }

    private void btn_danzaFolk_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes danzaFolk = new ConfirmacionClubes("Danza Folklórica");
        danzaFolk.Show();
    }

    private void btn_porristas_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes porristas = new ConfirmacionClubes("Porristas");
        porristas.Show();
    }

    private void btn_rondallaCanto_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes rondallaCanto = new ConfirmacionClubes("Rondalla y Canto");
        rondallaCanto.Show();
    }

    private void btn_ritmosLatinos_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes ritmosLatinos = new ConfirmacionClubes("Ritmos Latinos");
        ritmosLatinos.Show();
    }

    private void btn_regresarClubes_Click(object sender, EventArgs e)
    {
        tabControl.SelectedIndex = 0;

        btn_asesorias.Visible = true; btn_clubes.Visible = true; 
        lbl_asesorias.Visible = true; lbl_clubes.Visible = true;

        btn_culturales.Visible = false; btn_culturales.Enabled = false;
        btn_deportivos.Visible = false; btn_deportivos.Enabled = false;

        lbl_welcome.Text = $"Bienvenid@ \n Seleccione el servicio que desea utilizar";
    }
    //termina tab clubes culturales

    //empieza tab configuracion

    //termina tab configuracion
}
