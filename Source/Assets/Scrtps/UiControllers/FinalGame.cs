using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Controll Final Game
/// </summary>
public class FinalGame : MonoBehaviour
{

    public Action gameOver;

    void OnTriggerEnter()
    {
        gameOver();

    }
}
