using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _8_Puzzle_A_Star_Algoritma;
namespace _8_Puzzle_A_Star_Algoritma.Puzzle
{
    public class Step 
    {
        private Step _stage=null;
        private int g = 0;
        private int[] basePuzzle;
        private int[] currentPuzzle;
        private bool isMoved = false;
        private bool isDone=false;
        private MoveWay way;
        public Step(int g, int[] basePuzzle,int[] currentPuzzle)
        {
            GScore = g;
            this.basePuzzle = basePuzzle;
            this.currentPuzzle = currentPuzzle;
            if (currentPuzzle!=null&& currentPuzzle.Length!=0)
            {
                isMoved = true;
            }
        }



        public int GScore
        {
            get { return g; }
            set { g = value; }
        }
        public int[] CurrentPuzzle { get => currentPuzzle.Cast<int>().ToArray(); set => currentPuzzle = value; }
        public MoveWay Way { get => way; set => way = value; }

        public int FScore
        {
            get
            {
                int fs = PuzzleDriver.FScore(basePuzzle, CurrentPuzzle, GScore);
                if (fs==0)
                {
                    isDone = true;
                }
                return fs;
            }

        }

        public Step Stage { get => _stage; set => _stage = value; }
        public bool IsMoved { get => isMoved; set => isMoved = value; }
        public bool IsDone { get => isDone; set => isDone = value; }

        public Step Move(MoveWay way)
        {
            //this.way = way;
            var s = new Step(GScore, basePuzzle, CurrentPuzzle.SimulateSlideMove(way)?.OfType<int>().ToArray());
            s.way = way;
            return s;
        }

        public int GetNodeDepth()
        {
            int i = 1;
            var test = Stage;
            while (test!=null)
            {
                i++;
                test = test.Stage;
            }

            return i;
        }

        public Step Clone()
        {
            //deep copy
            var stp= new Step(GScore,basePuzzle.ToArray(),currentPuzzle);
            stp.way =this.way;
            
            var bak = this;
            var bak2 = stp;
            while (bak.Stage!=null)
            {
                bak = bak.Stage;
                bak2.Stage = new Step(bak.GScore,bak.basePuzzle.ToArray(),bak.currentPuzzle);;
                bak2.Stage.way =bak.way;
                bak2 = bak2.Stage;

            }

            return stp;
        }

        public bool Contains(Step s)
        {

            var test = Stage;
            while (test!=null)
            {
                if (test.currentPuzzle.SequenceEqual(s.currentPuzzle))
                {
                    return true;
                }
                test = test.Stage;
            }

            return false;
        }
        public Step Add(Step s)
        {
            var test = this;
            var bak = this;
            while (test!=null)
            {
                bak = test;
                test = test.Stage;
            }

            bak.Stage = s;
            bak.Stage.GScore = bak.GScore+1;
            return this;
        }
        public Step GetLast()
        {
            var test = Stage;
            var bak = this;
            while (test!=null)
            {
                bak = test;
                test = test.Stage;
            }

            return bak;
        }

        public List<MoveWay> GetSolve()
        {
            List<MoveWay> temp= new List<MoveWay>();

            var test = Stage;
            while (test != null)
            {
                temp.Add(test.Way);
                test = test.Stage;
            }

            return temp.Cast<MoveWay>().Reverse().ToList();
        }
    }
}
