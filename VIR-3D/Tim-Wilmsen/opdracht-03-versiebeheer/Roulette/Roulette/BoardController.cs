using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class BoardController
    {
        private BoardView _boardView;

        public BoardController()
        {
            _boardView = new BoardView(this);
        }

        public BoardView getView()
        {
            return _boardView;
        }


    }
}
