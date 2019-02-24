using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Emf;
using _8_Puzzle_A_Star_Algoritma.Puzzle;
using Timer = System.Windows.Forms.Timer;


namespace _8_Puzzle_A_Star_Algoritma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int t = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (t++==0)
            {
                Point coor= button1.FindForm().PointToClient(button1.Parent.PointToScreen(button1.Location));

                button1.Parent = this;
                button1.Location = coor;
                button1.BringToFront();
            }
            else
            {
              //  tableLayoutPanel1.Controls.Add(button1,1,1);
            }
           

            Console.WriteLine(System.Enum.Parse(typeof(SquareState),"8"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char a, b;
            a = 'a';
            b = 'b';
            int ab ='1' & '2';
            SortedList<object,string> test=new SortedList<object, string>();
            SortedSet<int?> ttt=new SortedSet<int?>();
            ttt.Add(10);
            ttt.Add(1);
            ttt.Add(0);


        }


        private void button1_LocationChanged(object sender, EventArgs e)
        {
            Point lOnm = button1.FindForm().PointToClient(button1.Parent.PointToScreen(button1.Location));
           // label1.Text = "X:" + lOnm.X + " Y:" + lOnm.Y;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.SlideMove(MoveWay.Right);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            n_Puzzle1.Shuffle();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var aa = n_Puzzle1.GetSolveViaAStar();
            flowLayoutPanel1.Controls.Clear();

            foreach (var way in aa)
            {
                PictureBox pic = new PictureBox();
                pic.Size = new Size(50,50);
                pic.BackgroundImageLayout = ImageLayout.Zoom;
                switch (way)
                {
                    case MoveWay.Left:
                        pic.BackgroundImage = arrows.left;
                        break;
                    case MoveWay.Right:
                        pic.BackgroundImage = arrows.right;
                        break;
                    case MoveWay.Up:
                        pic.BackgroundImage = arrows.up;
                        break;
                    case MoveWay.Down:
                        pic.BackgroundImage = arrows.down;
                        break;
                }
                flowLayoutPanel1.Controls.Add(pic);

            }
        }
    }


}
