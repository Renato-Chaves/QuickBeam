using System.Windows.Forms;

namespace QuickBeam
{
    public partial class Menu : Form
    {
        static Menu instance;

        public Menu()
        {
            instance = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            MergeSortImage.SizeMode = PictureBoxSizeMode.Zoom;
            HeapSortImage.SizeMode = PictureBoxSizeMode.Zoom;
            ShellSortImage.SizeMode = PictureBoxSizeMode.Zoom;
            QuickSortImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public static Menu GetInstance()
        {
            if (instance == null) instance = new Menu();
            return instance;
        }

        public void SwitchToPage()
        {
            this.Show();
        }

        public void SetHistory(int sortType, string caseLevel, string inputQuatity, string elapsedTime, string steps, string moves, string bigO)
        {
            switch (sortType)
            {
                case 0:
                    BubbleSortH1.Text = "- Nivel:     " + caseLevel + "\r\n- Numeros:     " + inputQuatity + "\r\n- Tempo:     " + elapsedTime + "ms";
                    BubbleSortH2.Text = "- Passos:     " + steps + "\r\n- Trocas:    " + moves + "\r\n- BigO:     " + bigO;
                    break;
                case 1:
                    MergeSortH1.Text = "- Nivel:     " + caseLevel + "\r\n- Numeros:     " + inputQuatity + "\r\n- Tempo:     " + elapsedTime + "ms";
                    MergeSortH2.Text = "- Passos:     " + steps + "\r\n- Trocas:    " + moves + "\r\n- BigO:     " + bigO;
                    break;
                case 2:
                    HeapSortH1.Text = "- Nivel:     " + caseLevel + "\r\n- Numeros:     " + inputQuatity + "\r\n- Tempo:     " + elapsedTime + "ms";
                    HeapSortH2.Text = "- Passos:     " + steps + "\r\n- Trocas:    " + moves + "\r\n- BigO:     " + bigO;
                    break;
                case 3:
                    ShellSortH1.Text = "- Nivel:     " + caseLevel + "\r\n- Numeros:     " + inputQuatity + "\r\n- Tempo:     " + elapsedTime + "ms";
                    ShellSortH2.Text = "- Passos:     " + steps + "\r\n- Trocas:    " + moves + "\r\n- BigO:     " + bigO;
                    break;
                case 4:
                    QuickSortH1.Text = "- Nivel:     " + caseLevel + "\r\n- Numeros:     " + inputQuatity + "\r\n- Tempo:     " + elapsedTime + "ms";
                    QuickSortH2.Text = "- Passos:     " + steps + "\r\n- Trocas:    " + moves + "\r\n- BigO:     " + bigO;
                    break;
            }
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "BubbleSortBtn":
                    tabControl1.SelectedIndex = 0;
                    break;
                case "MergeSortBtn":
                    tabControl1.SelectedIndex = 1;
                    break;
                case "HeapSortBtn":
                    tabControl1.SelectedIndex = 2;
                    break;
                case "ShellSortBtn":
                    tabControl1.SelectedIndex = 3;
                    break;
                case "QuickSortBtn":
                    tabControl1.SelectedIndex = 4;
                    break;
            }
        }

        private void OpenSimBtn_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "OpenBubbleSim":
                    StatsPage.GetInstance().SwitchToPage(0);
                    this.Hide();
                    break;
                case "OpenMergeSim":
                    StatsPage.GetInstance().SwitchToPage(1);
                    this.Hide();
                    break;
                case "OpenHeapSim":
                    StatsPage.GetInstance().SwitchToPage(2);
                    this.Hide();
                    break;
                case "OpenShellSim":
                    StatsPage.GetInstance().SwitchToPage(3);
                    this.Hide();
                    break;
                case "OpenQuickSim":
                    StatsPage.GetInstance().SwitchToPage(4);
                    this.Hide();
                    break;
            }
        }
    }
}