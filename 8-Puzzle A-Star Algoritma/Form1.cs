using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
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
               // Application.DoEvents();
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
            button3.Enabled = true;
            label3.Text = "0";

            var aa = n_Puzzle1.GetSolveViaAStar();
            flowLayoutPanel1.Controls.Clear();
            if (aa == null) return;

            int i = 0;
            foreach (var way in aa)
            {
                i++;
                SolveBox box = new SolveBox(i, way, Color.DarkViolet);
                box.Size = new Size(64, 64);
                flowLayoutPanel1.Controls.Add(box);
            }

            label2.Text = aa.Count.ToString();
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
    }
}