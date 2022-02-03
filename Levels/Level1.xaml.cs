using Sokoban_Game___Assesment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sokoban_Game_Assesment.Levels
{
    /// <summary>
    /// Interaction logic for Level1.xaml
    /// </summary>
    public partial class Level1 : Window
    {
        public TextBlock test = new TextBlock();
        public Wall WallBlock { get; set; }
        public Floor FloorBlock { get; set; }
        public Player Character { get; set; }
        private int[,] AllCords { get; set; }
        private int[,] EmptyCords { get; set; }
        private int[,] ExteriorWallsCords { get; set; }
        private int[,] InteriorWallsCords { get; set; }
        public Level1()
        {
            InitializeComponent();
            GameGrid.Focusable = true;
            GameGrid.Focus();
            SetupEvents();
            BuildMap();
        }
        public void BuildMap()
        {
            FillWithFloor();

            AllCords = new int[2, 2] { { 0, 0 }, { 12, 10 } };
            ExteriorWallsCords = new int[40, 2] { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 },{ 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 }, { 0, 9 }, { 1, 9 }, { 2, 9 }, { 3, 9 }, { 4, 9 }, { 5, 9 }, { 6, 9 }, { 7, 9 }, { 8, 9 }, { 9, 9 }, { 10, 9 }, { 11, 9 }, { 0, 1 }, { 0, 2 }, { 0, 3 }, { 0, 4 }, { 0, 5 }, { 0, 6 }, { 0, 7 }, { 0, 8 }, { 11, 1 }, { 11, 2 }, { 11, 3 }, { 11, 4 }, { 11, 5 }, { 11, 6 }, { 11, 7 }, { 11,  8} };
            InteriorWallsCords = new int[14, 2] { { 3, 6 }, { 3, 7 }, { 3, 8 },{ 4, 6 },{ 5, 1 }, { 5, 2 }, { 5, 3 }, { 5, 5 },{ 5, 6 },{ 6, 5 },{ 7, 6 },{ 7, 7 },{ 8, 3 },{ 8, 7 } };

            for(int x = 0; x < 40; x++) // Exterior Walls Builder
            {
                WallBlock = new Wall(0);

                this.GameGrid.Children.Add(WallBlock.Block);
                Grid.SetColumn(WallBlock.Block, ExteriorWallsCords[x, 0]);
                Grid.SetRow(WallBlock.Block, ExteriorWallsCords[x, 1]);
            }

            for (int y = 0; y < 14; y++) // Interior Walls Builder
            {
                WallBlock = new Wall(0);

                this.GameGrid.Children.Add(WallBlock.Block);
                Grid.SetColumn(WallBlock.Block, InteriorWallsCords[y, 0]);
                Grid.SetRow(WallBlock.Block, InteriorWallsCords[y, 1]);
            }

            SpawnPlayer();

        }
        
        private void FillWithFloor()
        {
            for(int x = 0; x < 12; x++)
            {
                for(int y = 0; y < 10; y++)
                {
                    FloorBlock = new Floor(0);
                    this.GameGrid.Children.Add(FloorBlock.Ground);
                    Grid.SetColumn(FloorBlock.Ground, x);
                    Grid.SetRow(FloorBlock.Ground, y);
                }
            }
        }
        private void SpawnPlayer()
        {
            Character = new Player(new int[] { 9, 7 });
            this.GameGrid.Children.Add(Character.PlayerImg);
            Grid.SetColumn(Character.PlayerImg, Character.PlayerCords[0]);
            Grid.SetRow(Character.PlayerImg, Character.PlayerCords[1]);
        }
        private void SetupEvents()
        {
            GameGrid.KeyDown += Movement;
        }
        private void Movement(object sender, KeyEventArgs e)
        {
            //int[] OldCords = Character.PlayerCords;

            Character.Movement(e);

            bool blocked = false;

            for(int i = 0; i < 40; i++)
            {
                if(ExteriorWallsCords[i, 0] == Character.PlayerCords[0] && ExteriorWallsCords[i, 1] == Character.PlayerCords[1])
                {
                    blocked = true;
                }
            }
            for (int x = 0; x < 14; x++)
            {
                if (InteriorWallsCords[x, 0] == Character.PlayerCords[0] && InteriorWallsCords[x, 1] == Character.PlayerCords[1])
                {
                    blocked = true;
                }
            }

            if(blocked == true)
            {
                switch(e.Key)
                {
                    case Key.Up: Character.PlayerCords[1] += 1; break;
                    case Key.Down: Character.PlayerCords[1] -= 1; break;
                    case Key.Left: Character.PlayerCords[0] += 1; break;
                    case Key.Right: Character.PlayerCords[0] -= 1; break;
                }
            }
            else
            {
                Grid.SetColumn(Character.PlayerImg, Character.PlayerCords[0]);
                Grid.SetRow(Character.PlayerImg, Character.PlayerCords[1]);
            }

            
        }
    }
}
