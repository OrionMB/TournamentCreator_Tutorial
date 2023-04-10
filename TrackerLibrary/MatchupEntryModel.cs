using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one of the teams competing in a matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score acheived by that TeamCompeting during the matchup.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the parent object that includes all MatchupEntries
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}
