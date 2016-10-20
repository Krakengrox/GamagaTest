using UnityEngine;
using System.Collections.Generic;

public class EnemyManager
{

    List<Transform> enemies = null;
    Enemy enemy = null;
    EnemyData enemyData;

    public EnemyManager(List<Transform> enemies, EnemyData enemyData)
    {
        this.enemies = enemies;
        this.enemyData = enemyData;
        CreatedEnemies();
    }

    void CreatedEnemies()
    {
        for (int i = 0; i < enemies.Count; i++)
        {
            if (enemies[i].name == "EnemyMelee")
            {
                enemy = new Enemy(this.enemyData, enemies[i].gameObject, ENEMYTYPE.MELEE);
            }
            else
            {
                enemy = new Enemy(this.enemyData, enemies[i].gameObject, ENEMYTYPE.RANGE);
            }

        }
    }

}


