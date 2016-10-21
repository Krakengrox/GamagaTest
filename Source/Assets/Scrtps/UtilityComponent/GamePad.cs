using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

/// <summary>
/// GamePad Ui controler and translate element
/// </summary>
public class GamePad : MonoBehaviour
{
    #region Variables
    /// <summary>
    /// Movement vector value for translate object
    /// </summary>
    Vector3 movement;
    /// <summary>
    /// Force aplicate
    /// </summary>
    float h = 1f;
    /// <summary>
    /// Speed object move
    /// </summary>
    public GameObject elementGo;
    /// <summary>
    /// Rigidbody
    /// </summary>
    Rigidbody rb;
    /// <summary>
    /// Speed object move
    /// </summary>
    float speed = 2.0f;
    /// <summary>
    /// power for jump
    /// </summary>
    float power = 5;
    /// <summary>
    /// Ui Buttons
    /// </summary>
    public GameObject right;
    /// <summary>
    /// Ui Buttons
    /// </summary>
    public GameObject left;
    /// <summary>
    /// Ui Buttons
    /// </summary>
    public Button jumpBtn;

    bool downRight = false;
    bool downLeft = false;
    #endregion

    #region Methods
    void Start()
    {
        this.right.GetComponent<EventsTest>().changeState += ValidatedState;
        this.left.GetComponent<EventsTest>().changeState += ValidatedState;
        this.rb = elementGo.GetComponent<Rigidbody>();
        this.jumpBtn.onClick.AddListener(Jump);
    }

    /// <summary>
    /// Validated down or up touch
    /// </summary>
    /// <param name="state"></param>
    /// <param name="side"></param>
    void ValidatedState(bool state, string side)
    {
        switch (side)
        {
            case "LEFT":
                downLeft = state;
                break;
            case "RIGHT":
                downRight = state;
                break;
            default:
                break;
        }
    }


    void Update()
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
    #endregion
}
