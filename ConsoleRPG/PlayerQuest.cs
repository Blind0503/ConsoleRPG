using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    public class PlayerQuest
    {
        public Quest Details;
        public bool IsComplete;

        public PlayerQuest(Quest details, bool isComplete)
        {
            Details = details;
            IsComplete = isComplete;
        }
    }
}
