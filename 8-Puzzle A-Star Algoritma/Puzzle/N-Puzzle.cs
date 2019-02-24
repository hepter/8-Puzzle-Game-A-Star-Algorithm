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

        public N_Puzzle()
        {
            InitializeComponent();
        }

        public void Shuffle()
        {
            List<Square> list =tableLayoutPanel1.Controls.OfType<Square>().ToList();
            list.Add(null);
            List<Square> newList =new List<Square>();

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
                        continue;
                    tableLayoutPanel1.Controls.Add(obj,i,j);  
                }              
            }
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
    }
}
