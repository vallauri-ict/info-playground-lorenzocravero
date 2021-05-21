using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfacce_1
{
    class MyComponent : IDispAggiuntivo
    {
        private int _id;
        private bool _status;
        public int id { get => _id; set => _id = value; }

        public bool status => _status;

        public void connetti(string s)
        {
            _status = true;
            id++;
            MessageBox.Show("Connesso a " + s);
        }

        public void disconnetti(string s)
        {
            _status = false;
            MessageBox.Show("Disconesso da " + s);
        }

        public void Stato()
        {
            if (status)
            {
                MessageBox.Show("Attualmente connnesso con id: "+id);
            }
            else
            {
                MessageBox.Show("Non connesso");
            }
        }
    }
}
