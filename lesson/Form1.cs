namespace lesson
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {  
            frmMain frmMain = new frmMain();
            this.Hide();

            frmMain.ShowDialog();
            this.Show();
        }
    }
}