using System.Collections.Generic;
using System.IO;

namespace football_nonsense
{
    public class Data : IData
    {
        public IEnumerable<string> GetData() => File.ReadAllLines("D:\\PL-2015-2016-String.csv");
    }
}