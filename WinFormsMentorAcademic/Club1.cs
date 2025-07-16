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
}