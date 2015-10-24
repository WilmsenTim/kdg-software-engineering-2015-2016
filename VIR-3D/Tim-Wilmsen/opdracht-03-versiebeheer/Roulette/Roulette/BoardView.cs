using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public partial class BoardView : UserControl
    {
        private BoardController _controllerBoard;
        public Label boardLbl;
        public BoardView(BoardController BoardC)
        {
            InitializeComponent();

            _controllerBoard = BoardC;
            Number.Font = new Font(Number.Font.FontFamily, Number.Font.Size, Number.Font.Style);
            Number.ForeColor = Color.White;
            boardLbl = Number;






        }

        public void setColour()
        {
            int currentNumber = Int32.Parse(Number.Text);
            //Console.WriteLine(currentNumber);
            if ((currentNumber > 0 && currentNumber < 11) || (currentNumber > 18))
            {
                if (IsOdd(currentNumber))
                {
                    Number.BackColor = Color.Red;
                }
                else
                {
                    Number.BackColor = Color.Black;
                }

            }
            else
            {
                if (IsOdd(currentNumber))
                {
                    Number.BackColor = Color.Black;
                }
                else
                {
                    Number.BackColor = Color.Red;
                }
            }
        }

        public void setNumber(int nr)
        {
            Number.Text = nr.ToString();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {

        }
        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }
    }


}
