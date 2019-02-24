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
    public partial class Square : UserControl
    {
        private int number;
        private SquareState pos;
        private Color color;

        public int Number
        {
            get => number;
            set
            {
                number = value;
                label1.Text = number.ToString();
            }
        }

        public SquareState Pos { get => pos; }
        public Color Color
        {
            get => color==null?Color.DeepSkyBlue:color;
            set 
            { 
                color = value;
                button1.FlatAppearance.BorderColor = value;
            }
        }

        public Square()
        {  
            InitializeComponent();
            label1.Text = "0";
            WireAllControls(this);
        }

        private void WireAllControls(Control cont)
        {
            foreach (Control ctl in cont.Controls)
            {
                ctl.Click += ctl_Click;
                if (ctl.HasChildren)
                {
                    WireAllControls(ctl);
                }
            }
        }

        private void ctl_Click(object sender, EventArgs e)
        {
           // SlideEvent(this,EventArgs.Empty);
            this.InvokeOnClick(this, EventArgs.Empty); 
            
        }

        public Square(int number, SquareState pos) : this()
        {
           
            this.pos = pos;
            this.number = number;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
