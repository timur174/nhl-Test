﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HockeyApi.Models
{
    public class PlayerInjuryHealthCommand
    {
        public int playerId { get; set; }
        public DateTime effectiveDate { get; set; }
    }
}
