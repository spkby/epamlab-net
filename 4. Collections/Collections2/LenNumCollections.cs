using System.Collections.Generic;
using System.Text;

namespace Collections2
{
    public class LenNumCollections
    {
        private List<LenNum> collections;

        public LenNumCollections()
        {
            collections = new List<LenNum>();
        }

        public void Add(int len)
        {
            var index = Search(len);
            if (index >= 0)
            {
                collections[index].Increment();
            }
            else
            {
                collections.Add(new LenNum(len));
            }
        }

        public int Search(int len)
        {
            collections.Sort(new LenComparator());
            return collections.BinarySearch(new LenNum(len), new LenComparator());
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