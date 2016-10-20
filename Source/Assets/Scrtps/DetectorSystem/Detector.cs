using UnityEngine;
using System.Collections;
using System;
public class Detector : MonoBehaviour
{
    public Action<GameElement, bool> actionCollision = null;
    public Action getItem = null;
    public GameElement target = null;
    GameElement myGameElement;
    public bool enter = false;
    public bool stay = false;

    float timeToWait = 2;
    float time = 3;

    void Awake()
    {
        this.myGameElement = this.GetComponent<GEComponent>().gameElement;
    }

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
            else if (this.myGameElement.elemetSide != ELEMENTTYPE.ENEMY)
            {
                actionCollision(target, enter);
            }
        }
    }

    void OnTriggerExit(Collider incommingObject)
    {

        if (incommingObject.GetComponent<GEComponent>())
        {
            this.target = incommingObject.GetComponent<GEComponent>().gameElement;
            this.enter = false;
            if (this.myGameElement.elemetSide == ELEMENTTYPE.ENEMY && this.myGameElement.elemetSide != target.elemetSide)
            {
                actionCollision(target, enter);
            }
            else if (this.myGameElement.elemetSide != ELEMENTTYPE.ENEMY)
            {
                actionCollision(target, enter);
            }

        }
        else if (this.myGameElement.elemetSide == ELEMENTTYPE.ALLY)
        {
            //Destroy(this.myGameElement.elementObject);
        }
    }

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
}