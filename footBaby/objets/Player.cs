using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace footBaby.objets
{
    internal class Player : PictureBox
    {
        int idPlayer;
        String team;
        int posX;
        int posY;
        int width;
        int height;
        Color color;

        public Player(int idPlayer, String team, Color color,int posX, int posY, int width, int height)
        {
            this.idPlayer = idPlayer;
            this.team = team;
            this.color = color;
            this.posX = posX;
            this.posY = posY;
            this.width = width;
            this.height = height;
            initializeComponent();
        }

        public void initializeComponent()
        {
            this.SetBounds(this.posX, this.posY, this.width, this.height);
            this.BackColor = this.color;
        }

        public void moveLeft()
        {
            this.Left -= 10;
        }
        public void moveRight()
        {
            this.Left += 10;
        }
    }
}
