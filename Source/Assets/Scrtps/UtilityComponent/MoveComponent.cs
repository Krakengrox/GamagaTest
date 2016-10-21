using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Move Component for bullets and enemy follow
/// </summary>
public class MoveComponent : MonoBehaviour
{
    #region Variables
    public GameElement target = null;
    public bool lookAtTarget = false;
    public int speed = 0;
    Vector3 initialTargetPosition;
    int bulletDamage = 0;
    #endregion

    #region Method
    public void Init(GameElement target, int speed, int bulletDamage)
    {
        this.target = target;
        this.speed = speed;
        this.initialTargetPosition = target.elementObject.transform.position;
        this.bulletDamage = bulletDamage;
        lookAtTarget = true;
    }

    void Update()
    {
        this.transform.position += Time.deltaTime * this.speed * this.transform.forward.normalized;

        if (lookAtTarget)
        {
            this.transform.LookAt(target.elementObject.transform.position);
            lookAtTarget = false;
        }
        if ((this.transform.position - target.elementObject.transform.position).sqrMagnitude < 0.5f)
        {
            target.ChangeStats(ELEMENTSTATS.HEAL, this.bulletDamage);
            UnityEngine.Object.Destroy(this.gameObject);
        }

        if ((this.transform.position - target.elementObject.transform.position).sqrMagnitude > 30f)
        {
            UnityEngine.Object.Destroy(this.gameObject);
        }
    }

    #endregion
}
