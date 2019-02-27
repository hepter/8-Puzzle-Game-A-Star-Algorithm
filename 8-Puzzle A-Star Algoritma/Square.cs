﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace _8_Puzzle_A_Star_Algoritma
{
    public partial class Square : UserControl
    {
        private Color color;
        private int number;

        public Square()
        {
            InitializeComponent();
            label1.Text = "0";
            WireAllControls(this);
        }

        public Square(int number, SquareState pos) : this()
        {
            Pos = pos;
            this.number = number;
        }

        public int Number
        {
            get => number;
            set
            {
                number = value;
                label1.Text = number.ToString();
            }
        }

        public SquareState Pos { get; }

        public Color BorderColor
        {
            get => color == null ? Color.Gray : color;
            set
            {
                color = value;
                button1.FlatAppearance.BorderColor = value;
            }
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
            InvokeOnClick(this, EventArgs.Empty);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}