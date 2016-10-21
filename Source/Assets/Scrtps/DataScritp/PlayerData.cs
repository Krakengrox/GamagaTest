using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "PlayerData", order = 2)]
public class PlayerData : ScriptableObject
{

    public string objectName = "PlayerData";

    public int currentPlayerHealt = 0;
    public int maxPlayerHealt = 0;
    public int playerSpeed = 0;
    public int playerItemCount = 0;
    public int player02 = 0;    

}
