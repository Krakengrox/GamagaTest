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
    public int timerInGame = 30;
    int elapseTime = 1;
    public Action<float> refreshClock;
    public Action finshTime;
    public Text clockText;
    #endregion

    #region Method
    void OnEnable()
    {
        StartCoroutine(TimerTest());
    }

    IEnumerator TimerTest()
    {
        while (timerInGame >= 0)
        {
            timerInGame -= elapseTime;
            refreshClock(elapseTime);
            yield return new WaitForSeconds(1);
        }
        finshTime();

    }
    #endregion
}
