using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Associated all enemy GameObject in the level with an instance of one enemy class
/// </summary>
public class ObstaclesManager
{
    #region Variables
    /// <summary>
    /// Enemy List in the level
    /// </summary>
    List<Transform> obstacles = null;

    /// <summary>
    /// Enemy instance
    /// </summary>
    Obstacle obstacle = null;

    /// <summary>
    /// Enemy Data
    /// </summary>
    ObstacleData obstacleData;
    #endregion

    #region Methods
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="enemies">list of enemy</param>
    /// <param name="enemyData"></param>
    public ObstaclesManager(List<Transform> obstacles, ObstacleData obstacleData)
    {
        this.obstacles = obstacles;
        this.obstacleData = obstacleData;
        CreatedEnemies();
    }

    /// <summary>
    /// Create all Enemy
    /// </summary>
    void CreatedEnemies()
    {
        for (int i = 0; i < obstacles.Count; i++)
        {
            if (obstacles[i].name == "Obstacles")
            {
                obstacle = new Obstacle(this.obstacleData, obstacles[i].gameObject);
            }
            else
            {
                obstacle = new Obstacle(this.obstacleData, obstacles[i].gameObject);
            }

        }
    }
    #endregion
}


