using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class OnPointerDownMessage : MonoBehaviour, IPointerDownHandler
{
    public Action Action;

    public void OnPointerDown(PointerEventData eventData)
    {
        //Action();
        
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("prescionoo");
    }
}
