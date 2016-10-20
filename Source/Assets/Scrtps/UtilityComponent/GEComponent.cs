using UnityEngine;
using System.Collections;
using System;

public class GEComponent : MonoBehaviour
{
    public GameElement gameElement = null;
    public Action fixeUpdateEvent;
    public Action updateEvent;


    void FixedUpdate()
    {
        if (fixeUpdateEvent != null)
            fixeUpdateEvent();

    }

    void Update()
    {
        if (updateEvent != null)
            updateEvent();
    }
}
