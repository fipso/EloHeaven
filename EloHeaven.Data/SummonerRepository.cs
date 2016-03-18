﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloHeaven.Entities;

namespace EloHeaven.Data
{
    public class SummonerRepository : ISummonerRepository
    {
        public IEnumerable<Summoner> GetForUser(Guid userId)
        {
            Region na = new Region() {Id = 1, LeagueApiId = "NA", LongName = "North America"};

            return new[]
            {
                new Summoner() { Id = 1, LeagueApiId = 197348, Name = "Seaal", Region = na, RegionId = 1, UserId = Guid.NewGuid(), Level = 30 },
                new Summoner() { Id = 2, LeagueApiId = 19311231, Name = "IcanhasSmurf", Region = na, RegionId = 1, UserId = Guid.NewGuid(), Level = 30 },
            };
        }
    }
}