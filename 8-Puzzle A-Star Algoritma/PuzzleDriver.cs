using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Puzzle_A_Star_Algoritma
{
    
   public static class PuzzleDriver
    {
        private static int SleepInterval = 1;
       
        public enum MoveWay
        {
            Left,
            Right,
            Up,
            Down
        }

        static Control Detach(this Control obje)
        {
            Control container = obje.Parent;
            Point coor= obje.FindForm().PointToClient(obje.Parent.PointToScreen(obje.Location));
            Size bak = obje.Size;
            obje.Dock = (obje.Dock == DockStyle.None)?obje.Dock:DockStyle.None;
            obje.Size = bak;
            obje.Parent = obje.Parent.Parent;
            
            obje.Location = Point.Add(coor,new Size(-2,-9));
            obje.BringToFront();
            return container;
        }
        static void Attach(this Control obje,TableLayoutPanel ParentObje)
        {
            Point orderPoint = obje.GetLocOrder(ParentObje);
           
            ParentObje.Controls.Add(obje,orderPoint.X,orderPoint.Y);
            obje.Dock = (obje.Dock == DockStyle.Fill)?obje.Dock:DockStyle.Fill;
            obje.BringToFront();
          
        }

        public static Point GetLocOrder(this Control obje, TableLayoutPanel MParentObje=null)
        {
            TableLayoutPanel ParentObje = MParentObje;
            if(ParentObje==null)
                ParentObje=obje.Parent as TableLayoutPanel;
            
            int validateLenght = ParentObje.Size.Width / 6;
            int volume = ParentObje.Size.Width / 3;
            int x=0, y=0;
            Point coor= obje.FindForm().PointToClient(obje.Parent.PointToScreen(obje.Location));

            if (coor.X+validateLenght>ParentObje.Location.X && coor.X+validateLenght<ParentObje.Location.X+volume)
                x = 0;
            else if (coor.X+validateLenght>ParentObje.Location.X + volume&& coor.X+validateLenght<ParentObje.Location.X+(volume*2))
                x = 1;
            else if  (coor.X+validateLenght>ParentObje.Location.X + (volume*2)&& coor.X+validateLenght<ParentObje.Location.X+(volume*3))
                x = 2;

            if (coor.Y+validateLenght>ParentObje.Location.Y && coor.Y+validateLenght<ParentObje.Location.Y+volume)
                y = 0;
            else if (coor.Y+validateLenght>ParentObje.Location.Y + volume && coor.Y+validateLenght<ParentObje.Location.Y+(volume*2))
                y = 1;
            else if  (coor.Y+validateLenght>ParentObje.Location.Y + (volume*2) && coor.Y+validateLenght<ParentObje.Location.Y+(volume*3))
                y = 2;
            
            return new Point(x,y);
        }

        public static void SlideMove(this Control obje)
        {
            Point NewlocOrder = obje.GetEmptyWayLocOrder();
            Point locOrder = obje.GetLocOrder();

            if (locOrder.X-1==NewlocOrder.X && locOrder.Y==NewlocOrder.Y)
                obje.SlideMove(MoveWay.Left);
            
            else if (locOrder.X+1==NewlocOrder.X && locOrder.Y==NewlocOrder.Y)
                obje.SlideMove(MoveWay.Right);
            
            else if (locOrder.X==NewlocOrder.X && locOrder.Y-1==NewlocOrder.Y)
                obje.SlideMove(MoveWay.Up);
            
            else if (locOrder.X==NewlocOrder.X && locOrder.Y+1==NewlocOrder.Y)
                obje.SlideMove(MoveWay.Down);
            
        }

        public static Point GetEmptyWayLocOrder(this Control obje)
        {
            TableLayoutPanel tlp = obje.Parent as TableLayoutPanel;
            Point loc = obje.GetLocOrder(tlp);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tlp.GetControlFromPosition(i,j)==null)
                        return new Point(i, j);
                }
                
            }
            return new Point(2,2);
        }

        public static void SlideMove(this Control obje,MoveWay move)
        {
            int speed = 2;
            
            Size parentLoc = obje.Parent.Size;
            int MoveLengt = parentLoc.Width / 3;
            TableLayoutPanel tlp = obje.Detach() as TableLayoutPanel;
            Point tempPoint = obje.Location;
            switch (move)
            {
                case MoveWay.Left:
                    for (int i = 0; i < MoveLengt; i+=speed)
                    {
                        Application.DoEvents();
                        Thread.Sleep(SleepInterval);
                        obje.Location=new Point(tempPoint.X-i,tempPoint.Y);
                    }
                    
                    break;
                case MoveWay.Right:
                    for (int i = 0; i < MoveLengt; i+=speed)
                    {
                        Application.DoEvents();
                        Thread.Sleep(SleepInterval);
                        obje.Location=new Point(tempPoint.X+i,tempPoint.Y);
                    }
                    break;
                case MoveWay.Up:
                    for (int i = 0; i < MoveLengt; i+=speed)
                    {
                        Application.DoEvents();
                        Thread.Sleep(SleepInterval);
                        obje.Location=new Point(tempPoint.X,tempPoint.Y-i);
                    }
                    break;
                case MoveWay.Down:

                    for (int i = 0; i < MoveLengt; i+=speed)
                    {
                        Application.DoEvents();
                        Thread.Sleep(SleepInterval);
                        obje.Location=new Point(tempPoint.X,tempPoint.Y+i);
                    }
                    break;
            }

            obje.Attach(tlp);

        }
    }
}
