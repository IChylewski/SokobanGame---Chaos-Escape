using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Sokoban_Game___Assesment
{
    public class Player
    {
        public Image PlayerImg { get; set; }
        public int[] PlayerCords { get; set; }

        public Player(int[] startingCords)
        {
            PlayerImg = new Image() { Source = new BitmapImage(new Uri("/Assets/Game/Player/Player.png", UriKind.Relative)) };
            PlayerCords = startingCords;
        }
        public void Move(string direction)
        {

            switch(direction)
            {
                case "up": PlayerCords[1] -= 1; break;
                case "down": PlayerCords[1] += 1; break;
                case "left": PlayerCords[0] -= 1; break;
                case "right": PlayerCords[0] += 1; break;
            }
        }
        public void Movement(KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Up: Move("up");break;
                case Key.Down: Move("down"); break;
                case Key.Left: Move("left"); break;
                case Key.Right: Move("right"); break;
            }
        }
    }
}
