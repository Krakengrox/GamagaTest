using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class GameInitializer : MonoBehaviour
{
    #region Varriables
    Player player = null;
    public bool reset = false;
    public Tap tapCanvas;
    public int time = 0;
    LevelLoad levelLoad;
    //public GameData gameData;
    public GameData initGameData;
    public GameObject[] levels;
    EnemyManager enemyManager;
    ItemManager itemManager;
    public ModelController modelController;
    #endregion

    #region Methods
    void Start()
    {
        this.levelLoad = new LevelLoad(this.levels[0]);
        this.levelLoad.InitLoad();
        this.enemyManager = new EnemyManager(levelLoad.FindEnemies(), this.modelController.enemyData);
        this.itemManager = new ItemManager(levelLoad.FindItems(), this.modelController.itemData);
        player = new Player(this.modelController.playerData, GameObject.Find("Charat"), this.tapCanvas);

    }

    void Pause()
    {
        Time.timeScale = time;
    }

    void Reset()
    {
        SceneManager.LoadScene("Main");
    }
    #endregion
}
