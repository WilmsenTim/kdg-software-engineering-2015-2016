using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roulette
{
    public partial class Roulette : Form
    {
        public Roulette()
        {
            InitializeComponent();
        }

        private void Roulette_Load(object sender, EventArgs e)
        {
            int aantalNummers = 1;
            int marginHorizontal = 5;
            int marginVertical = 5;
            int marginLeftFromNumbers = 50;

            List<SpinController> spin = new List<SpinController>();


            for (int spinNummer = 0; spinNummer < aantalNummers; ++spinNummer)
            {
                // Maak instantie aan van spinController
                SpinController tijdelijkeTeerling = new SpinController();

                spin.Add(tijdelijkeTeerling);
            }

            // spin tonen
            for (int spinNummer = 0; spinNummer < aantalNummers; ++spinNummer)
            {
                // Maak instantie aan van spinController
                SpinView spinView = spin[spinNummer].getView();

                // breedte van spinner ophalen en positie berekenen (0 * breedte spin, ...)
                int horizontalPosition = spinNummer * spinView.Width;

                spinView.Location = new System.Drawing.Point(horizontalPosition, 0);

                Controls.Add(spinView);
            }


            List<BoardController> numbers = new List<BoardController>();
            //controllers maken
            for (int i = 0; i < 36; i++)
            {
                BoardController tmpBoardControl = new BoardController();
                numbers.Add(tmpBoardControl);
            }

            //variabelen om grid te maken
            int heightAmount = 0;
            int widthAmount = 0;

            //laten zien
            for (int i = 0; i < 36; i++)
            {
                BoardView boardView = numbers[i].getView();


                int horizontalPosition = aantalNummers * spin[0].getView().Width + marginLeftFromNumbers + widthAmount * (boardView.Width + marginHorizontal);
                int verticalPosition = heightAmount * (boardView.Height + marginVertical);
                boardView.Location = new System.Drawing.Point(horizontalPosition, verticalPosition);
                heightAmount++;
                if (heightAmount == 3)
                {
                    heightAmount = 0;
                    widthAmount++;
                }

                boardView.setNumber(i + 1);
                boardView.setColour();
                Controls.Add(boardView);
            }
        }
    }
}
