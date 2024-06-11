using GameJam.Game;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GameJam
{
    public partial class RenderForm : Form
    {


        private float frametime;
        private GameRenderer renderer;
        private readonly GameContext gc = new GameContext();
        public RenderForm()
        {
            InitializeComponent();

            DoubleBuffered = true;
            ResizeRedraw = true;

            //audio = new Audio();
            KeyDown += RenderForm_KeyDown;
            FormClosing += Form1_FormClosing;
            Load += RenderForm_Load;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            renderer.Dispose();
        }
        private void RenderForm_Load(object sender, EventArgs e)
        {

            renderer = new GameRenderer(gc);

            gc.player = new RenderObject()
            {
                frames = gc.spriteMap.GetPlayerFrames(),
                rectangle = new Rectangle(2 * gc.tileSize, 2 * gc.tileSize, gc.tileSize, gc.tileSize),
            };


            ClientSize =
             new Size(

                (gc.tileSize * 12) * gc.scaleunit,
                (gc.tileSize * 12) * gc.scaleunit
                );
        }

        private void RenderForm_KeyDown(object sender, KeyEventArgs e)
        {
           
        }


        public void Logic(float frametime)
        {
            this.frametime = frametime;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            renderer.Render(e, frametime);
        }
    }

}


