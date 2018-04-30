using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_at_the_Races
{
    public partial class Form1 : Form
    {
        Greyhound[] GreyhoundArray = new Greyhound[4];
        Guy[] GuysArray = new Guy[3];
        Random MyRandomizer = new Random();
        public Form1()
        {
            InitializeComponent();
            minimumBetLabel.Text = "Minimum Bet : " + numericUpDown1.Minimum.ToString() + " pounds";
            //初始化四个Greyhound对象
            GreyhoundArray[0] = new Greyhound()
            {
                MyPictureBox = pictureBox1,
                StartingPosition = pictureBox1.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox1.Width,
                Randmizer = MyRandomizer
            };
            GreyhoundArray[1] = new Greyhound()
            {
                MyPictureBox = pictureBox2,
                StartingPosition = pictureBox2.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox2.Width,
                Randmizer = MyRandomizer
            };
            GreyhoundArray[2] = new Greyhound()
            {
                MyPictureBox = pictureBox3,
                StartingPosition = pictureBox3.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox3.Width,
                Randmizer = MyRandomizer
            };
            GreyhoundArray[3] = new Greyhound()
            {
                MyPictureBox = pictureBox4,
                StartingPosition = pictureBox4.Left,
                RacetrackLength = racetrackPictureBox.Width - pictureBox4.Width,
                Randmizer = MyRandomizer
            };
            //初始化三个Guy对象
            GuysArray[0] = new Guy()
            {
                Name = "Joe",
                MyBet = null,
                Cash = 50,
                MyRadionButton = JoeRadioButton,
                MyLabel = joebetlabel
            };
            GuysArray[1] = new Guy()
            {
                Name = "Bob",
                MyBet = null,
                Cash = 75,
                MyRadionButton = BobRadioButton,
                MyLabel = bobbetlabel
            };
            GuysArray[2] = new Guy()
            {
                Name = "Al",
                MyBet = null,
                Cash = 45,
                MyRadionButton = AlRadioButton,
                MyLabel = albetlabel
            };
            for(int i=0;i<3;i++)
            {
                GuysArray[i].UpdateLabels();
                //GuysArray[i].MyBet = new Bet();
            }
        }

        private void racebutton_Click(object sender, EventArgs e)
        {
            bettingParlor.Enabled = false;//比赛过程不允许下注
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (GreyhoundArray[i].Run())
                {
                    timer1.Stop();
                    i++;
                    MessageBox.Show("Dog #" + i + " won the race","We have a winner");
                    foreach (Greyhound temp in GreyhoundArray)
                    {
                        temp.TakeStartingPosition();
                    }
                    for(int j=0;j<3;j++)
                    {
                        if (GuysArray[j].MyBet != null)
                        {
                            GuysArray[j].Collect(i);
                            //GuysArray[j].ClearBet();
                        }
                    }
                    bettingParlor.Enabled = true;
                    break;
                }
            }
        }

        private void betsbutton_Click(object sender, EventArgs e)
        {
            if(JoeRadioButton.Checked)
            {
                bool flag = GuysArray[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                if(flag)
                {
                    joebetlabel.Text = GuysArray[0].MyBet.GetDescription();
                }
                else
                {
                    MessageBox.Show("Joe didn't have enough money!");
                }
            }
            else if(BobRadioButton.Checked)
            {
                bool flag = GuysArray[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                if (flag)
                {
                    bobbetlabel.Text = GuysArray[1].MyBet.GetDescription();
                }
                else
                {
                    MessageBox.Show("Bob didn't have enough money!");
                }
            }
            else if(AlRadioButton.Checked)
            {
                bool flag = GuysArray[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                if (flag)
                {
                    albetlabel.Text = GuysArray[2].MyBet.GetDescription();
                }
                else
                {
                    MessageBox.Show("Al didn't have enough money!");
                }
            }
        }

        private void JoeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            namelabel.Text = "Joe";
        }

        private void BobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            namelabel.Text = "Bob";
        }

        private void AlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            namelabel.Text = "Al";
        }
    }
}
