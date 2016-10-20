using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class EventsTest : MonoBehaviour, IPointerDownHandler, IPointerClickHandler
{

    public bool down;
    public Action<bool, string> changeState;
    public String side;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("prescion down");
        down = true;
        changeState(down, side);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("prescion up");
        down = false;
        changeState(down, side);
    }


}
