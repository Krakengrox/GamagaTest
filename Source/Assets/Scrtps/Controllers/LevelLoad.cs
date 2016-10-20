using UnityEngine;
using System.Collections.Generic;

public class LevelLoad
{

    public GameObject levelGo;
    public List<Transform> enemies;
    public List<Transform> obstacles;
    public List<Transform> items;

    public LevelLoad(GameObject levelGo)
    {
        this.levelGo = levelGo;
        InitLoad();
    }

    public void InitLoad()
    {
        this.enemies = new List<Transform>();
        this.obstacles = new List<Transform>();
        this.items = new List<Transform>();
    }

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
}
