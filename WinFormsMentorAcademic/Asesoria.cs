namespace WinFormsMentorAcademic;

public partial class Asesoria : Form
{
    public Asesoria (string matricula, string nombre)
    {
        InitializeComponent();
        lbl_user.Text += matricula;
        lbl_fullname.Text += nombre;
    }
    private void btn_exit_Click(object sender, EventArgs e)
    {
       this.Close(); 
    }
    private void cmBx_Course_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btn_reservar_Click(object sender, EventArgs e)
    {
        Confirmacion confirmacion = new Confirmacion();
        confirmacion.Show();
    }
}