using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Sokoban_Game___Assesment.Components
{
    public class Endpoint
    {
        public Image EndpointImg { get; set; }       // Stores image file representing endpoint
        public int[] EndpointCords { get; set; }      // Stores coordinates of endpoint

        public Endpoint(int[] endpointCords)           // Constructor that allows to place endpoint anywhere in the map
        {
            EndpointImg = new Image() { Source = new BitmapImage(new Uri("/Assets/Game/Endpoint/endpoint_01.png", UriKind.Relative)) };
            EndpointCords = endpointCords;
        }
    }
}
