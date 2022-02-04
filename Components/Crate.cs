using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace Sokoban_Game___Assesment.Components
{
    public class Crate
    {
        public List<Image> CrateImages = new List<Image>();    // Stores all of crates images from the folder
        public Image CrateImg { get; set; }             // Stores the crate image chosen for specific object
        public int[] CrateCords { get; set; }          // Stores the crate chords to follow its position

        public Crate(int crateID, int[] crateCords)             // Constructor that has ID parameter that allows to create crate object with specific image of the crate
        {
            LoadResources();
            CrateImg = CrateImages[crateID];
            CrateCords = crateCords;
            CrateImg.Stretch = System.Windows.Media.Stretch.Fill;  // Changes image property so image fills entire grid block
        }
        private void LoadResources()        // Method that loads all images from the folder
        {
            for (int i = 1; i < 4; i++)
            {
                Image Crate = new Image() { Source = new BitmapImage(new Uri($"/Assets/Game/Crates/crate_0{i}.png", UriKind.Relative)) };
                CrateImages.Add(Crate);
            }
        }
        public void Move(string direction)         // Move Method that changes crate cords depending on move direction
        {

            switch (direction)
            {
                case "up": CrateCords[1] -= 1; break;
                case "down": CrateCords[1] += 1; break;
                case "left": CrateCords[0] -= 1; break;
                case "right": CrateCords[0] += 1; break;
            }
        }

        public void Movement(KeyEventArgs e)   // Invokes move function and passes Key parameter giving information about move direction
        {
            switch (e.Key)
            {
                case Key.Up: Move("up"); break;
                case Key.Down: Move("down"); break;
                case Key.Left: Move("left"); break;
                case Key.Right: Move("right"); break;
            }
        }
    }
}
