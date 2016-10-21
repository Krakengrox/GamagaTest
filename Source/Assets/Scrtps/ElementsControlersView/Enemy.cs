using UnityEngine;
using System.Collections.Generic;
using System;

/// <summary>
/// class that creates an enemy based on an GameElement within the game
/// </summary>
public class Enemy : GameElement, IEnemyType
{
    #region Variables
    public override GameObject elementObject { get; set; }

    public EnemyData enemyData { get; set; }
    public override Rigidbody rb { get; protected set; }
    public override ELEMENTTYPE elemetSide { get { return ELEMENTTYPE.ENEMY; } set { this.elemetSide = value; } }
    public ENEMYTYPE enemyType { get; set; }
    public override Detector detector { get; protected set; }
    public override ElementStatus status { get; set; }
    #endregion

    #region Methods
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="enemyData"></param>
    /// <param name="prefab"></param>
    /// <param name="enemyType"></param>
    public Enemy(EnemyData enemyData, GameObject prefab, ENEMYTYPE enemyType)
    {
        this.enemyData = enemyData;
        this.elementObject = prefab;
        this.enemyType = enemyType;

        InitComponent();
    }

    /// <summary>
    /// Init component it needs the object
    /// </summary>
    public void InitComponent()
    {
        this.elementObject.AddComponent<GEComponent>().gameElement = this;
        this.detector = this.elementObject.AddComponent<Detector>();
        switch (enemyType)
        {
            case ENEMYTYPE.RANGE:
                this.detector.actionCollision += RangeAtack;
                break;
            case ENEMYTYPE.MELEE:
                this.detector.actionCollision += MeleeAtack;
                this.detector.enter = true;
                break;
            default:
                break;
        }
    }

    public void MeleeAtack(GameElement target, bool enter)
    {
        this.elementObject.AddComponent<MoveComponent>().Init(target, enemyData.enemySpeed, enemyData.enemyHitDamage);
        this.elementObject.GetComponent<SphereCollider>().radius = 0f;
        this.elementObject.GetComponent<Animator>().enabled = false;
    }

    public void RangeAtack(GameElement target, bool enter)
    {
        GameObject bullet = GameObject.Instantiate(Resources.Load("Prefabs/Bullets")) as GameObject;
        bullet.transform.position = this.elementObject.transform.position;
        bullet.AddComponent<MoveComponent>().Init(target, enemyData.bulletsSpeed, enemyData.enemyBulletsDamage);
    }
    #endregion
}
