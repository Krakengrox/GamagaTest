using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

/// <summary>
/// Control all UI in the game
/// </summary>
public class UiController : MonoBehaviour
{
    #region Variables
    public UiInitMenu uiInitMenu;

    public UiFinalMenu uiFinalMenu;

    public UiPlayerController uiPlayerController;

    [SerializeField]
    GameObject menuInit, resetMenu = null;

    public Action<int> startGame = null;
    #endregion

    #region Methods
    void Start()
    {
        this.uiInitMenu.starGameBtn.onClick.AddListener(StartGameEvent);
        this.uiFinalMenu.restartButton.onClick.AddListener(RestartEvent);
        InitCanvas();
    }

    void InitCanvas()
    {
        this.uiInitMenu.gameObject.SetActive(true);
        resetMenu.SetActive(false);
    }

    public void FinalGame()
    {
        resetMenu.SetActive(true);
    }

    void StartGameEvent()
    {
        menuInit.SetActive(false);
        resetMenu.SetActive(false);
        startGame(1);
    }

    void ReduceBarHealt(int value)
    {
        this.uiPlayerController.ReduceHpAmount(value);
    }

    void RestartEvent()
    {
        SceneManager.LoadScene(0);
    }

    #endregion

}
