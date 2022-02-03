using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Sokoban_Game___Assesment
{
    public class Wall
    {
        private List<Image> WallImages = new List<Image>();
        public Image Block { get; set; }
        public bool CanStepOn = false;
        public Wall(int wallID)
        {
            LoadResources();
            Block = WallImages[wallID];
            Block.Stretch = System.Windows.Media.Stretch.Fill;
        }
        private void LoadResources()
        {
            for (int i = 1; i < 4; i++)
            {
                Image Wall = new Image() { Source = new BitmapImage(new Uri($"/Assets/Game/Walls/block_0{i}.png", UriKind.Relative)) };
                WallImages.Add(Wall);
            }
        }
    }
}
