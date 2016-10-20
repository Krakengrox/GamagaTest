using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class GamePad : MonoBehaviour
{
    Vector3 movement;
    float h = 0.5f;
    public GameObject elementGo;
    Rigidbody rb;
    float speed = 2.0f;
    float power = 5;

    public GameObject right;
    public GameObject left;
    public Button jumpBtn;
    bool downRight = false;
    bool downLeft = false;

    void Start()
    {
        this.right.GetComponent<EventsTest>().changeState += ValidatedState;
        this.left.GetComponent<EventsTest>().changeState += ValidatedState;
        this.jumpBtn.onClick.AddListener(Jump);
        this.rb = this.elementGo.GetComponent<Rigidbody>();
    }

    void ValidatedState(bool state, string side)
    {
        switch (side)
        {
            case "LEFT":
                Debug.Log("Soy left");
                Debug.Log("estoy  " + state);
                downLeft = state;
                break;
            case "RIGHT":
                downRight = state;
                break;
            default:
                break;
        }
    }


    void FixedUpdate()
    {
        if (downRight)
        {

            movement.Set(h, 0f, 0f);
            movement = movement.normalized * speed * Time.deltaTime;

            this.elementGo.transform.Translate(movement);
        }

        if (downLeft)
        {
            movement.Set(-h, 0f, 0f);
            movement = movement.normalized * speed * Time.deltaTime;

            this.elementGo.transform.Translate(movement);
        }

    }

    void Jump()
    {
        this.rb.velocity = new Vector3(this.rb.velocity.x, power, this.rb.velocity.z);
    }

}
