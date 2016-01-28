using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finals
{
    public partial class Frm_Final : Form
    {
        Frm_ChooseField FrmChoose = new Frm_ChooseField(); //init 3nd form
        int counter = 0;
        int failedTries = 0;
        int WaitTime = 0;
#region RandomCharacters
        string[] RndChar = {
                                   "0",
                                   "1",
                                   "2",
                                   "3",
                                   "4",
                                   "5",
                                   "6",
                                   "7",
                                   "8",
                                   "9",
                                   "A",
                                   "B",
                                   "C",
                                   "D",
                                   "E",
                                   "F",
                                   "G",
                                   "H",
                                   "I",
                                   "J",
                                   "K",
                                   "L",
                                   "M",
                                   "N",
                                   "O",
                                   "P",
                                   "Q",
                                   "R",
                                   "S",
                                   "T",
                                   "U",
                                   "V",
                                   "W",
                                   "X",
                                   "Y",
                                   "Z",
                                   "=",
                                   "+",
                                   "!",
                               };
#endregion //all the characters used during random sequence
        int RndNum1 = 0;
        int RndNum2 = 0;
        int RndNum3 = 0;
        int RndNum4 = 0;
        int RndNum5 = 0;
        int WaitingRndNum1 = 0;
        int WaitingRndNum2 = 0;
        int WaitingRndNum3 = 0;
        int WaitingRndNum4 = 0;
        int WaitingRndNum5 = 0;
        Random RndGen = new Random();
        public Frm_Final()
        {
            InitializeComponent(); //The almighty constructor
        }

        private void Pic_Runner_Click(object sender, EventArgs e)
        {
            Starter(); //runs starter, you can click anywhere to run it (pic is docked)
        }

        private void Starter() //prep the form
        {
            counter = 0;
            failedTries = 0;
            WaitTime = 0;
            Tmr_DoCounter.Start();
            Tmr_Delay10.Start();
            Lbl_Count.Text = "Count: "; 
        }

        private void changeRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChoose.ShowDialog(); //open Range Dialogue
        }

        private void Tmr_DoCounter_Tick(object sender, EventArgs e)
        {
            //this is where the magic happens
            if (counter == 0)
            {
                Tmr_DoCounter.Stop();
                RndNum1 = RndGen.Next(1, 6);
                RndNum2 = RndGen.Next(1, 6);
                RndNum3 = RndGen.Next(1, 6);
                RndNum4 = RndGen.Next(1, 6);
                RndNum5 = RndGen.Next(1, 6);
                while (RndNum1 != 1 || RndNum2 != 2 || RndNum3 != 3 || RndNum4 != 4 || RndNum5 != 5) //look to see if Numbers are correct
                {
                    failedTries++;
                    RndNum1 = RndGen.Next(1, 6);
                    RndNum2 = RndGen.Next(1, 6);
                    RndNum3 = RndGen.Next(1, 6);
                    RndNum4 = RndGen.Next(1, 6);
                    RndNum5 = RndGen.Next(1, 6);
                }
            }
            else
            {
                counter--;
            }
        }

        private void Tmr_Delay10_Tick(object sender, EventArgs e)
        {
            // a simple 10 second wait
            if (WaitTime < 10)
            {
                //generate random char
                WaitingRndNum1 = RndGen.Next((FrmChoose.MinRange), (FrmChoose.MaxRange));
                WaitingRndNum2 = RndGen.Next((FrmChoose.MinRange), (FrmChoose.MaxRange));
                WaitingRndNum3 = RndGen.Next((FrmChoose.MinRange), (FrmChoose.MaxRange));
                WaitingRndNum4 = RndGen.Next((FrmChoose.MinRange), (FrmChoose.MaxRange));
                WaitingRndNum5 = RndGen.Next((FrmChoose.MinRange), (FrmChoose.MaxRange));
                //stor random char
                Lbl_1.Text = RndChar[WaitingRndNum1];
                Lbl_2.Text = RndChar[WaitingRndNum2];
                Lbl_3.Text = RndChar[WaitingRndNum3];
                Lbl_4.Text = RndChar[WaitingRndNum4];
                Lbl_5.Text = RndChar[WaitingRndNum5];
                //increase time waited
                WaitTime++;
            }
            else
            {
                //after 10 seconds, stop and put actual values
                Tmr_Delay10.Stop();
                Lbl_1.Text = RndNum1.ToString();
                Lbl_2.Text = RndNum2.ToString();
                Lbl_3.Text = RndNum3.ToString();
                Lbl_4.Text = RndNum4.ToString();
                Lbl_5.Text = RndNum5.ToString();
                Lbl_Count.Text = "Count: " + failedTries.ToString();
            }
        }
    }
}
