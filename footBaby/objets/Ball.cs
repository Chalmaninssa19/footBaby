using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace footBaby.objets
{
    internal class Ball : PictureBox
    {
        int ballX = 50;
        int ballY = 50;
        int speedX = 5;
        int speedY = 5;
        int height = 10;
        int width = 10;
        Color color = Color.Black;

        public Ball(int x, int y)
        {
            initiliazeComponent(x,y);
        }

        public Color Color { get; set; }
        public int BallX { get; set; }
        public int BallY { get; set; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }

        public void initiliazeComponent(int x, int y)
        {
            this.BackColor = this.color;
            SpeedX = 5;
            SpeedY = 5;
            Width = 10;
            Height = 10;
            BallX = x;
            BallY = y;
            this.SetBounds(BallX, BallY, Width, Height);
        }
        public void Mover(int widthTerrain,int heightTerrain,List<Player> players)
        {
            BallX += SpeedX;
            BallY += SpeedY;

            //Console.WriteLine("ballon -> "+BallX+"sppeed->"+SpeedX);
            if (BallX >= widthTerrain || BallX <= 0)
            {
                SpeedX = -SpeedX;
            }
            if (BallY >= heightTerrain || BallY <= 0)
            {
                SpeedY = -SpeedY;
            }
            checkColisionPlayer(players);

            this.Location = new Point(BallX, BallY);
        }
        public void checkColisionPlayer(List<Player> players)
        {
            foreach(Player player in players)
            {
                if(this.Bounds.IntersectsWith(player.Bounds))
                {
                    //SpeedX = -SpeedX;
                    SpeedY = -SpeedY;
                }
            }
        }
    }
}
