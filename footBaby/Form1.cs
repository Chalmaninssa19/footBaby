using footBaby.objets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace footBaby
{
    public partial class BabyFoot : Form
    {
        private Timer animationTimer;
        private Ball ball;
        List<Player> players = new List<Player>();
       
        public BabyFoot()
        {
            InitializeComponent();
            ball = new Ball(terrain.Width / 2, terrain.Height / 2);

            PlayersList();
            AddPlayer(players);
            terrain.Controls.Add(ball);
            //Creation et configuration du minuteur pour l'animation
            animationTimer = new Timer();
            animationTimer.Interval = 10; //Intervale en milliseconde entre chaque rafraichissement
            animationTimer.Tick += AnimationTimer_Tick;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            //Verifier les collisions
            //ball.checkCollisionTerrain(); 

            //Mise a jour de la position du ballon
            ball.Mover(terrain.Width,terrain.Height,players);

            //Redessiner le formulaire
            Invalidate();
        }
        public void PlayersList()
        {
            players.Add(new Player(1, "A", Color.Red, 135, 387, 20, 20));
            players.Add(new Player(2, "A", Color.Red, 135, 80, 20, 20));
            players.Add(new Player(3, "A", Color.Red, 42, 80, 20, 20));
            players.Add(new Player(4, "A", Color.Red, 227, 80, 20, 20));
            players.Add(new Player(5, "A", Color.Red, 99, 189, 20, 20));
            players.Add(new Player(6, "A", Color.Red, 159, 189, 20, 20));
            players.Add(new Player(7, "A", Color.Red, 209, 189, 20, 20));
            players.Add(new Player(8, "A", Color.Red, 39, 189, 20, 20));
            players.Add(new Player(9, "A", Color.Red, 135, 339, 20, 20));
            players.Add(new Player(10, "A", Color.Red, 42, 339, 20, 20));
            players.Add(new Player(11, "A", Color.Red, 227, 339, 20, 20));
            players.Add(new Player(1, "B", Color.Green, 135, 20, 20, 20));
            players.Add(new Player(2, "B", Color.Green, 135, 50, 20, 20));
            players.Add(new Player(3, "B", Color.Green, 42, 50, 20, 20));
            players.Add(new Player(4, "B", Color.Green, 227, 50, 20, 20));
            players.Add(new Player(5, "B", Color.Green, 99, 159, 20, 20));
            players.Add(new Player(6, "B", Color.Green, 159, 159, 20, 20));
            players.Add(new Player(7, "B", Color.Green, 209, 159, 20, 20));
            players.Add(new Player(8, "B", Color.Green, 39, 159, 20, 20));
            players.Add(new Player(9, "B", Color.Green, 135, 299, 20, 20));
            players.Add(new Player(10, "B", Color.Green, 42, 299, 20, 20));
            players.Add(new Player(11, "B", Color.Green, 227, 299, 20, 20));
        }

        private void AddPlayer(List<Player> players)
        {
            foreach(Player player in players)
            {
                terrain.Controls.Add(player);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
           // base.OnPaint(e);

            //Dessineer l'objet anime sur le formulaire
           /* using (Brush brush = new SolidBrush(ball.Color))
            {
                e.Graphics.FillEllipse(brush, x, y, 50, 50);
            }*/
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BabyFoot_KeyDown(object slender, KeyEventArgs e)
        {
        ///Pour les A
            /* //Gardien de but
            if(e.KeyCode == Keys.A)
            {
                this.playerA1.moveLeft();
            }
            if (e.KeyCode == Keys.S)
            {
                this.playerA1.moveRight();
            }
            //Defense
            if (e.KeyCode == Keys.D)
            {
                this.playerA9.moveLeft();
                this.playerA10.moveLeft();
                this.playerA11.moveLeft();
            }
            if (e.KeyCode == Keys.F)
            {
                this.playerA9.moveRight();
                this.playerA10.moveRight();
                this.playerA11.moveRight();
            }
            //Milieu
            if (e.KeyCode == Keys.G)
            {
                this.playerA5.moveLeft();
                this.playerA6.moveLeft();
                this.playerA7.moveLeft();
                this.playerA8.moveLeft();
            }
            if (e.KeyCode == Keys.H)
            {
                this.playerA5.moveRight();
                this.playerA6.moveRight();
                this.playerA7.moveRight();
                this.playerA8.moveRight();
            }
            //Attaquant
            if (e.KeyCode == Keys.J)
            {
                this.playerA2.moveLeft();
                this.playerA3.moveLeft();
                this.playerA4.moveLeft();
            }
            if (e.KeyCode == Keys.K)
            {
                this.playerA2.moveRight();
                this.playerA3.moveRight();
                this.playerA4.moveRight();
            }


        ///Pour les B
            //Gardien de but
            if (e.KeyCode == Keys.Q)
            {
                this.playerB1.moveLeft();
            }
            if (e.KeyCode == Keys.W)
            {
                this.playerB1.moveRight();
            }
            //Defense
            if (e.KeyCode == Keys.E)
            {
                this.playerB2.moveLeft();
                this.playerB3.moveLeft();
                this.playerB4.moveLeft();
            }
            if (e.KeyCode == Keys.R)
            {
                this.playerB2.moveRight();
                this.playerB3.moveRight();
                this.playerB4.moveRight();
            }
            //Milieu
            if (e.KeyCode == Keys.T)
            {
                this.playerB5.moveLeft();
                this.playerB6.moveLeft();
                this.playerB7.moveLeft();
                this.playerB8.moveLeft();
            }
            if (e.KeyCode == Keys.Y)
            {
                this.playerB5.moveRight();
                this.playerB6.moveRight();
                this.playerB7.moveRight();
                this.playerB8.moveRight();
            }
            //Attaquant
            if (e.KeyCode == Keys.U)
            {
                this.playerB9.moveLeft();
                this.playerB10.moveLeft();
                this.playerB11.moveLeft();
            }
            if (e.KeyCode == Keys.I)
            {
                this.playerB9.moveRight();
                this.playerB10.moveRight();
                this.playerB11.moveRight();
            }*/
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            //Demarrer l'animation lorsque le button essst clique
            animationTimer.Start();
        }
    }
}
