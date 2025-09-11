using System.Collections.Generic;
using UnityEngine;

namespace AncientGame
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "AncientGame/PlayerStats")]
    public class PlayerStats : ScriptableObject
    {
        public int wealth;
        public int ethics;
        public List<string> spiritualItems = new List<string>();
        public List<DecisionEntry> decisions = new List<DecisionEntry>();
    }
}
