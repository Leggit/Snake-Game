using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeVer2
{
    /// <summary>
    /// Class containing the code for creating a form which can be used to play a simple snake game
    /// </summary>
    public partial class Form1 : Form
    {

        Gameboard board;
        Snake snake;

        /// <summary>
        /// Makes a new form with the neccessary components
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialises the board and snake variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            board = new Gameboard(35, this.gamePanel);
            setup();
        }

        /// <summary>
        /// Creates a new snake object
        /// </summary>
        private void setup()
        {
            snake = new Snake(board, 10, 25, getSpeed());
        }

        /// <summary>
        /// Detects arrow key presses which are used to determine the direction in which the snake moves
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Note - conditions do not allow snake to go directly back on itself
            if ((keyData == Keys.Up || keyData == Keys.W) && snake.direction != Snake.Direction.DOWN)
            {
                snake.direction = Snake.Direction.UP;
                return true;
            }
            if ((keyData == Keys.Down || keyData == Keys.S) && snake.direction != Snake.Direction.UP)
            {
                snake.direction = Snake.Direction.DOWN;
                return true;
            }
            if ((keyData == Keys.Left || keyData == Keys.A) && snake.direction != Snake.Direction.RIGHT)
            {
                snake.direction = Snake.Direction.LEFT;
                return true;
            }
            if ((keyData == Keys.Right || keyData == Keys.D) && snake.direction != Snake.Direction.LEFT)
            {
                snake.direction = Snake.Direction.RIGHT;
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Shows the current length of the snake
        /// </summary>
        public void updateScore()
        {
            scoreLbl.Text = snake.getScore().ToString();
        }

        /// <summary>
        /// Either starts, pauses or restarts the game depending on the current game state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionBtn_Click(object sender, EventArgs e)
        {
            if (actionBtn.Text == "Restart") 
            {
                snake.hide();
                setup();
                gameTimer.Enabled = true;
             }
            if(actionBtn.Text == "Start")
            {
                gameTimer.Enabled = true;
                setup();
                actionBtn.Text = "Pause";
            }
            else
            {
                gameTimer.Enabled = false;
                actionBtn.Text = "Start";
            }
        }

        /// <summary>
        /// Calculates the correct value for the speed of the snake based on the setting of the
        /// speed setting trackbar
        /// </summary>
        /// <returns></returns>
        private int getSpeed()
        {
            int setting = speedSetter.Value;
            switch (setting)
            {
                case 1:
                    return 200;
                case 2:
                    return 150;
                case 3:
                    return 100;
                case 4:
                    return 70;
                case 5:
                    return 50;
            }
            return 100;//default
        }

        /// <summary>
        /// moves the snake and updates the score
        /// if snake has died this timer will disable itself and the action button will be set to restart mode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            snake.update();
            updateScore();
            gameTimer.Interval = getSpeed();

            if (snake.dead == true)
            {
                gameTimer.Enabled = false;
                actionBtn.Text = "Restart";
            }
        }
    }

}
