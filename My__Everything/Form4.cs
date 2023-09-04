using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My__Everything
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

           lblDate.Parent = btnHomeWeahter;
            lblLocation.Parent = btnHomeWeahter;
            lbltemp.Parent = btnHomeWeahter;
            lblTime.Parent = btnHomeWeahter;
            lblWeek.Parent = btnHomeWeahter;

            lbltemp.Location = new Point(16, 72);
            lblDate.Location = new Point(36, 180);

            lblLocation.Location = new Point(652, 105);
            lblTime.Location = new Point(693, 145);
            lblWeek.Location = new Point(560, 180);
        }
    }
}
