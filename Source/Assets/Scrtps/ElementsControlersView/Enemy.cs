using UnityEngine;
using System.Collections.Generic;
using System;

public class Enemy : GameElement, IEnemyType
{
    public override GameObject elementObject { get; set; }

    public EnemyData enemyData { get; set; }

    public override Rigidbody rb { get; protected set; }

    public override ELEMENTTYPE elemetSide { get { return ELEMENTTYPE.ENEMY; } set { this.elemetSide = value; } }

    public ENEMYTYPE enemyType { get; set; }

    public override Detector detector { get; protected set; }

    public override ElementStatus status { get; set; }

    public Enemy(EnemyData enemyData, GameObject prefab, ENEMYTYPE enemyType)
    {
        this.enemyData = enemyData;
        this.elementObject = prefab;
        this.enemyType = enemyType;
        this.elementObject.AddComponent<GEComponent>().gameElement = this;
        this.detector = this.elementObject.AddComponent<Detector>();
        InitComponent();
    }

    public void InitComponent()
    {
        switch (enemyType)
        {
            case ENEMYTYPE.RANGE:
                this.detector.actionCollision += RangeAtack;
                this.detector.stay = true;
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
        target.ChangeStats(ELEMENTSTATS.HEAL, this.enemyData.enemyHitDamage);
        this.elementObject.AddComponent<MoveComponent>().Init(target, enemyData.enemySpeed, enemyData.enemyHitDamage);
        this.elementObject.GetComponent<Animator>().enabled = false;
    }

    public void RangeAtack(GameElement target, bool enter)
    {
        GameObject bullet = GameObject.Instantiate(Resources.Load("Prefabs/Bullets")) as GameObject;
        bullet.transform.position = this.elementObject.transform.position;
        bullet.AddComponent<MoveComponent>().Init(target, enemyData.bulletsSpeed, enemyData.enemyBulletsDamage);
    }
}
