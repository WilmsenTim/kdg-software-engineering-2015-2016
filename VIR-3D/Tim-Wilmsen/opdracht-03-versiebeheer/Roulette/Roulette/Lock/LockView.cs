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
    public partial class LockView : UserControl
    {

        private LockController _lockController;

        public LockView(LockController lockC)
        {
            InitializeComponent();
            _lockController = lockC;
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {

        }
    }
}
