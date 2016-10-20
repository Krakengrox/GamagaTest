using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class UiController : MonoBehaviour
{

    [SerializeField]
    Button startBtn, resetBtn, backInitBtm = null;

    [SerializeField]
    GameObject menuInit, resetMenu = null;

    public Action startGame = null;
    public Action finalGame = null;

    void Start()
    {
        startBtn.onClick.AddListener(StartEvent);
        resetBtn.onClick.AddListener(RestartEvent);
        backInitBtm.onClick.AddListener(BackInit);
        InitCanvas();
    }

    void InitCanvas()
    {
        menuInit.SetActive(true);
        resetMenu.SetActive(false);
    }


    void StartEvent() 
    {
        //startGame();
        menuInit.SetActive(false);
        resetMenu.SetActive(false);
    }
    
    void RestartEvent()
    {
        //finalGame();
        menuInit.SetActive(false);
        resetMenu.SetActive(false);
    }

    void BackInit()
    {
        menuInit.SetActive(true);
        resetMenu.SetActive(false);
    }


}
