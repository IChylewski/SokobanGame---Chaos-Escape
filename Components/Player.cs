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
    // This is player class that allows to create instance of player
    // The methods are going to be updated

    public class Player
    {
        public Image PlayerImg { get; set; }       // Stores image file representing player
        public int[] PlayerCords { get; set; }      // Stores actual coordinates where player is placed

        public Player(int[] startingCords)           // Constructor that allows to place player anywhere in the map
        {
            PlayerImg = new Image() { Source = new BitmapImage(new Uri("/Assets/Game/Player/Player.png", UriKind.Relative)) };
            PlayerCords = startingCords;
        }
        public void Move(string direction)         // Move Method that changes player cords depending on move direction
        {

            switch(direction)
            {
                case "up": PlayerCords[1] -= 1; break;
                case "down": PlayerCords[1] += 1; break;
                case "left": PlayerCords[0] -= 1; break;
                case "right": PlayerCords[0] += 1; break;
            }
        }
        public void Movement(KeyEventArgs e)   // Invokes move function and passes Key parameter giving information about move direction
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
