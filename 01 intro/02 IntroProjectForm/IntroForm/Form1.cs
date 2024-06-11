namespace IntroForm
{
    public partial class Form1 : Form
    {
        //ken waardes toe aan de variabelen (assignement (=))
        int x = ???;
        int y = ???;
        string introSentence = ???;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawString(introSentence, Font, Brushes.Black, x, y);
        }
    }
}
