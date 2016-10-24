using UnityEngine;
using System.Collections;

/// <summary>
/// Constants for all game, it help to recet data
/// </summary>
public static class GameConstans
{
    #region Variables
    public static int playerHealt = 100;
    public static int playerSpeed = 2;
    public static int playerItemCount = 0;

    public static int enemySpeed = 2;
    public static int enemyHitDamage = 50;
    public static int enemyBulletsDamage = 50;

    public static int valueItem = 1;

    public static int rankings = 0;

    public static float timeUpProgresiveBar = 0.15f;

    public static int obstacleDamage = 50;
    #endregion

}

/// <summary>
/// Defined the element type of the element.
/// </summary>
public enum ELEMENTTYPE
{
    NONE,
    ALL,
    ALLY,
    ITEM,
    ENEMY
}

/// <summary>
/// Defined the alliance of the element.
/// </summary>
public enum ENEMYTYPE
{
    NONE,
    ALL,
    RANGE,
    MELEE,
}

/// <summary>
/// List of Stats for element
/// </summary>
public enum ELEMENTSTATS
{
    NONE,
    ALL,
    HEAL,
    SPEED,
    ITEMSCOUNT,
}

/// <summary>
/// Status for the element
/// </summary>
public enum ElementStatus
{
    NONE,
    ALL,
    DEAD,
    LIVE
}

