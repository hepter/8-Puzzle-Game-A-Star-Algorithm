using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _8_Puzzle_A_Star_Algoritma
{
    public partial class N_Puzzle : UserControl
    {
        public N_Puzzle()
        {
            InitializeComponent();
        }

        public bool IsBusy { get; set; }

        public int[] GetSequentalOrder
        {
            get
            {
                List<int> list = new List<int>();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        list.Add((tableLayoutPanel1?.GetControlFromPosition(j, i) as Square)?.Number ?? 0);
                    }
                }

                return list.ToArray();
            }
        }

        Color SetSquareDefaultColor
        {
            set
            {
                foreach (Square sq in tableLayoutPanel1.Controls.OfType<Square>())
                {
                    sq.BorderColor = value;
                }
            }

        }

        public event EventHandler SlideEvent;

        public static bool isSolvable(int[] BasePuzzle, int[] currentPuzzle)
        {
            int invr = 0;
            for (int i = 0; i < 9; i++)
            for (int j = i + 1; j < 9; j++)
            for (int k = 0; k < Array.IndexOf(currentPuzzle, BasePuzzle[i]); k++)
                if (currentPuzzle[k] == BasePuzzle[j] && BasePuzzle[i] != 0 && BasePuzzle[j] != 0)
                    invr++;
            if (invr % 2 == 0) return true;
            return false;
        }

        public void Reset()
        {
            List<Square> list = tableLayoutPanel1.Controls.OfType<Square>().OrderBy(a => a.Number).ToList();
            tableLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2 && i == 2)
                    {
                        continue;
                    }

                    tableLayoutPanel1.Controls.Add(list[i * 3 + j], j, i);
                }
            }
        }

        public void Shuffle()
        {
            do
            {
                List<Square> list = tableLayoutPanel1.Controls.OfType<Square>().ToList();
                list.Add(null);
                List<Square> newList = new List<Square>();
                int[,] matrix = new int[3, 3];

                Random rnd = new Random();

                while (list.Count > 0)
                {
                    int r = rnd.Next(0, list.Count);
                    newList.Add(list[r]);
                    list.RemoveAt(r);
                }

                tableLayoutPanel1.Controls.Clear();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        var obj = newList[i * 3 + j];
                        if (obj == null)
                        {
                            matrix[i, j] = obj?.Number ?? 0;
                            continue;
                        }

                        matrix[i, j] = obj.Number;

                        tableLayoutPanel1.Controls.Add(obj, i, j);
                    }
                }
            } while (!isSolvable(PuzzleDriver.BasePuzzleOrder, GetSequentalOrder));
        }

        private void BoxClick_Event(object sender, EventArgs e)
        {
            var s = sender as Square;
            s.BorderColor = Color.Blue   ;
            IsBusy = true;
            s.SlideMove();
            IsBusy = false;
            s.BorderColor = Color.Gray;
        }

        public void Slide(MoveWay way)
        {
            Point p = GetEmptySpaceLoc();
            var tb = tableLayoutPanel1;
            switch (way)
            {
                case MoveWay.Left:
                    p.Offset(1, 0);
                    break;
                case MoveWay.Right:
                    p.Offset(-1, 0);
                    break;
                case MoveWay.Up:
                    p.Offset(0, 1);
                    break;
                case MoveWay.Down:
                    p.Offset(0, -1);
                    break;
            }

            (tb.GetControlFromPosition(p.X, p.Y) as Square).SlideMove();
        }

        private Point GetEmptySpaceLoc()
        {
            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    if (tableLayoutPanel1?.GetControlFromPosition(k, l) == null)
                    {
                        return new Point(k, l);
                    }
                }
            }

            return new Point(2, 2);
        }


        private void N_Puzzle_Load(object sender, EventArgs e)
        {
        }

        private void square8_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void square5_Load(object sender, EventArgs e)
        {
        }
    }
}