using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Puzzle_A_Star_Algoritma
{
    
    public partial class N_Puzzle : UserControl
    {
        public event EventHandler SlideEvent;
        private bool isBusy;
        
        public bool IsBusy { get => isBusy; set => isBusy = value; }

        public int[] GetSequentalOrder
        {
            get
            {
                List<int> list=new List<int>();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        list.Add((tableLayoutPanel1?.GetControlFromPosition(j,i) as Square)?.Number ?? 0);
                    }
                }
                return list.ToArray();
            }

        }
        public N_Puzzle()
        {
            InitializeComponent();
        }

        public static bool isSolvable(int[] BasePuzzle, int[] currentPuzzle)
        {
            int invr = 0;
            for (int i = 0; i < 9; i++)
                for (int j = i+1; j < 9; j++)
                    for (int k = 0; k < Array.IndexOf(currentPuzzle,BasePuzzle[i]); k++)
                        if (currentPuzzle[k] == BasePuzzle[j] && BasePuzzle[i]!=0 && BasePuzzle[j]!=0)
                            invr++;
            if (invr % 2 == 0) return true;
            return false;
        }

        public void Shuffle()
        {
            do
            {
                List<Square> list =tableLayoutPanel1.Controls.OfType<Square>().ToList();
                list.Add(null);
                List<Square> newList =new List<Square>();
                int[,]matrix = new int[3,3];

                Random rnd= new Random();

                while (list.Count>0)
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
                    
                        var obj = newList[(i * 3) + j];
                        if (obj==null)
                        {
                            matrix[i, j] = obj?.Number ?? 0;
                            continue;
                        }
                        matrix[i, j] = obj.Number;
                   
                        tableLayoutPanel1.Controls.Add(obj,i,j);  
                    }              
                }

            } while (!isSolvable(PuzzleDriver.BasePuzzleOrder,GetSequentalOrder));
          
        }

        private void BoxClick_Event(object sender, EventArgs e)
        {
            var s=(sender as Square);
            s.Color = Color.Orange;
            IsBusy = true;
            s.SlideMove();
            IsBusy = false;
            s.Color = Color.DeepSkyBlue;
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
