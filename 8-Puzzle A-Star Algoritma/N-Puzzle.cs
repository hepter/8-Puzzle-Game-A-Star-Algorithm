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

        public N_Puzzle()
        {
            InitializeComponent();
        }

        private void BoxClick_Event(object sender, EventArgs e)
        {
            (sender as Square).SlideMove();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(square8.GetEmptyWayLocOrder());
            square6.SlideMove();
            
        }

        private void N_Puzzle_Load(object sender, EventArgs e)
        {
           
        }
    }
}
