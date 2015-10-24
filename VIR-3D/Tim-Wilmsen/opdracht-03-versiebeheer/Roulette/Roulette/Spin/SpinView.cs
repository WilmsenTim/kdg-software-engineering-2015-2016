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
    public partial class SpinView : UserControl
    {
        private SpinController _controllerSpin;

        public Label spinlbl;

        public SpinView(SpinController spinC)
        {
            InitializeComponent();
            _controllerSpin = spinC;

            Spin.Font = new Font(Spin.Font.FontFamily, Spin.Font.Size + 50f, Spin.Font.Style);
            spinlbl = Spin;
        }

        private void btn_spin_Click(object sender, EventArgs e)
        {
            _controllerSpin.spinBal();

            int nieuweWorp = _controllerSpin._spinModel.Number;

            Spin.Text = nieuweWorp.ToString();


        }
    }
}
