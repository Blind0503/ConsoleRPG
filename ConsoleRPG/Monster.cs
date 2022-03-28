using System;
using System.Collections.Generic;
using System.Text;

namespace CRPG
{
    public class Monster : LivingCreature
    {
        public int ID;
        public string Name;
        public int MaximumDamage;
        public int RewardExperiencePoints;
        public int RewardGold;
        public List<LootItem> LootTable;

        public Monster(int iD, string name, int maximumDamage, int rewardExperiancePoints, int rewardGold, int currentHitPoints, int maximumHitPoints): base(currentHitPoints, maximumHitPoints)
        {
            ID = iD;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiancePoints;
            RewardGold = rewardGold;
            LootTable = new List<LootItem>();
        }
    }
}
