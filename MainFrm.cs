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
    public partial class MainFrm : Form
    {
        //Glabal Declaration
        ObjComputation obj = new ObjComputation();
        String PlyrX;
        String PlyrO;
        Boolean canUndo = false;
        int roundNum = 1;

        public MainFrm()
        {
            InitializeComponent();
         
            labBack.Parent = labBacGrd1;
            labForward.Parent = labBacGrd1;

            //Tab 2 Btn
            LabCnl.Parent = labBacGrd2;
            LabCnl.Cursor = Cursors.Hand;
            LabPlyrTrn.Parent = labBacGrd2;
            LabFstPlyrNam.Parent = labBacGrd2;
            LabFstPlyrNam.Parent = labBacGrd2;
            LabSecPlyrNam.Parent = labBacGrd2;
            LabFstWon.Parent = labBacGrd2;
            LabSecWon.Parent = labBacGrd2;
            LabPlyrTrn.Parent = labBacGrd2;
            LabUndo.Parent = labBacGrd2;
            LabUndo.Cursor = Cursors.Hand;
            btnClear.Cursor = Cursors.Hand;

            //Tab 1 Btn
            LabPlyrX.Parent = labBacGrd1;
            LabPlyrX.Cursor = Cursors.Hand;
            LabPlyrO.Parent = labBacGrd1;
            LabPlyrO.Cursor = Cursors.Hand;

            //Tab 3 Btn
            LabWinBck.Parent = LabBacGrd3;
            LabWinBck.Cursor = Cursors.Hand;

            //Tab 1 Display Label
            DisPlyrO.Parent = labBacGrd1;
            DisPlyrX.Parent = labBacGrd1;
            
            //Grid Btn
            LabBlock1.Parent = labBacGrd2;
            LabBlock2.Parent = labBacGrd2;
            LabBlock3.Parent = labBacGrd2;
            LabBlock4.Parent = labBacGrd2;
            LabBlock5.Parent = labBacGrd2;
            LabBlock6.Parent = labBacGrd2;
            LabBlock7.Parent = labBacGrd2;
            LabBlock8.Parent = labBacGrd2;
            LabBlock9.Parent = labBacGrd2;

            //Grid Btn
            LabBlock1.Cursor = Cursors.Hand;
            LabBlock1.MouseDown += LabBlock1_MouseDown;
            LabBlock1.MouseUp += LabBlock1_MouseUp;
            LabBlock2.Cursor = Cursors.Hand;
            LabBlock2.MouseDown += LabBlock2_MouseDown;
            LabBlock2.MouseUp += LabBlock2_MouseUp;
            LabBlock3.Cursor = Cursors.Hand;
            LabBlock3.MouseDown += LabBlock3_MouseDown;
            LabBlock3.MouseUp += LabBlock3_MouseUp;
            LabBlock4.Cursor = Cursors.Hand;
            LabBlock4.MouseDown += LabBlock4_MouseDown;
            LabBlock4.MouseUp += LabBlock4_MouseUp;
            LabBlock5.Cursor = Cursors.Hand;
            LabBlock5.MouseDown += LabBlock5_MouseDown;
            LabBlock5.MouseUp += LabBlock5_MouseUp;
            LabBlock6.Cursor = Cursors.Hand;
            LabBlock6.MouseDown += LabBlock6_MouseDown;
            LabBlock6.MouseUp += LabBlock6_MouseUp;
            LabBlock7.Cursor = Cursors.Hand;
            LabBlock7.MouseDown += LabBlock7_MouseDown;
            LabBlock7.MouseUp += LabBlock7_MouseUp;
            LabBlock8.Cursor = Cursors.Hand;
            LabBlock8.MouseDown += LabBlock8_MouseDown;
            LabBlock8.MouseUp += LabBlock8_MouseUp;
            LabBlock9.Cursor = Cursors.Hand;
            LabBlock9.MouseDown += LabBlock9_MouseDown;
            LabBlock9.MouseUp += LabBlock9_MouseUp;

            labBack.MouseEnter += LabBack_MouseEnter;
            labForward.MouseEnter += LabForward_MouseEnter;

        }

        private void LabBlock1_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock1.Cursor = Cursors.Hand;
        }

        private void LabBlock1_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock1.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(0, 0, 1))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock1.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock1.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock1.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO()+" > Marked On Row 0 Col 0");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!", "Place Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabBlock1.Cursor = Cursors.Hand;
            }
        }

        private void LabBlock2_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock2.Cursor = Cursors.Hand;
        }

        private void LabBlock2_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock2.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(0, 1, 2))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock2.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock2.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock2.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO() + " > Marked On Row 0 Col 1");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!", "Place Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabBlock2.Cursor = Cursors.Hand;
            }
        }

        private void LabBlock3_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock3.Cursor = Cursors.Hand;
        }

        private void LabBlock3_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock3.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(0, 2, 3))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock3.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock3.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock3.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO() + " > Marked On Row 0 Col 2");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!", "Place Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabBlock3.Cursor = Cursors.Hand;
            }
        }

        private void LabBlock4_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock4.Cursor = Cursors.Hand;
        }

        private void LabBlock4_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock4.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(1, 0, 4))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock4.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock4.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock4.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO() + " > Marked On Row 1 Col 0");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!", "Place Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabBlock4.Cursor = Cursors.Hand;
            }
        }

        private void LabBlock5_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock5.Cursor = Cursors.Hand;
        }

        private void LabBlock5_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock5.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(1, 1, 5))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock5.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock5.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock5.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO() + " > Marked On Row 1 Col 1");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!", "Place Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabBlock5.Cursor = Cursors.Hand;
            }
        }

        private void LabBlock6_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock6.Cursor = Cursors.Hand;
        }

        private void LabBlock6_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock6.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(1, 2, 6))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock6.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock6.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock6.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO() + " > Marked On Row 1 Col 2");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!","Place Taken",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LabBlock6.Cursor = Cursors.Hand;
            }
        }

        private void LabBlock7_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock7.Cursor = Cursors.Hand;
        }

        private void LabBlock7_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock7.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(2, 0, 7))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock7.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock7.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock7.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO() + " > Marked On Row 2 Col 0");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!", "Place Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabBlock7.Cursor = Cursors.Hand;
            }
        }

        private void LabBlock8_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock8.Cursor = Cursors.Hand;
        }

        private void LabBlock8_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock8.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(2, 1, 8))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock8.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock8.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock8.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO() + " > Marked On Row 2 Col 1");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!", "Place Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabBlock8.Cursor = Cursors.Hand;
            }
        }

        private void LabBlock9_MouseUp(object sender, MouseEventArgs e)
        {
            LabBlock9.Cursor = Cursors.Hand;
        }

        private void LabBlock9_MouseDown(object sender, MouseEventArgs e)
        {
            LabBlock9.Cursor = Cursors.Default;
            if (obj.isPlayer_Input_Exist(2, 2, 9))
            {
                if (obj.Display_XorO().Equals("O"))
                {
                    LabBlock9.ForeColor = Color.Black;
                    LabPlyrTrn.Text = PlyrX + " >>";
                }
                else
                {
                    LabBlock9.ForeColor = Color.White;
                    LabPlyrTrn.Text = PlyrO + " >>";
                }
                LabBlock9.Text = obj.Display_XorO();
                HistoryItems.Items.Add(obj.Display_XorO() + " > Marked On Row 2 Col 2");
                obj.CheckMatch();
                setPoints();
                if (obj.isPlayAgain())
                {
                    CLearBlocks();
                    setRound();
                }
                else
                {
                    closeGame();
                }
                canUndo = true;
            }
            else
            {
                MessageBox.Show("Sorry Place Already Taken, Choice Another!", "Place Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LabBlock9.Cursor = Cursors.Hand;
            }
        }

        private void LabForward_MouseEnter(object sender, EventArgs e)
        {
            labForward.Cursor = Cursors.Hand;
        }

        private void LabBack_MouseEnter(object sender, EventArgs e)
        {
            labBack.Cursor = Cursors.Hand;
        }

        public void Tab2()
        {
            TabsFrm.SelectedTab = tabPage2;
        }

        public void Tab3()
        {
            TabsFrm.SelectedTab = tabPage3;
        }

        private void labBacGrd_Click(object sender, EventArgs e)
        {
            //BackGround - nothing goes here
        }

        private void labBack_Click(object sender, EventArgs e)
        {
            WelcomeFrm frm = new WelcomeFrm();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
            
        }

        private void labForward_Click(object sender, EventArgs e)
        {

            if (!(DisPlyrX.Text.Equals("") || DisPlyrO.Text.Equals("")))
            {
                LabPlyrTrn.Text = PlyrX + " >>";
                obj.setPlayers(PlyrX, PlyrO);
                LabFstWon.Text = "Won > 0";
                LabSecWon.Text = "Won > 0";
                HistoryItems.Items.Add("<< Round 1 >>");
                FillWinTbl();
                Tab2();
            }
            else
            {
                MessageBox.Show("Please Fill In Players Name To Continue!","Invalid Input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void LabPlyrX_Click(object sender, EventArgs e)
        {
            PlyrInputFrm frm = new PlyrInputFrm();
            frm.setLabelPlyr("ENTER NAME OF PLAYER X");
            frm.ShowDialog();
            PlyrX = frm.getPlyrName();
            DisPlyrX.Text = PlyrX;
            LabFstPlyrNam.Text = PlyrX+":";


        }

        private void LabPlyrO_Click(object sender, EventArgs e)
        {
            PlyrInputFrm frm = new PlyrInputFrm();
            frm.setLabelPlyr("ENTER NAME OF PLAYER O");
            frm.ShowDialog();
            PlyrO = frm.getPlyrName();
            DisPlyrO.Text = PlyrO;
            LabSecPlyrNam.Text = PlyrO+":";
        }

        private void LabCnl_Click(object sender, EventArgs e)
        {
            WelcomeFrm frm = new WelcomeFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void LabWinBck_Click(object sender, EventArgs e)
        {
            WelcomeFrm frm = new WelcomeFrm();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void LabUndo_Click(object sender, EventArgs e)
        {
            if (canUndo)
            {
                switch (obj.UndoMove())
                {
                    case 1:
                        LabBlock1.Text = "";
                        break;
                    case 2:
                        LabBlock2.Text = "";
                        break;
                    case 3:
                        LabBlock3.Text = "";
                        break;
                    case 4:
                        LabBlock4.Text = "";
                        break;
                    case 5:
                        LabBlock5.Text = "";
                        break;
                    case 6:
                        LabBlock6.Text = "";
                        break;
                    case 7:
                        LabBlock7.Text = "";
                        break;
                    case 8:
                        LabBlock8.Text = "";
                        break;
                    case 9:
                        LabBlock9.Text = "";
                        break;
                }
                HistoryItems.Items.Add("Player " + obj.Display_XorO() + " > Undone On R" + obj.getRow() + ", C" + obj.getCol());
                canUndo = false;
            }
            else
            {
                MessageBox.Show("Can Only Undo Move Once!!!","Can't Undo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void CLearBlocks()
        {
            LabBlock1.Text = "";
            LabBlock2.Text = "";
            LabBlock3.Text = "";
            LabBlock4.Text = "";
            LabBlock5.Text = "";
            LabBlock6.Text = "";
            LabBlock7.Text = "";
            LabBlock8.Text = "";
            LabBlock9.Text = "";
        }

        public void setPoints()
        {
            LabFstWon.Text = "Won > "+obj.getPLyr_X_Pts();
            LabSecWon.Text = "Won > "+obj.getPLyr_O_Pts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            obj.ClearTxtFile();
            ListName.Clear();
            ListDate.Clear();
            ListTime.Clear();
        }

        public void FillWinTbl()
        {
            //Fill Winners Table
            String[,] WinDetails = obj.getReadTxtFile();
            for (int i = 0; i < WinDetails.GetLength(0); i++)
            {
                ListName.Items.Add(WinDetails[i, 0]);
                ListDate.Items.Add(WinDetails[i, 1]);
                ListTime.Items.Add(WinDetails[i, 2]);
            }
        }

        public void setRound()
        {
           HistoryItems.Items.Add(" << Round " + (++roundNum) + " >>");
        }

        public void closeGame()
        {
            if (obj.isGameClosed())
            {
                WelcomeFrm frm = new WelcomeFrm();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }
        }
    }
}
