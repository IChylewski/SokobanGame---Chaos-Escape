using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Sokoban_Game___Assesment
{
    public class Floor
    {
        private List<Image> GroundImages = new List<Image>();
        public Image Ground { get; set; }
        public Floor(int groundID)
        {
                LoadResources();
                Ground = GroundImages[groundID];
                Ground.Stretch = System.Windows.Media.Stretch.Fill;
        }
        private void LoadResources()
        {
            for (int i = 1; i < 4; i++)
            {
                Image Wall = new Image() { Source = new BitmapImage(new Uri($"/Assets/Game/Ground/ground_0{i}.png", UriKind.Relative)) };
                GroundImages.Add(Wall);
            }
        }
        }
}

