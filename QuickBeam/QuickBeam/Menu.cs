namespace QuickBeam
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void OpenSimBtn_Click(object sender, EventArgs e)
        {
            StatsPage statsPage = new StatsPage();
            statsPage.Show();
        }
    }
}