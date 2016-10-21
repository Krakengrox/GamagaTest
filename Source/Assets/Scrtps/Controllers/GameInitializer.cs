using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

/// <summary>
/// Initializer all classes and assigned delegates
/// </summary>
public class GameInitializer : MonoBehaviour
{
    #region Varriables

    /// <summary>
    /// player instance
    /// </summary>
    Player player = null;

    /// <summary>
    /// Reset data
    /// </summary>
    public bool resetData = false;

    /// <summary>
    /// Automatic level load system instance
    /// </summary>
    LevelLoad levelLoad;

    /// <summary>
    /// List of all Levels
    /// </summary>
    public GameObject[] levels;
    
    /// <summary>
    /// Enemy Manager instance
    /// </summary>
    EnemyManager enemyManager;

    /// <summary>
    /// Item Manager Instance
    /// </summary>
    ItemManager itemManager;

    /// <summary>
    /// UI Game objects 
    /// </summary>
    [SerializeField]
    public FinalGame finalEvent;
    [SerializeField]
    ModelController modelController;
    [SerializeField]
    UiController uiController;
    #endregion

    #region Methods
    void Start()
    {
        this.levelLoad = new LevelLoad(this.levels[0]);
        this.levelLoad.InitLoad();
        this.enemyManager = new EnemyManager(levelLoad.FindEnemies(), this.modelController.enemyData);
        this.itemManager = new ItemManager(levelLoad.FindItems(), this.modelController.itemData);
        player = new Player(this.modelController.playerData, GameObject.Find("Charat"));
        player.IamDead += GameOver;
        Pause(0);
        uiController.startGame += Pause;
        this.finalEvent.gameOver += GameOver;
        InitMenuBars();
        player.HitMe += uiController.uiPlayerController.ReduceHpAmount;
    }

    /// <summary>
    /// Init bars of player healt, o2
    /// </summary>
    void InitMenuBars()
    {
        this.uiController.uiPlayerController.ResetFills(this.modelController.playerData.maxPlayerHealt, this.modelController.playerData.player02);
    }

    void Update()
    {
        if (resetData)
        {
            this.modelController.ResetAllData();
            resetData = false;
        }

    }
    
    /// <summary>
    /// Control final game and pause when finish
    /// </summary>
    void GameOver()
    {
        Pause(0);
        this.uiController.FinalGame();
        this.uiController.uiFinalMenu.ShowFinalCount(modelController.playerData.playerItemCount);
    }

    /// <summary>
    /// Pause control
    /// </summary>
    /// <param name="time"></param>
    void Pause(int time)
    {
        Time.timeScale = time;
    }

    /// <summary>
    /// Reset Game Method
    /// </summary>
    void Reset()
    {
        SceneManager.LoadScene("Main");
    }

    #endregion
}
