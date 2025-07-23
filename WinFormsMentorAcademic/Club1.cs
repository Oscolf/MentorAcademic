namespace WinFormsMentorAcademic;

public partial class Club1 : Form
{
    public Club1()
    {
        InitializeComponent();
    }
    private void btn_seleccionado(object sender, EventArgs e)
    {
        ConfirmacionClubes confirmacion = new ConfirmacionClubes();
        confirmacion.Show();
    }

    private void btn_regresar_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}