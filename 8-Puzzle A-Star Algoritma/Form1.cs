using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Xpo;
using _8_Puzzle_A_Star_Algoritma.Puzzle;

namespace _8_Puzzle_A_Star_Algoritma
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }


        private int slowrefresh = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            PuzzleDriver.NodeTickEvent += (o, args) =>
            {
                label3.Text = (int.Parse(label3.Text) + 1).ToString();
                Application.DoEvents();
            };

            PuzzleDriver.NodeDepthEvent += (o, args) =>
            {
                slowrefresh++;
                if (slowrefresh==100)
                {
                    label6.Text =o.ToString();
                    slowrefresh = 0;
                }
               
              
            };
        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            button4_Click(null, null);
            n_Puzzle1.Shuffle();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            label3.Text = "0";

            List<MoveWay> solveList = n_Puzzle1.GetSolveViaAStar();
            flowLayoutPanel1.Controls.Clear();
            if (solveList != null)
            {

            

                int i = 0;
                foreach (var way in solveList)
                {
                    i++;
                    SolveBox box = new SolveBox(i, way, Color.DarkViolet);
                    box.Size = new Size(64, 64);
                    flowLayoutPanel1.Controls.Add(box);
                }
            }
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            label2.Text = solveList?.Count.ToString()??"0";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void n_Puzzle1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (SolveBox box in flowLayoutPanel1.Controls.OfType<SolveBox>())
            {
                box.Color = Color.LawnGreen;
                n_Puzzle1.Slide(box.Dimension);
               
                //Sleep(170);
            }

            button3.Enabled = false;
        }

        private void Sleep(int ms)
        {
            Stopwatch sw = Stopwatch.StartNew();
            do
            {
                Application.DoEvents();
                Thread.Sleep(1);
            } while (sw.ElapsedMilliseconds < ms);
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            PuzzleDriver.HeuristicMethod = Heuristic.manhattan;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PuzzleDriver.HeuristicMethod = Heuristic.hamming;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            n_Puzzle1.Reset();
            flowLayoutPanel1.Controls.Clear();
            label2.Text = "0";
            label3.Text = "0";
        }

        CancellationTokenSource CTS;
        private bool EditMode = true;
     
        private async void button5_Click(object sender, EventArgs e)
        {
            EditMode = !EditMode;
            if (!EditMode)
            {
                (sender as Button).Text = "KAYDET";
                

                button4.Enabled = false;
                button3.Enabled = false;
                button2.Enabled = false ;
                button1.Enabled = false;
                flowLayoutPanel1.Controls.Clear();
                CTS= new CancellationTokenSource();
                await Task.Factory.StartNew(() =>
                {
                    Color bakColor=Color.Empty;
                    bool onOff=false;
                    int exitConfirm = 0;
                    do
                    {
                        if (CTS!= null && CTS.Token.IsCancellationRequested)
                        {
                            CTS = null;
                            exitConfirm = 1;
                        }
                       
                        foreach (Square sq in n_Puzzle1.GetSquareList)
                        {
                            if (exitConfirm==1)
                            {
                                sq.BorderColor=Color.Green;
                                continue;

                            }
                            else if (exitConfirm==2)
                            {
                                sq.BorderColor=bakColor;
                                continue;
                            }
                            else if (exitConfirm==3)
                            {
                                sq.BorderColor=bakColor;
                                continue;
                            }
                            if (bakColor==Color.Empty)
                                bakColor = sq.BorderColor;

                            if (onOff)
                                sq.BorderColor=bakColor;
                            else
                                sq.BorderColor = Color.Red;
                        }

                        if (exitConfirm != 0)
                        {
                            exitConfirm++;
                            Thread.Sleep(500);
                        }

                        onOff = !onOff;
                        Thread.Sleep(500);
                        
                    } while (!(exitConfirm==3));
                },CTS.Token);

                  
            }
            else
            {
                (sender as Button).Text = "Son Durumu Düzenle";
                CTS.Cancel();
                await Task.Delay(500);
                PuzzleDriver.SetBasePuzzleOrder(n_Puzzle1.GetSequentalOrder);

                button4.Enabled = true;
                button3.Enabled = true;
                button2.Enabled = true;
                button1.Enabled = true;

            }

            
        }
    }
}