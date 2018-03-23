using System.Collections.Generic;
using System.Linq;

namespace football_nonsense
{
    public class MultiGameParser
    {
        private readonly IData _dataRepository;

        public MultiGameParser(IData dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public IEnumerable<Game> GetGames()
        {
            return _dataRepository.GetData().Select(i => new RawGameParser(i).ParseGame());
        }
    }
}