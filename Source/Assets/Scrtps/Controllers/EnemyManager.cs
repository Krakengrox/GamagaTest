using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Associated all enemy GameObject in the level with an instance of one enemy class
/// </summary>
public class EnemyManager
{
    #region Variables
    /// <summary>
    /// Enemy List in the level
    /// </summary>
    List<Transform> enemies = null;

    /// <summary>
    /// Enemy instance
    /// </summary>
    Enemy enemy = null;

    /// <summary>
    /// Enemy Data
    /// </summary>
    EnemyData enemyData;
    #endregion

    #region Methods
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="enemies">list of enemy</param>
    /// <param name="enemyData"></param>
    public EnemyManager(List<Transform> enemies, EnemyData enemyData)
    {
        this.enemies = enemies;
        this.enemyData = enemyData;
        CreatedEnemies();
    }

    /// <summary>
    /// Create all Enemy
    /// </summary>
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
    #endregion
}


