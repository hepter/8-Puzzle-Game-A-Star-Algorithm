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
        private static int[] BasePuzzleOrder = new int[] {1,2,3,4,5,6,7,8,0 };

        private static int SleepInterval = 1;
        static void Attach(this Control obje,TableLayoutPanel ParentObje)
        {
            Point orderPoint = obje.GetLocOrder(ParentObje);
           
            ParentObje.Controls.Add(obje,orderPoint.X,orderPoint.Y);
            obje.Dock = (obje.Dock == DockStyle.Fill)?obje.Dock:DockStyle.Fill;
            obje.BringToFront();
          
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

       public static int?[] SimulateSlideMove(this int[] order,MoveWay way)
       {
           int[][] grid = new int[3][];
           grid[0]= new int[3];
           grid[1]= new int[3];
           grid[2]= new int[3];

           Point emptyLoc = Point.Empty;
           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                   int item =  order[(i * 3) + j];
                   if (item==0)
                   {
                       emptyLoc=new Point(i,j);
                   }
                   grid[i][j] =item;
               }
           }
           int temp;
           switch (way)
           {
                   
               case MoveWay.Left:
                   if (emptyLoc.Y+1>2)
                       return null;
                   temp = grid[emptyLoc.X][emptyLoc.Y+1];
                   grid[emptyLoc.X ][emptyLoc.Y+1] = 0;
                   grid[emptyLoc.X][emptyLoc.Y] = temp;
                   break;
               case MoveWay.Right:
                   if (emptyLoc.Y-1<0)
                       return null;
                   temp = grid[emptyLoc.X][emptyLoc.Y-1];
                   grid[emptyLoc.X ][emptyLoc.Y-1] = 0;
                   grid[emptyLoc.X][emptyLoc.Y] = temp;
                    
                   break;
               case MoveWay.Up:
                   if (emptyLoc.X+1>2)
                       return null;
                   temp = grid[emptyLoc.X +1][emptyLoc.Y];
                   grid[emptyLoc.X+1][emptyLoc.Y] = 0;
                   grid[emptyLoc.X][emptyLoc.Y] = temp;

                   break;
               case MoveWay.Down:
                   if (emptyLoc.X-1<0)
                       return null;
                   temp = grid[emptyLoc.X -1][emptyLoc.Y];
                   grid[emptyLoc.X-1][emptyLoc.Y] = 0;
                   grid[emptyLoc.X][emptyLoc.Y] = temp;

                   break;
           }

           int?[] newOrder= new int?[9];
           for (int i = 0; i < 3; i++)
           {
               for (int j = 0; j < 3; j++)
               {
                   newOrder[(i*3)+j] = grid[i][j];
               }
           }

           return newOrder;

       }

        public static List<MoveWay> GetSolveViaAStar(this N_Puzzle puzzle )
        {
            return AStarAlgorithm(BasePuzzleOrder, puzzle.GetSequentalOrder);
        }


       static List<MoveWay> AStarAlgorithm(int[] baseOrder,int[] currentOrder,int gScore=1,List<MoveWay> solveList=null)
       {
           if (solveList == null)
           {
                solveList=new List<MoveWay>();
               if (currentOrder.SequenceEqual(baseOrder))
               {
                   return null;
               }
           }
                

           List<Tuple<int,int[],MoveWay>> instanceTuple=new List<Tuple<int, int[],MoveWay>>();
           int f;

           for (int i = 0; i < 4; i++)
           {
               int?[] newOrder = currentOrder.SimulateSlideMove((MoveWay)i);
               if (newOrder!=null)
               {

                   f=FScore(baseOrder,newOrder.Cast<int>().ToArray(),gScore);
                   instanceTuple.Add(new Tuple<int, int[],MoveWay>(f,newOrder.Cast<int>().ToArray(),(MoveWay)i));
               }
           }

           List<Tuple<int, int[],MoveWay>> sortedTuples = instanceTuple.OrderBy(a => a.Item1).ToList();
           
           solveList.Add(sortedTuples[0].Item3);
           if (sortedTuples[0].Item1==0)
           {
               return solveList;
           }
       
           return AStarAlgorithm(baseOrder, sortedTuples[0].Item2, ++gScore, solveList);
       }

       static int FScore(int[] baseOrder, int[] currentOrder,int gScore)
       {
           int f, g, h;
           h = Heuristic1(baseOrder, currentOrder);
           if (h == 0)
               return h;
           g = gScore;
           f = g + h;
           return f;
       }
       static int Heuristic1(int[] baseOrder, int[] currentOrder)
       {
          int h = 0;

           for (int i = 0; i < baseOrder.Length; i++)
           {
               if (baseOrder[i]!=currentOrder[i])
               {
                   h++;
               }
           }

           return h;
       }

    }
}
