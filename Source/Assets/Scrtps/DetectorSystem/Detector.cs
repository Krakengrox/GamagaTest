using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Automatic detector element enter in a collider
/// </summary>
public class Detector : MonoBehaviour
{
    #region Variables

    /// <summary>
    /// Callback for a collision action
    /// </summary>
    public Action<GameElement, bool> actionCollision = null;
    /// <summary>
    /// Callback for a collision action
    /// </summary>
    public Action actionColli = null;
    /// <summary>
    /// GameObject target
    /// </summary>
    public GameElement target = null;
    /// <summary>
    /// Me abstract class in me game object
    /// </summary>
    GameElement myGameElement;

    /// <summary>
    /// if i enter in a collision event
    /// </summary>
    public bool enter = false;

    /// <summary>
    /// time to wait for callback action
    /// </summary>
    float timeToWait = 2;
    float time = 3;
    #endregion

    #region Methods
    void Awake()
    {
        this.myGameElement = this.GetComponent<GEComponent>().gameElement;
    }

    /// <summary>
    /// Ontrigger event, activated if a game object enter, validate type target and action
    /// </summary>
    /// <param name="incommingObject"></param>
    void OnTriggerEnter(Collider incommingObject)
    {

        this.enter = true;
        if (incommingObject.GetComponent<GEComponent>())
        {
            this.target = incommingObject.GetComponent<GEComponent>().gameElement;

            if (this.myGameElement.elemetSide == ELEMENTTYPE.ENEMY && this.myGameElement.elemetSide != target.elemetSide)
            {
                StartCoroutine(Timer());
            }
            else if (this.myGameElement.elemetSide == ELEMENTTYPE.ITEM && this.myGameElement.elemetSide != ELEMENTTYPE.ENEMY)
            {
                actionCollision(target, enter);
            }
            else if (this.myGameElement.elemetSide == ELEMENTTYPE.ALLY && target.elemetSide != ELEMENTTYPE.ITEM && target.elemetSide != ELEMENTTYPE.ENEMY)
            {


            }
        }
        else if (this.myGameElement.elemetSide == ELEMENTTYPE.ALLY)
        {
            actionColli();
        }
    }
    /// <summary>
    /// Ontrigger event, activated if a game object out, validate type target and action
    /// </summary>
    /// <param name="incommingObject"></param>
    void OnTriggerExit(Collider incommingObject)
    {

        if (incommingObject.GetComponent<GEComponent>())
        {
            this.target = incommingObject.GetComponent<GEComponent>().gameElement;
            this.enter = false;

        }
        else if (this.myGameElement.elemetSide == ELEMENTTYPE.ALLY)
        {
            //Destroy(this.myGameElement.elementObject);
        }
    }

    /// <summary>
    /// Coroutine for a launch action in elapsed time
    /// </summary>
    /// <returns></returns>
    IEnumerator Timer()
    {
        while (enter)
        {
            this.time += Time.deltaTime;
            if (this.time >= timeToWait)
            {
                actionCollision(target, enter);
                this.time = 0f;
            }
            yield return null;
        }
        this.time = 3f;
        yield return 0;

    }
    #endregion
}