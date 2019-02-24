using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Puzzle_A_Star_Algoritma.Puzzle
{
    public partial class SolveBox : UserControl
    {
        private MoveWay dimension;
        private int order;
        private Color color;
        private Color defColor = Color.DarkViolet;

        public SolveBox()
        {
            InitializeComponent();
           // pictureBox1.Parent = button1;
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label1.Location=new Point(label1.Location.X-6,label1.Location.Y-5);
            Color= defColor;
        }

        public SolveBox(int order,MoveWay dimension,Color color) : this()
        {
            this.dimension = dimension;
            this.order = order;
            
            if (color!=null)
            {
                Color = color;
            }
            label1.Text = order.ToString();

            switch (dimension)
            {
                case MoveWay.Left:
                    pictureBox1.BackgroundImage = arrows.left;
                    break;
                case MoveWay.Right:
                    pictureBox1.BackgroundImage = arrows.right;
                    break;
                case MoveWay.Up:
                    pictureBox1.BackgroundImage = arrows.up;
                    break;
                case MoveWay.Down:
                    pictureBox1.BackgroundImage = arrows.down;
                    break;
            }
        }

        public MoveWay Dimension { get => dimension; set => dimension = value; }
        public int Order { get => order; set => order = value; }
        public Color Color
        {
            get => color;
            set
            {
                button1.FlatAppearance.BorderColor = value;
                color = value;
            }
        }
    }
}
