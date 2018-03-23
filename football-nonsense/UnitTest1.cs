using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using footballnonsense;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace football_nonsense
{
    [TestClass]
    public class UnitTest1
    {
        private readonly DataStub _dataRepository;
        private Game _game1;
        private Game _game2;
        private string RawGame1 => "Bournemouth 0-1 Aston Villa";
        private string RawGame2 => "Chelsea 2-2 Swansea";

        public UnitTest1()
        {
            _dataRepository = new DataStub();
            _game1 = new Game("Bournemouth", "Aston Villa", 0, 1);
            _game2 = new Game("Chelsea", "Swansea", 2, 2);
        }

        [TestMethod]
        public void ParseGame() => Assert.AreEqual(_game1, new RawGameParser(RawGame1).ParseGame());

        [TestMethod]
        public void Parse2Games() => Assert.AreEqual(_game2, new RawGameParser(RawGame2).ParseGame());

        [TestMethod]
        public void ParseMultiGames()
        {
            _dataRepository.GetData = () => new[] { RawGame1, RawGame2 };
            CollectionAssert.AreEqual(new[] { _game1, _game2 }, new MultiGameParser(_dataRepository).GetGames().ToArray());
        }

        [TestMethod]
        public void GamePlayed()
        {
            var league = new League().GamePlayed(_game1);

            var testLeague = new League()
            {
                Positions = new List<LeagueResult>()
                {
                    new LeagueResult()
                    {
                        Team = new Team("Liverpool"),
                        GamesPlayed = 1,
                        Won = 1,
                        Drawn = 0,
                        Lost = 0,
                        Points = 3,
                        PointsAgainst = 1,
                        PointsFor = 2,
                        PointsDifference = 1
                    }

                }
            };

            throw new NotImplementedException();
            //Assert.AreEqual(testLeague.Positions.Take(1) new[], new LeagueResult(new Game("Liverpool", "Wigan, 2, 1")));
        }
    }

    public class League
    {
        public IEnumerable<LeagueResult> Positions { get; set; }

        public object GamePlayed(Game game1)
        {
            throw new NotImplementedException();
        }
    }

    public class LeagueResult
    {
        public Team Team { get; set; }
        public int GamesPlayed { get; set; }
        public int Won { get; set; }
        public int Lost { get; set; }
        public int Drawn { get; set; }
        public int PointsFor { get; set; }
        public int PointsAgainst { get; set; }
        public int PointsDifference { get; set; }
        public int Points { get; set; }
    }
}

