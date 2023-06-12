namespace Formsfeladat1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_BF_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = 0;
        }

        private void Bt_JF_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = 0;
        }

        private void Bt_BL_Click(object sender, EventArgs e)
        {
            Left = 0;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }

        private void Bt_JL_Click(object sender, EventArgs e)
        {
            Left = Screen.PrimaryScreen.Bounds.Width - Width;
            Top = Screen.PrimaryScreen.Bounds.Height - Height;
        }
    }
}