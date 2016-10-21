using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// class that creates an Item based on an GameElement within the game
/// </summary>
public class Item : GameElement
{
    #region Variables
    public override Detector detector { get; protected set; }
    public override GameObject elementObject { get; set; }
    public override ELEMENTTYPE elemetSide { get { return ELEMENTTYPE.ITEM; } set { this.elemetSide = value; } }
    public override Rigidbody rb { get; protected set; }
    public ItemData itemData { get; set; }
    #endregion

    #region Methods
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="prefab"></param>
    /// <param name="itemData"></param>
    public Item(GameObject prefab, ItemData itemData)
    {
        this.itemData = itemData;
        this.elementObject = prefab;
        InitComponent();
    }

    /// <summary>
    /// Init component it needs the object
    /// </summary>
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
        target.ChangeStats(ELEMENTSTATS.ITEMSCOUNT, this.itemData.valueItem);
        this.elementObject.SetActive(false);
    }
    #endregion
}
