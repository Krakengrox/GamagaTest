using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

/// <summary>
/// Component that capture events onpointer and return callback
/// </summary>
public class EventsTest : MonoBehaviour, IPointerDownHandler, IPointerClickHandler
{
    #region Variables
    public bool down;
    public Action<bool, string> changeState;
    public String side;
    #endregion

    #region Methods
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
    #endregion

}
