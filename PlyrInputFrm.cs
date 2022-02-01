using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_GAME_O
{
    public partial class PlyrInputFrm : Form
    {
        //Global Declaration
        String PlyrName;
        
        public PlyrInputFrm()
        {
            InitializeComponent();
            btnCon.Cursor = Cursors.Hand;
            txtInput.KeyDown += TxtInput_KeyDown;
            

        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PlyrName = txtInput.Text;
                this.Hide();
            }
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            PlyrName = txtInput.Text;
            this.Hide();
        }

        public String getPlyrName()
        {
            return PlyrName;
        }

        public void setLabelPlyr(String setPlyrName)
        {
            LabPlyr.Text = setPlyrName;
        }
    }
}
