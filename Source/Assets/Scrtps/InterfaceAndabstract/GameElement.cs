using UnityEngine;
using System.Collections;

public abstract class GameElement
{

    public abstract ELEMENTTYPE elemetSide { get; set; }

    public abstract Rigidbody rb { get; protected set; }

    public abstract GameObject elementObject { get; set; }

    public abstract Detector detector { get; protected set; }

    public virtual ElementStatus status { get; set; }

    public virtual void ChangeStats(ELEMENTSTATS statistics, int value)
    {

    }

}
