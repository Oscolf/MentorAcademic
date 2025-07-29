namespace WinFormsMentorAcademic;

public partial class Club1 : Form
{
    public Club1(string userId)
    {
        InitializeComponent();
    }

    private void btn_regresar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btn_danzaFolk_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes danzaFolk = new ConfirmacionClubes("Danza Folklórica");
    }

    private void btn_ajedrez_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes ajedrez = new ConfirmacionClubes("Ajedrez");
    }

    private void btn_bandaGuerra_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes bandaGuerra = new ConfirmacionClubes("Banda de Guerra");
    }

    private void btn_porristas_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes porristas = new ConfirmacionClubes("Porristas");
    }

    private void btn_rondallaCanto_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes rondallaCanto = new ConfirmacionClubes("Rondalla y Canto");
    }

    private void btn_ritmosLatinos_Click(object sender, EventArgs e)
    {
        ConfirmacionClubes ritmosLatinos = new ConfirmacionClubes("Ritmos Latinos");
    }
}