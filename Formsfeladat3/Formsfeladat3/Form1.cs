namespace Formsfeladat3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            PanelIgazit();
        }

        private void PanelIgazit()
        {
            panel.Left = (ClientSize.Width - panel.Width) / 2;
            panel.Top = (ClientSize.Height - panel.Height) / 2;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = String.Format("Az eg�rkoordin�t�i X:{0},Y:{1}", e.X, e.Y);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PanelIgazit();
        }
    }
}