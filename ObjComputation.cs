using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_GAME_O
{
    class ObjComputation
    {
        //Global Declaration
        String[,] XOs = { {"","",""}, {"","",""}, {"","",""} };
        Boolean isX = true;
        String XO;
        String PlyrX_Name, PlyrO_Name;
        int setRow, setCol, setBlock;
        int PlyrX_Points, PlyrO_Points;
        int CountMarks;
        Boolean setPlayAgain;
        Boolean closeGame = false;
        Boolean ContChking = true;

        public void setPlayers(String setPlyrXname, String setPlyrOname)
        {
            PlyrX_Name = setPlyrXname;
            PlyrO_Name = setPlyrOname;
        }

        public Boolean isPlayer_Input_Exist(int InputRow, int InputCol, int BlockNum)
        {
            setRow = InputRow; setCol = InputCol; setBlock = BlockNum;
            setPlayAgain = false; 
            if (XOs[InputRow, InputCol].Equals(""))
            {
                if (isX)
                {
                    XOs[InputRow, InputCol] = "X";
                    isX = false;
                    XO = ("X");
                }
                else
                {
                    XOs[InputRow, InputCol] = "O";
                    isX = true;
                    XO = ("O");
                }
                CountMarks++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int UndoMove()
        {
            if (XOs[setRow, setCol].Equals("X"))
            {
                isX = true;
            }
            else if (XOs[setRow, setCol].Equals("O"))
            {
                isX = false;
            }
            XOs[setRow, setCol] = "";
            return setBlock;
        }

        public int getRow()
        {
            return setRow;
        }

        public int getCol()
        {
            return setCol;
        }

        public String Display_XorO()
        {
            return XO;
        }

        public void CheckMatch()
        {
            ContChking = true;
            int countCrosses1 = 0, countCrosses2 = 0, countCrosses3 = 0, countCrosses4 = 0;
            int countNoughts1 = 0, countNoughts2 = 0, countNoughts3 = 0, countNoughts4 = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (XOs[i, j].Equals("X") && ContChking==true)
                    {
                        countCrosses1++;
                         if (countCrosses1 == 3)
                        {
                            DisWinMsg(PlyrX_Name);
                            PlyrX_Points++;
                            ContChking = false;
                        }
                    }
                    if (XOs[j, i].Equals("X") && ContChking == true)
                    {
                        countCrosses2++;
                        if (countCrosses2 == 3)
                        {
                            DisWinMsg(PlyrX_Name);
                            PlyrX_Points++;
                            ContChking = false;
                        }
                    }
                    if (XOs[j, j].Equals("X") && ContChking == true)
                    {
                        countCrosses3++;
                        if (countCrosses3 == 3)
                        {
                            DisWinMsg(PlyrX_Name);
                            PlyrX_Points++;
                            ContChking = false;
                        }
                    }
                    if (XOs[j, (2 - j)].Equals("X") && ContChking == true)
                    {
                        countCrosses4++;
                        if (countCrosses4 == 3)
                        {
                            DisWinMsg(PlyrX_Name);
                            PlyrX_Points++;
                            ContChking = false;
                        }
                    }

                    //--------------------------------------------------------------------------

                    if (XOs[i, j].Equals("O") && ContChking == true)
                    {
                        countNoughts1++;
                        if (countNoughts1 == 3)
                        {
                            DisWinMsg(PlyrO_Name);
                            PlyrO_Points++;
                            ContChking = false;
                        }
                    }
                    if (XOs[j, i].Equals("O") && ContChking == true)
                    {
                        countNoughts2++;
                        if (countNoughts2 == 3)
                        {
                            DisWinMsg(PlyrO_Name);
                            PlyrO_Points++;
                            ContChking = false;
                        }
                    }
                    if (XOs[j, j].Equals("O") && ContChking == true)
                    {
                        countNoughts3++;
                        if (countNoughts3 == 3)
                        {
                            DisWinMsg(PlyrO_Name);
                            PlyrO_Points++;
                            ContChking = false;
                        }
                    }
                    if (XOs[j, (2 - j)].Equals("O") && ContChking == true)
                    {
                        countNoughts4++;
                        if (countNoughts4 == 3)
                        {
                            DisWinMsg(PlyrO_Name);
                            PlyrO_Points++;
                            ContChking = false;
                        }
                    }

                }
                countCrosses1 = 0; countCrosses2 = 0; countCrosses3 = 0; countCrosses4 = 0;
                countNoughts1 = 0; countNoughts2 = 0; countNoughts3 = 0; countNoughts4 = 0;
            }
                isTie();
        }

        public void DisWinMsg(String Winner)
        {
            WriteTxtFile(Winner, DateTime.Now.ToString("dd-MM-yyyy"), DateTime.Now.ToString("HH:mm:ss"));

            DialogResult res =  MessageBox.Show("'"+Winner.ToUpper()+"' You Have Won!!! Congradutations!!!"+
                "\n\n Do You Wish To Play Again?", "WANT TO CONTINUE...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (res == DialogResult.Yes)
            {
                initialize_XOs();
                setPlayAgain = true;
                CountMarks = 0;
            }
            else if (res == DialogResult.No)
            {
                setPlayAgain = false;
                closeGame = true;
            }
            
        }

        public Boolean isPlayAgain()
        {
            return setPlayAgain;
        }

        public Boolean isGameClosed()
        {
            return closeGame;
        }

        public void initialize_XOs()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    XOs[i, j] = "";
                }
            }
        }

        public int getPLyr_X_Pts()
        {
            return PlyrX_Points;
        }

        public int getPLyr_O_Pts()
        {
            return PlyrO_Points;
        }

        public void isTie()
        {
            if (ContChking && CountMarks==9)
            {
                PlyrX_Points++; PlyrO_Points++;
                DialogResult res = MessageBox.Show("There Is a Tie!!!" +
               "\n\n Do You Wish To Play Again?", "WANT TO CONTINUE...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (res == DialogResult.Yes)
                {
                    initialize_XOs();
                    setPlayAgain = true;
                }
                else if (res == DialogResult.No)
                {
                    setPlayAgain = false;
                }
            }
            
        }

        public String [,] getReadTxtFile()
        {
            
            String [] getLines = String.Join("\n",File.ReadAllLines(@"List of Winners.txt")).Split('\n');
            String[,] getWinnerInfo = new string[getLines.Length, 3];
            for (int i = 0; i < getLines.Length; i++)
            {
                String[] getElememts = getLines[i].Split('@');
                for (int j = 0; j < getElememts.Length; j++)
                {
                    getWinnerInfo[i, j] = getElememts[j];
                }
            }
            return getWinnerInfo;
        }

        public void WriteTxtFile(String getPlyrName, String getDate, String getTime)
        {
            using (StreamWriter write = new StreamWriter(@"List of Winners.txt", true))
            {
                write.WriteLine(getPlyrName + "@" + getDate + "@" + getTime);
            }
            String[] getLines = String.Join("\n", File.ReadAllLines(@"List of Winners.txt")).Split('\n');
            String[] reWrite = new String[getLines.Length];
            if (getLines.Length>1)
            {
                reWrite[0] = getLines[getLines.Length-1];
                reWrite[1] = getLines[0];
                
                 for (int i = 1; i < getLines.Length-1; i++)
                 {
                    reWrite[i+1] = getLines[i];
                 }
            }
            else
            {
                reWrite[0] = getLines[0];
            }

            if (getLines.Length>14)
            {
                reWrite[14] = "";
            }
            File.WriteAllLines(@"List of Winners.txt", reWrite);
        }

        public void ClearTxtFile()
        {
            FileStream clear = new FileStream(@"List of Winners.txt",FileMode.Create);
            clear.Close();
            
        }
    }
}
