using System;

using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace SnakeVer2
{
    /// <summary>
    /// Contains the methods for creating and moving a snake on a gameboard
    /// </summary>
    class Snake
    {
        Gameboard board;//board on which the snake is placed

        public List<Point> parts = new List<Point>();
        private Point addNewHere;//used when growing the snake

        public int speed = 100;//lower is faster

        public enum Direction { UP, DOWN, LEFT, RIGHT };
        public Direction direction = Direction.UP;

        //(other default colors are defined in the square class)
        public static Color snakeColor = Color.Red;
        public static Color snakeHeadColor = Color.Green;

        public bool dead = false;

        /// <summary>
        /// Creates a new snake on the gameboard at the position defined by the parameters
        /// </summary>
        /// <param name="board"> the board on which to place the snake </param>
        /// <param name="startX"> the starting X position of the snake </param>
        /// <param name="startY"> the starting Y position of the snake </param>
        /// <param name="snakeSpeed">The speed at which the snake will move accross the gameboard</param>
        public Snake(Gameboard board, int startX, int startY, int snakeSpeed)
        {
            //add the first part of the snake to the list
            parts.Add(new Point(startX, startY));

            //used when testing to create a snake of lenght of more than one
            createTest();

            //initialise the board variable and show the snake on the board
            this.board = board;
            this.speed = snakeSpeed;
            show();
        }

        /// <summary>
        /// Displays the parts of the snake on the gamebaord
        /// </summary>
        private void show()
        {
            board.showSnake(this);
        }

        /// <summary>
        /// Hides the parts of the snake form the gameboard
        /// </summary>
        public void hide()
        {
            board.hideSnake(this);
        }

        /// <summary>
        /// Hides the snake in its current position,
        /// calculates the co-ordinates of the the new positions for the parts of the snake
        /// Shows the snake at the new position
        /// </summary>
        public void update()
        {
            hide();

            Point[] newPositions = new Point[parts.Count];//temp array 

            //move each part into the space of the next part, apart from the head
            for (int i = parts.Count - 1; i > 0; i--)
            {
                newPositions[i] = parts[i - 1];
            }

            //move the head
            newPositions[0] = getNewHeadPosition();

            addNewHere = parts[parts.Count - 1];//saves the bit on the end where a new part should be added
            parts = newPositions.ToList();

            //check if fruit is eaten, in which case add new part at end of snake
            if (parts[0] == board.fruit)
            {
                parts.Add(addNewHere);
                board.showFruit();
            }

            //check if snake has eaten itself
            if (isDead())
            {
                dead = true;
            }

            show();

        }

        /// <summary>
        /// Either moves the head up, down, left, right or loops the snake around the board
        /// </summary>
        /// <returns> the new point where the head should be shown </returns>
        private Point getNewHeadPosition()
        {
            int x = parts[0].X;
            int y = parts[0].Y;

            if (direction == Direction.UP)
            {
                y--;
                if (y < 0) y = board.gridSize - 1;
            }
            if (direction == Direction.DOWN)
            {
                y++;
                if (y >= board.gridSize) y = 0;
            }
            if (direction == Direction.LEFT)
            {
                x--;
                if (x < 0) x = board.gridSize - 1;
            }
            if (direction == Direction.RIGHT)
            {
                x++;
                if (x >= board.gridSize) x = 0;
            }

            return new Point(x, y);
        }

        /// <summary>
        /// Used in testing, generates a  snake of multiple parts at the very start
        /// </summary>
        private void createTest()
        {
            int length = 1;
            for (int i = 1; i < length; i++)
            {
                parts.Add(new Point(parts[0].X, parts[0].Y + i));
            }
        }

        /// <summary>
        /// Checks if the snake has eaten itself by looking to see if a part is in the same place as another part
        /// </summary>
        /// <returns>true if dead, false if alive</returns>
        private bool isDead()
        {
            for(int i = 1; i < parts.Count; i++)
            {
                if (parts[0] == parts[i]) return true;
            }
            return false;//if it gets this far, the snake is not dead
        }

        /// <summary>
        /// Simply returns the length of the snake
        /// </summary>
        /// <returns></returns>
        public int getScore()
        {
            return parts.Count;
        }
    }
}
