namespace WinFormsMentorAcademic
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            User usuario = new User(tbx_nombre.Text, tbx_apellidos.Text, tbx_correo.Text, tbx_contraseña.Text);
            if (usuario.ValidateSignUp())
            {
                MainMenu principal = new MainMenu(usuario);
                principal.Show();
                this.Hide();
            }
        }
        private void tbx_TextChanged(object sender, EventArgs e)
        {
            if (tbx_nombre.Text != "" && tbx_contraseña.Text != "" && tbx_apellidos.Text != "" && tbx_correo.Text != "")
                btn_signUp.Enabled = true;
            else
                btn_signUp.Enabled = false;
        }
    }
}
