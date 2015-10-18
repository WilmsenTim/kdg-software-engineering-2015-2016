using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace YahtzeeTeerling
{
    public class WerpController
    {
        private WerpModel _model;
        private WerpView _view;

        public WerpController()
        {
            _model = new WerpModel();
            _view = new WerpView(this);
        }

        public void addTeerlingen(List<TeerlingController> teerlingen)
        {
            _model.teerlingen = teerlingen;
        }

     
        public void werpAlles()
        {
            List<TeerlingController> teerlingen = _model.teerlingen;
    
            foreach(TeerlingController teerling in teerlingen)
            {
                teerling.werpTeerling();
                Thread.Sleep(10); //we wachten even omdat de primitieve random tijd als seed gebruikt. Fucking Microsoft...
                teerling.getView().BackColor = Color.Red;
                teerling._model.isVast = true;
                teerling.getView().updateView(teerling._model.teerling.ToString());
            }
            
        }

        public WerpModel getModel()
        {
            return _model;
        }

        public WerpView getView()
        {
            return _view;
        }
    }
}
