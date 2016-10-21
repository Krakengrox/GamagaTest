using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// class that creates an Item based on an GameElement within the game
/// </summary>
public class Player : GameElement
{
    #region Variables
    public PlayerData playerData { get; set; }

    public override Rigidbody rb { get; protected set; }

    public override ELEMENTTYPE elemetSide { get { return ELEMENTTYPE.ALLY; } set { elemetSide = value; } }

    public override GameObject elementObject { get; set; }

    public override Detector detector { get; protected set; }

    public override ElementStatus status { get; set; }

    public Action IamDead;

    public Action<float> HitMe;

    public Action<int> RefreshGuears;

    AutomaticMove movementController = null;
    #endregion

    #region Methods
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="prefab"></param>
    /// <param name="itemData"></param>
    public Player(PlayerData playerData, GameObject prefab)
    {
        this.playerData = playerData;
        this.elementObject = prefab;
        this.playerData.currentPlayerHealt = this.playerData.maxPlayerHealt;
        InitComponent();
    }

    void InitComponent()
    {
        this.playerData.playerItemCount = 0;
        this.elementObject.AddComponent<GEComponent>().gameElement = this;
        this.detector = this.elementObject.AddComponent<Detector>();
        this.rb = this.elementObject.GetComponent<Rigidbody>();
        this.movementController = new AutomaticMove(this, this.playerData.playerSpeed);
    }

    public override void ChangeStats(ELEMENTSTATS statistics, int value)
    {
        switch (statistics)
        {
            case ELEMENTSTATS.HEAL:
                playerData.currentPlayerHealt -= value;
                HitMe(value);
                if (playerData.currentPlayerHealt <= 0)
                {
                    playerData.currentPlayerHealt = 0;
                    this.status = ElementStatus.DEAD;
                    IamDead();
                }
                break;
            case ELEMENTSTATS.SPEED:
                playerData.playerSpeed += value;
                break;
            case ELEMENTSTATS.ITEMSCOUNT:
                playerData.playerItemCount += value;
                RefreshGuears(this.playerData.playerItemCount);
                break;
            default:
                break;
        }
    }
    #endregion
}
