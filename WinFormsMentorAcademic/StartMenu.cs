namespace WinFormsMentorAcademic;

public partial class StartMenu : Form
{
    public StartMenu()
    {
        InitializeComponent();
    }
    private void btn_login_Click(object sender, EventArgs e)
    {
        LogIn login = new LogIn();
        login.Show();
    }
    private void btn_signup_Click(object sender, EventArgs e)
    {
        SignUp registrarse =  new  SignUp();
        registrarse.Show();
    }
    private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
        Point punto = new Point
        {
            Y = 40 + vScBr_redesSociales.Value * -(grBx_RedesSociales.Height / 100),
            X = 25
        };

        btn_facebook.Location = punto;
        
        punto.Y = 280 + vScBr_redesSociales.Value * -(grBx_RedesSociales.Height / 100);
        
        btn_instagram.Location = punto;
        
        punto.Y = 520 + vScBr_redesSociales.Value * -(grBx_RedesSociales.Height / 100);

        btn_youtube.Location = punto;
        
        punto.Y = 760 + vScBr_redesSociales.Value * -(grBx_RedesSociales.Height / 100);
        
        btn_twitter.Location = punto;
    }
}