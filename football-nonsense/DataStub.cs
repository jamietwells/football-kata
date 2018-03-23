using System;
using System.Collections.Generic;
using System.Text;
using football_nonsense;

namespace footballnonsense
{
    public class DataStub : IData
    {
        public Func<IEnumerable<string>> GetData { get; set; }
    
        IEnumerable<string> IData.GetData() => GetData?.Invoke();

    }
}
