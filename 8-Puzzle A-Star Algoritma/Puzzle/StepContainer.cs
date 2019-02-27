using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Puzzle_A_Star_Algoritma.Puzzle
{
    class StepContainer:IList<Step>
    {
        List<Step> s= new List<Step>();

      public  Step GetBestAndDeleteNode
        {

            get
            {
                int min = 0;
                for (int i = 0; i < s.Count; i++) 
                {
                    if (s[i].GetLast().FScore < s[min].GetLast().FScore)
                    {
                        min = i;
                    }
                }
                if (s.Count()==0)
                {
                    return null;
                }
                var bak = s[min];
                s.RemoveAt(min);
                return bak;
            }
        }


        public bool IsCompleted()
        {
            foreach (Step sss in s)
            {
                if (sss.GetLast().FScore==0)
                {
                    return true;
                }
            }
            return false;
        }

        public Step GetCompletedRoot()
        {
            if (!IsCompleted())
                return null;

            foreach (Step sss in s)
            {
                if (sss.GetLast().FScore==0)
                    return sss;
            }
            return null;
        }

        public IEnumerator<Step> GetEnumerator()
        {
            return s.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return GetEnumerator();
        }

        public void Add(Step item)
        {
           s.Add(item);
        }

        public void Clear()
        {
            s.Clear();
        }

        public bool Contains(Step item)
        {
           return s.Contains(item);
        }
        public bool ContainsNode(Step s)
        {
            foreach (Step ss in this.s)
            {
                if (ss.CurrentPuzzle.SequenceEqual(s.CurrentPuzzle))
                {
                    return true;
                }
            }
            return false;
        }
     
        public void CopyTo(Step[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Step item)
        {
         return  s.Remove(item);
        }

        public int Count
        {
            get
            {
                return s.Count();
            }
        }
        public bool IsReadOnly
        {
            get { return false; }
        }
        public int IndexOf(Step item)
        {
            return s.IndexOf(item);
        }

        public void Insert(int index, Step item)
        {
           s.Insert(index,item);
        }

        public void RemoveAt(int index)
        {
          s.RemoveAt(index);
        }
        public Step this[int index]
        {
            get
            {
                return s[index];
            }
            set
            {
                s[index]=value;
            }
        }
        
    }
}
