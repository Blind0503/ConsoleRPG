using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    public class Quest
    {
        public int ID;
        public string Name;
        public string Description;
        public int RewardExperiencePoints;
        public int RewardGold;
        public int RewardItem;
        public List<QuestCompletionItem> QuestCompletionItems;

        public Quest(int iD, string name, string description, int rewardExperiencePoints, int rewardGold, List<QuestCompletionItem> questCompletionItems)
        {
            ID = iD;
            Name = name;
            Description = description;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            QuestCompletionItems = questCompletionItems;
        }
    }
}
