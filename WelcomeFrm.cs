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
    public partial class WelcomeFrm : Form
    {
        public WelcomeFrm()
        {
            InitializeComponent();
            labPlay.Parent = labBacGrd;
            labPlay.MouseEnter += LabPlay_MouseEnter;

            labWinners.Parent = labBacGrd;
            labWinners.MouseEnter += LabWinners_MouseEnter;

            labExit.Parent = labBacGrd;
            labExit.MouseEnter += LabExit_MouseEnter;
        }

        private void LabExit_MouseEnter(object sender, EventArgs e)
        {
            labExit.Cursor = Cursors.Hand;
        }

        private void LabWinners_MouseEnter(object sender, EventArgs e)
        {
            labWinners.Cursor = Cursors.Hand;
        }

        private void LabPlay_MouseEnter(object sender, EventArgs e)
        {
            labPlay.Cursor = Cursors.Hand;
        }

        private void labPlay_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void labWinners_Click(object sender, EventArgs e)
        {
            MainFrm frm = new MainFrm();
            this.Hide();
            frm.Tab3();
            frm.FillWinTbl();
            frm.ShowDialog();
            this.Dispose();
        }

        private void labExit_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Are You Sure You Want To Exit!!!","Confirm Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (choice == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
