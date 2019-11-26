using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeVer2
{
    /// <summary>
    /// Class containing the code used to create and manage a square for a snake gameboard
    /// </summary>
    class Square : Label
    {
        public bool isFruit;

        Panel panel;//panel on which to place the square

        public const int SIZE = 10;//pixel size of squares

        public static Color defaultColor = Color.Brown;
        public static Color fruitColor = Color.Yellow;

        /// <summary>
        /// creates a square in the specified position on the panel
        /// </summary>
        /// <param name="isFruit">Decides if the square should be a fruit</param>
        /// <param name="x"> x co-ordinate </param>
        /// <param name="y"> y co-ordinate </param>
        /// <param name="Panel"> Specifies the panel on which to display the square </param>
        public Square(bool isFruit, int x, int y, Panel panel)
        {
            this.isFruit = isFruit;

            this.AutoSize = false;
            this.Location = new System.Drawing.Point(y, x);
            this.Size = new System.Drawing.Size(SIZE, SIZE);
            this.BackColor = defaultColor;

            //put the square on the panel
            this.panel = panel;
            add();
        }

        /// <summary>
        /// Removes this square from the panel 
        /// </summary>
        public void remove()
        {
            panel.Controls.Remove(this);
        }

        /// <summary>
        /// adds this square to the panel
        /// </summary>
        public void add()
        {
            panel.Controls.Add(this);
        }
    }
}
