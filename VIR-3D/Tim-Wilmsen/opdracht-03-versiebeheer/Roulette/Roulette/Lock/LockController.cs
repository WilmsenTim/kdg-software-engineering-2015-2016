using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class LockController
    {

        private LockView _lockView;
        public LockModel _lockModel;

        public LockController() {

            _lockModel = new LockModel();
            _lockView = new LockView(this);

        }

    }
}
