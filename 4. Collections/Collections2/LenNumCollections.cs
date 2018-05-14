using System.Collections.Generic;
using System.Text;

namespace Collections2
{
    public class LenNumCollections
    {
        private readonly List<LenNum> collections;

        public LenNumCollections()
        {
            collections = new List<LenNum>();
        }

        public void Add(LenNum lenNum)
        {
            var index = Search(lenNum);
            if (index >= 0)
            {
                collections[index].IncNum();
            }
            else
            {
                collections.Insert(-index - 1, lenNum);
            }
        }

        private int Search(LenNum lenNum)
        {
            return collections.BinarySearch(lenNum);
        }

        public string Print()
        {
            collections.Sort(new NumLenComparator());
            var prn = new StringBuilder();
            foreach (var lenNum in collections)
            {
                prn.AppendLine(lenNum.ToString());
            }

            return prn.ToString();
        }
    }
}