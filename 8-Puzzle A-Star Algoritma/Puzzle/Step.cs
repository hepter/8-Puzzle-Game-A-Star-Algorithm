using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_Puzzle_A_Star_Algoritma.Puzzle
{
    public class Step
    {
        private Step _last;
        private Tuple<int[], int, int> _tempFScore; //seq,gscore,f
        private int[] basePuzzle;
        private int[] currentPuzzle;
        private bool isDone;

        public Step(int g, int[] basePuzzle, int[] currentPuzzle)
        {
            GScore = g;
            this.basePuzzle = basePuzzle;
            this.currentPuzzle = currentPuzzle;
            if (currentPuzzle != null && currentPuzzle.Length != 0)
            {
                IsMoved = true;
            }
        }


        public int GScore { get; set; }

        public int[] CurrentPuzzle
        {
            get => currentPuzzle.ToArray();
            set => currentPuzzle = value;
        }

        public MoveWay Way { get; set; }


        public int FScore
        {
            get
            {
                if (_tempFScore != null && GScore == _tempFScore.Item2 &&
                    currentPuzzle.SequenceEqual(_tempFScore.Item1))
                {
                    return _tempFScore.Item3;
                }


                int fs = PuzzleDriver.FScore(basePuzzle, CurrentPuzzle, GScore);
                _tempFScore = new Tuple<int[], int, int>(CurrentPuzzle, GScore, fs);
                if (fs == 0)
                    isDone = true;
                return fs;
            }
        }

        public Step Stage { get; set; }
        public bool IsMoved { get; set; }

        public Step Move(MoveWay way)
        {
            //this.way = way;
            var s = new Step(GScore, basePuzzle, CurrentPuzzle.SimulateSlideMove(way)?.OfType<int>().ToArray());
            s.Way = way;
            return s;
        }

        public int GetNodeDepth()
        {
            int i = 1;
            var test = Stage;
            while (test != null)
            {
                i++;
                test = test.Stage;
            }

            return i;
        }

        public Step Clone()
        {
            //deep copy
            var stp = new Step(GScore, basePuzzle.ToArray(), currentPuzzle);
            stp.Way = Way;

            var bak = this;
            var bak2 = stp;
            while (bak.Stage != null)
            {
                bak = bak.Stage;
                bak2.Stage = new Step(bak.GScore, bak.basePuzzle.ToArray(), bak.currentPuzzle);
                ;
                bak2.Stage.Way = bak.Way;
                bak2 = bak2.Stage;
            }

            return stp;
        }

        public bool Contains(Step s)
        {
            var test = Stage;
            while (test != null)
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
            while (test != null)
            {
                bak = test;
                test = test.Stage;
            }

            bak.Stage = s;
            _last = s;
            bak.Stage.GScore = bak.GScore + 1;
            return this;
        }

        public Step GetLast()
        {
            if (_last != null)
                return _last;

            var test = Stage;
            var backup = this;
            while (test != null)
            {
                backup = test;
                test = test.Stage;
            }

            return backup;
        }

        public List<MoveWay> GetSolve()
        {
            List<MoveWay> temp = new List<MoveWay>();

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