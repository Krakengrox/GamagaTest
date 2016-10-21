using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Automatic association of the all elements in the game with instance class, behavior and functions 
/// (Load Level)
/// </summary>
public class LevelLoad
{
    #region Variables
    /// <summary>
    /// Game Object Level
    /// </summary>
    public GameObject levelGo;
    /// <summary>
    /// List of enemy
    /// </summary>
    public List<Transform> enemies;
    /// <summary>
    /// List of Obstacles
    /// </summary>
    public List<Transform> obstacles;
    /// <summary>
    /// List of Items
    /// </summary>
    public List<Transform> items;
    #endregion

    #region Methods
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="levelGo"></param>
    public LevelLoad(GameObject levelGo)
    {
        this.levelGo = levelGo;
        InitLoad();
    }

    /// <summary>
    /// Init List
    /// </summary>
    public void InitLoad()
    {
        this.enemies = new List<Transform>();
        this.obstacles = new List<Transform>();
        this.items = new List<Transform>();
    }

    /// <summary>
    /// Find enemies in the LevelGo
    /// </summary>
    /// <returns></returns>
    public List<Transform> FindEnemies()
    {
        Transform ts = this.levelGo.transform.FindChild("Enemies");
        foreach (Transform enemy in ts)
        {
            this.enemies.Add(enemy);
            Debug.Log(enemy.name);
        }
        return this.enemies;
    }

    /// <summary>
    /// Find Obstacles in the LevelGo
    /// </summary>
    /// <returns></returns>
    public List<Transform> FindObstacles()
    {
        Transform ts = this.levelGo.transform.FindChild("Obstacles");
        foreach (Transform obstacle in ts)
        {
            this.obstacles.Add(obstacle);
            Debug.Log(obstacle.name);
        }
        return this.obstacles;
    }

    /// <summary>
    /// Find items in the LevelGo
    /// </summary>
    /// <returns></returns>
    public List<Transform> FindItems()
    {
        Transform ts = this.levelGo.transform.FindChild("Items");
        foreach (Transform item in ts)
        {
            this.items.Add(item);
            Debug.Log(item.name);
        }
        return this.items;
    }

    /// <summary>
    /// Find StartPosition in the LevelGo
    /// </summary>
    /// <returns></returns>
    public Transform FindStart()
    {
        Transform ts = this.levelGo.transform.FindChild("Items");
        return ts;
    }

    /// <summary>
    /// Find Exit
    /// </summary>
    /// <returns></returns>
    public Transform FindExit()
    {
        Transform ts = this.levelGo.transform.FindChild("Items");
        return ts;
    }

    #endregion
}
