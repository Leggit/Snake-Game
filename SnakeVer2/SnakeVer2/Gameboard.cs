using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeVer2
{
    /// <summary>
    /// Class containing the code used to create and manage a grid of squares on which a snake game can be played
    /// </summary>
    class Gameboard
    {
        Random random = new Random();
        public Panel panel;
        public int gridSize;
        Square[,] squares;

        public Point fruit;

        /// <summary>
        /// Creates a new grid of squares on the panel input via a parameter
        /// </summary>
        /// <param name="gridSize"> the length/height of the grid to be created </param>
        /// <param name="panel"> the panel on which to place the gameboard </param>
        public Gameboard(int gridSize, Panel panel)
        {
            this.gridSize = gridSize;
            this.panel = panel;

            squares = new Square[gridSize, gridSize];

            squares = setupSquares(gridSize);//setup squares, bombs, player and end marker  

            showFruit();
        }

        /// <summary>
        /// Gets a random point on the gameboard and sets it as a fruit
        /// </summary>
        public void showFruit()
        {
            fruit = new Point(random.Next(0, gridSize), random.Next(0, gridSize));
            squares[fruit.X, fruit.Y].BackColor = Square.fruitColor;
        }

        /// <summary>
        /// Creates a 2D array of squares to be used to make the gameboard
        /// </summary>
        /// <param name="gridSize"> The width/height of the board </param>
        /// <returns></returns>
        public Square[,] setupSquares(int gridSize)
        {
            Square[,] squares = new Square[gridSize, gridSize];

            //pixel positions of the current label
            int x = 0;
            int y = 0;

            //go through each label and initialise it
            for (int i = 0; i < gridSize; i++)
            {
                x = 0;//start at the start of each row
                for (int j = 0; j < gridSize; j++)
                {
                    squares[i, j] = new Square(false, x, y, panel);

                    x += Square.SIZE;//move along the row
                }
                y += Square.SIZE;//move a row down
            }
            return squares;
        }

        /// <summary>
        /// Goes through each part of the snake and hides them by changing the color to default
        /// </summary>
        /// <param name="snake"> The snake to be hidden </param>
        internal void hideSnake(Snake snake)
        {
            foreach (Point p in snake.parts)
            {
                squares[p.X, p.Y].BackColor = Square.defaultColor;
                squares[p.X, p.Y].Image = null;
            }
        }

        /// <summary>
        /// Displays each part of the snake by changing the square colors to the snake color
        /// </summary>
        /// <param name="snake"> the snake containing the parts to be hidden </param>
        public void showSnake(Snake snake)
        {
            foreach (Point p in snake.parts)
            {
                squares[p.X, p.Y].BackColor = Snake.snakeColor;
            }
            squares[snake.parts[0].X, snake.parts[0].Y].BackColor = Snake.snakeHeadColor;
        }
    }
}
