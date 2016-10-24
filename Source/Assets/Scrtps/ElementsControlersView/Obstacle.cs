using UnityEngine;
using System.Collections;

/// <summary>
/// class that creates an Item based on an GameElement within the game
/// </summary>
public class Obstacle : GameElement
{

    #region Variables
    public override Detector detector { get; protected set; }

    public override GameObject elementObject { get; set; }

    public override ELEMENTTYPE elemetSide { get { return ELEMENTTYPE.ITEM; } set { this.elemetSide = value; } }

    public override Rigidbody rb { get; protected set; }

    public ObstacleData obstacleData { get; set; }
    #endregion

    #region Methods
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="prefab"></param>
    /// <param name="itemData"></param>
    public Obstacle(ObstacleData obstacleData, GameObject prefab)
    {
        this.obstacleData = obstacleData;
        this.elementObject = prefab;
        InitComponent();
    }

    void InitComponent()
    {
        this.elementObject.AddComponent<GEComponent>().gameElement = this;
        this.detector = this.elementObject.AddComponent<Detector>();
        this.rb = this.elementObject.GetComponent<Rigidbody>();
        this.detector.actionCollision += Test;
        this.detector.enter = true;
    }

    void Test(GameElement target, bool enter)
    {
        target.ChangeStats(ELEMENTSTATS.HEAL, this.obstacleData.damage);
        this.elementObject.SetActive(false);
    }
    #endregion

}
