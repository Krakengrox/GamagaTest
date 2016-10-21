using UnityEngine;
using System.Collections;

public class ModelController : MonoBehaviour
{

    public PlayerData playerData;
    public EnemyData enemyData;
    public ItemData itemData;
    public RankingData rankingData;

    public void ResetAllData()
    {
        this.playerData.maxPlayerHealt = GameConstans.playerHealt;
        this.playerData.playerSpeed = GameConstans.playerSpeed;
        this.playerData.playerItemCount = GameConstans.playerItemCount;

        this.enemyData.enemyBulletsDamage = GameConstans.enemyBulletsDamage;
        this.enemyData.enemyHitDamage = GameConstans.enemyHitDamage;
        this.enemyData.enemySpeed = GameConstans.enemySpeed;

        this.itemData.valueItem = GameConstans.valueItem;

        this.rankingData.firstPosition = GameConstans.rankings;
        this.rankingData.seccondPosition = GameConstans.rankings;
        this.rankingData.thirdPosition = GameConstans.rankings;


    }
}
