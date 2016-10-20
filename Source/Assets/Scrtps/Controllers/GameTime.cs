using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameTime : MonoBehaviour
{
    int timerInGame = 0;
    int timeDuration = 30;
    Action endGame;
    bool gamePause;
    bool initGame;

    public Text clockText;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(TimerTest());

    }

    void Update()
    {
        //if (initGame)
        //{
        //    if (gamePause)
        //    {

        //    }
        //}

    }
    IEnumerator TimerTest()
    {
        while (timerInGame <= timeDuration && !gamePause)
        {
            timerInGame += 1;
            clockText.text = timerInGame.ToString();
            yield return new WaitForSeconds(1);
        }

    }
}
