using UnityEngine;
using System.Collections;

[CreateAssetMenu(fileName = "Data", menuName = "EnemyData", order = 2)]
public class EnemyData : ScriptableObject
{

    public string objectName = "EnemyData";

    public int enemySpeed = 0;
    public int enemyHitDamage = 0;
    public int enemyBulletsDamage = 0;
    public int bulletsSpeed = 0;

}
