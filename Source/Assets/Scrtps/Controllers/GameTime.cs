using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

/// <summary>
/// Control game time (o2 Mecanichs)
/// </summary>
public class GameTime : MonoBehaviour
{
    #region variables
    int timerInGame = 0;
    int timeDuration = 30;
    Action endGame;
    bool gamePause;
    bool initGame;

    public Text clockText;
    #endregion

    #region Method
    void Start()
    {
        StartCoroutine(TimerTest());

    }

    IEnumerator TimerTest()
    {
        while (timerInGame <= timeDuration && !gamePause)
        {
            timerInGame += 1;
            //clockText.text = timerInGame.ToString();
            yield return new WaitForSeconds(1);
        }

    }
    #endregion
}
