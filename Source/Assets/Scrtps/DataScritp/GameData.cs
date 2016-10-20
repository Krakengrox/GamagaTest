using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "GameData", order = 1)]
public class GameData : ScriptableObject
{

    public string objectName = "GameData";
    public int durationTime = 0;

    public int playerHealt = 0;
    public int playerSpeed = 0;
    public int enemySpeed = 0;
    public int enemyHitDamage = 0;
    public int enemyBulletsDamage = 0;
    public int playerItemCount = 0;
    public int valueItem = 0;

}
