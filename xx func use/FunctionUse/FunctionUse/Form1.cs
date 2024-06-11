namespace FunctionUse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Pen lijnkleur = Pens.Black;
            Brush vulKleur = Brushes.Red;

            //voorbeeld:

            g.DrawRectangle(lijnkleur, 0, 0, 50, 50);

            //gebruik nu de FillRectangle function
            // maak een vierkant  op 60,60 van 30 bij 30
            g.??? (vulKleur, 60, 60, 30, 30);

            //maak nu zelf nog een vierkant, kies zelf waar en hoegroot
            g.???


            //we gaan nu een driehoek maken:

            g.DrawLine(lijnkleur, 50, 50, 100, 50);
            g.DrawLine(lijnkleur, 100, 50, 100, 0);
            g.??? //maak de driehoek af door nog een lijn tekenen

            //zoek nu zelf uit hoe je een circle tekent 
            ????
        }
    }
}
