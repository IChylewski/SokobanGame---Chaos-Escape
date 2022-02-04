using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Sokoban_Game___Assesment
{
    /*
     This is wall class that is responsible for loading Wall's images from the folder and using them to construct wall object
     */
    public class Wall
    {
        private List<Image> WallImages = new List<Image>();  // Stores all of images from the folder
        public Image Block { get; set; }         // Stores the wall image chosen for specific object
        public Wall(int wallID)             // Constructor that has ID parameter that allows to create wall object with specific image of the wall
        {
            LoadResources();
            Block = WallImages[wallID];
            Block.Stretch = System.Windows.Media.Stretch.Fill;  // Changes image property so image fills entire grid block
        }
        private void LoadResources()        // Method that loads all images from the folder
        {
            for (int i = 1; i < 4; i++)
            {
                Image Wall = new Image() { Source = new BitmapImage(new Uri($"/Assets/Game/Walls/block_0{i}.png", UriKind.Relative)) };
                WallImages.Add(Wall);
            }
        }
    }
}
