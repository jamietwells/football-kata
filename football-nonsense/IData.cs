using System.Collections.Generic;

namespace football_nonsense
{
    public interface IData
    {
        IEnumerable<string> GetData();
    }
}