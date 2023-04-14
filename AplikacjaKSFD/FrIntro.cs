namespace AplikacjaKSFD
{
    public partial class FrIntro : Form
    {
        public FrIntro()
        {  
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            InitializeComponent();
            double X = Screen.PrimaryScreen.Bounds.Width;
            double Y = Screen.PrimaryScreen.Bounds.Height;

            PbLoading.Width = Convert.ToInt32(X / 1.347368421052632); 
            PbLoading.Height = Convert.ToInt32(Y / 14.62857142857143); 
            PbLoading.Location = new Point(Convert.ToInt32((X / 12)), Convert.ToInt32((Y / 1.3)));

            IntroTimer.Start();         
        }

        private void IntroTimer_Tick(object sender, EventArgs e) //to nie jest prawdziwy pasek ³adowania, ale na u¿ytkowniku mo¿e zrobi wra¿enie lub chocia¿ zapozna siê z treœci¹ intro
        {
            if (PbLoading.Value < PbLoading.Maximum)
            {
                PbLoading.Value += 1;
            }
            else
            {
                IntroTimer.Stop();
                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
                FrMainMenu Menu = new FrMainMenu();
                Menu.Show();
                this.Hide();
            }
        }
    }
}