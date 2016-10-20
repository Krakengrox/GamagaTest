using UnityEngine;
using System.Collections;
using System;

public class Player : GameElement
{

    public PlayerData playerData { get; set; }

    public override Rigidbody rb { get; protected set; }

    public override ELEMENTTYPE elemetSide { get { return ELEMENTTYPE.ALLY; } set { elemetSide = value; } }

    public override GameObject elementObject { get; set; }

    public override Detector detector { get; protected set; }

    public override ElementStatus status { get; set; }

    AutomaticMove movementController = null;
    Tap tapCanvas = null;

    public Player(PlayerData playerData, GameObject prefab, Tap tapCanvas)
    {
        this.playerData = playerData;   
        this.elementObject = prefab;
        this.tapCanvas = tapCanvas;
        this.playerData.currentPlayerHealt = this.playerData.maxPlayerHealt;
        InitComponent();
    }

    void InitComponent()
    {
        this.elementObject.AddComponent<GEComponent>().gameElement = this;
        this.detector = this.elementObject.AddComponent<Detector>();
        this.rb = this.elementObject.GetComponent<Rigidbody>();
        this.movementController = new AutomaticMove(this, tapCanvas);
    }

    public override void ChangeStats(ELEMENTSTATS statistics, int value)
    {
        switch (statistics)
        {
            case ELEMENTSTATS.HEAL:
                playerData.currentPlayerHealt -= value;
                if (playerData.currentPlayerHealt <= 0)
                {
                    playerData.currentPlayerHealt = 0;
                    this.status = ElementStatus.DEAD;
                }
                break;
            case ELEMENTSTATS.SPEED:
                playerData.playerSpeed += value;
                break;
            case ELEMENTSTATS.ITEMSCOUNT:
                playerData.playerItemCount += value;
                break;
            default:
                break;
        }
    }
}
