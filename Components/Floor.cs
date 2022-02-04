using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Sokoban_Game___Assesment
{
    /// <summary>
    ///  Floor Class that allows to create floor block instances
    /// </summary>
    public class Floor
    {
        private List<Image> GroundImages = new List<Image>(); // Stores all of images from the folder
        public Image Ground { get; set; }       // Stores the floor image chosen for specific object
        public Floor(int groundID)          // Constructor that has ID parameter that allows to create floor object with specific image of the floor
        {
                LoadResources();
                Ground = GroundImages[groundID];
                Ground.Stretch = System.Windows.Media.Stretch.Fill;    // Changes image property so image fills entire grid block
        }
        private void LoadResources()     // Method that loads all images from the folder
        {
            for (int i = 1; i < 4; i++)
            {
                Image Wall = new Image() { Source = new BitmapImage(new Uri($"/Assets/Game/Ground/ground_0{i}.png", UriKind.Relative)) };
                GroundImages.Add(Wall);
            }
        }
        }
}

