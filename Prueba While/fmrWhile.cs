using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_While
{
    public partial class fmrWhile : Form
    {
        public fmrWhile()
        {
            InitializeComponent();
        }

        private void btPosicion_Click(object sender, EventArgs e)
        {
            actorRojo.Top = 70;
            actorAzul.Top = 70;
            actorRojo.Visible = true;
            actorAzul.Visible= true;
             
        }

        private void btMover_Click(object sender, EventArgs e)
        {
            while (((actorRojo.Left + actorRojo.Width) != actorAzul.Left))
            {
                actorRojo.Left = actorRojo.Left + 1;
                actorAzul.Left = actorAzul.Left - 1;


                this.Refresh();

                //if ((actorRojo.Left + actorRojo.Width)== actorAzul.Left)
                //{
                //    break;
                //}
            } 
        }
    }
}
