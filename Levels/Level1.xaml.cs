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
    /// Class that creates Level 1 for the Game
    /// It will be updated when the class Level(Allows to create different levels using mutual functionality) will be created
    /// </summary>
    public partial class Level1 : Window
    {
        public Wall WallBlock { get; set; }         // Reference to the object of type Wall
        public Floor FloorBlock { get; set; }        // Reference to the object of type Floor
        public Player Character { get; set; }         // Reference to the object of type Player
        private int[,] ExteriorWallsCords { get; set; }   // 2D Array that stores Exterior Wall Coordinates (Always the same) { x,y }, { x,y }
        private int[,] InteriorWallsCords { get; set; }   // 2D Array that stores Interior Wall Coordinates (Always the same) { x,y }, { x,y }
        public Level1()
        {
            InitializeComponent();
            GameGrid.Focusable = true;              // Sets property of game grid so it can be focused
            GameGrid.Focus();                       // Sets focus on the game grid so game can capture keys
            SetupEvents();
            BuildMap();
        }
        public void BuildMap()              // Method that is responsible for building a map
        {
            FillWithFloor();      // Invokes flooring method at the beginning so all of the tiles are filled before walls come in


            // Those are cords where wall object are to be stored
            ExteriorWallsCords = new int[40, 2] { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 },{ 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, { 10, 0 }, { 11, 0 }, { 0, 9 }, { 1, 9 }, { 2, 9 }, { 3, 9 }, { 4, 9 }, { 5, 9 }, { 6, 9 }, { 7, 9 }, { 8, 9 }, { 9, 9 }, { 10, 9 }, { 11, 9 }, { 0, 1 }, { 0, 2 }, { 0, 3 }, { 0, 4 }, { 0, 5 }, { 0, 6 }, { 0, 7 }, { 0, 8 }, { 11, 1 }, { 11, 2 }, { 11, 3 }, { 11, 4 }, { 11, 5 }, { 11, 6 }, { 11, 7 }, { 11,  8} };
            InteriorWallsCords = new int[14, 2] { { 3, 6 }, { 3, 7 }, { 3, 8 },{ 4, 6 },{ 5, 1 }, { 5, 2 }, { 5, 3 }, { 5, 5 },{ 5, 6 },{ 6, 5 },{ 7, 6 },{ 7, 7 },{ 8, 3 },{ 8, 7 } };

            for(int x = 0; x < 40; x++) // Exterior Walls Builder
            {
                WallBlock = new Wall(0);  // Creates new instances of the wall object every iteration

                this.GameGrid.Children.Add(WallBlock.Block);           // Then each instance is added to the grid
                Grid.SetColumn(WallBlock.Block, ExteriorWallsCords[x, 0]);  // And its postion is set
                Grid.SetRow(WallBlock.Block, ExteriorWallsCords[x, 1]);
            }

            for (int y = 0; y < 14; y++) // Interior Walls Builder
            {
                WallBlock = new Wall(0);    // Creates new instances of the wall object every iteration

                this.GameGrid.Children.Add(WallBlock.Block);             // Then each instance is added to the grid
                Grid.SetColumn(WallBlock.Block, InteriorWallsCords[y, 0]);        // And its postion is set
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
        }       // Puts floor tile on every grid element 
        private void SpawnPlayer()          // Creates player instance and spawns it on the map   
        {
            Character = new Player(new int[] { 9, 7 }); // Creates instance of class Player and sets its coordinates
            this.GameGrid.Children.Add(Character.PlayerImg);          // Player added to the grid
            Grid.SetColumn(Character.PlayerImg, Character.PlayerCords[0]);  // And it is postion is set using its coords
            Grid.SetRow(Character.PlayerImg, Character.PlayerCords[1]);
        }
        private void SetupEvents()   // Method that assigns all event handlers
        {
            GameGrid.KeyDown += Movement;
        }
        private void Movement(object sender, KeyEventArgs e)  // Function that moves player around map
        {                                                     // It captures pressed keys and passes them to the Player Class Methods

            Character.Movement(e);              // Changes player coordinates to new postion but not moving it yet

            bool blocked = false;      // It is flag that indicates if targeted tile is wall or not

            for(int i = 0; i < 40; i++)
            {
                if(ExteriorWallsCords[i, 0] == Character.PlayerCords[0] && ExteriorWallsCords[i, 1] == Character.PlayerCords[1])
                {
                    blocked = true;
                }
            }    // Checks arrays storing wall coordinates to check if target tile is a wall or not
            for (int x = 0; x < 14; x++)
            {
                if (InteriorWallsCords[x, 0] == Character.PlayerCords[0] && InteriorWallsCords[x, 1] == Character.PlayerCords[1])
                {
                    blocked = true;
                }
            }

            if(blocked == true)       // If target tile is a wall changes back player coordinates
            {
                switch(e.Key)
                {
                    case Key.Up: Character.PlayerCords[1] += 1; break;
                    case Key.Down: Character.PlayerCords[1] -= 1; break;
                    case Key.Left: Character.PlayerCords[0] += 1; break;
                    case Key.Right: Character.PlayerCords[0] -= 1; break;
                }
            }
            else           // If target tile is not a wall leaves changed coordinates and moves character to target tile
            {
                Grid.SetColumn(Character.PlayerImg, Character.PlayerCords[0]);
                Grid.SetRow(Character.PlayerImg, Character.PlayerCords[1]);
            }

            
        }
    }
}
