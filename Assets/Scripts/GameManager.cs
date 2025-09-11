using System.Collections.Generic;
using UnityEngine;

namespace AncientGame
{
    public class GameManager : MonoBehaviour
    {
        [Header("Player Stats Data")]
        public PlayerStats playerStats;

        private static GameManager instance;

        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void AddWealth(int amount)
        {
            if (playerStats == null) { Debug.LogError("playerStats not assigned!"); return; }
            playerStats.wealth += amount;
            Debug.Log("Player Wealth = " + playerStats.wealth);
        }

        public void AddDecision(string description, int impact = 0)
        {
            if (playerStats == null) { Debug.LogError("playerStats not assigned!"); return; }
            if (playerStats.decisions == null) playerStats.decisions = new List<DecisionEntry>();

            var entry = new DecisionEntry { description = description, impact = impact };
            playerStats.decisions.Add(entry);

            Debug.Log("Decision Added: " + description);
        }
    }
}
