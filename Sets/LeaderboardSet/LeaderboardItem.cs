using UnityEngine;

[CreateAssetMenu(fileName = "LeaderboardItem", menuName = "Items/Leaderboard Item")]
public class LeaderboardItem : ScriptableObject
{

    public int Rank;
    public string Name;
    public int Time;
    
}
