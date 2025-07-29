namespace WinFormsMentorAcademic;
    public partial class Club2 : Form
    {
        public Club2(string userId)
        {
            InitializeComponent();
        }
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_taekwondo_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes taekwondo = new ConfirmacionClubes("Tae-kwon-do");
        }

        private void btn_atletismo_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes atletismo = new ConfirmacionClubes("Atletísmo");
        }

        private void btn_basquetbol_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes basquetbol = new ConfirmacionClubes("Basquetbol");
        }

        private void btn_karate_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes karate = new ConfirmacionClubes("Karate");
        }

        private void btn_defensaPersonal_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes defensaPersonal = new ConfirmacionClubes("Defensa Personal");
        }

        private void btn_crossfit_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes crossfit = new ConfirmacionClubes("Crossfit");
        }

        private void btn_futbol_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes futbol = new ConfirmacionClubes("Futbol");
        }

        private void btn_kendo_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes kendo = new ConfirmacionClubes("Kendo");
        }

        private void btn_beisbol_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes beisbol = new ConfirmacionClubes("Beisbol");
        }

        private void btn_voleybol_Click(object sender, EventArgs e)
        {
            ConfirmacionClubes voleybol = new ConfirmacionClubes("Voleybol");
        }
    }