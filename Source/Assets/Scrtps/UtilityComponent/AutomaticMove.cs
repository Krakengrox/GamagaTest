using UnityEngine;
using System.Collections;

/// <summary>
/// Use for a player Move whith Keyboard and automatic mechanic in "X". 
/// </summary>
public class AutomaticMove
{
    #region Variable
    /// <summary>
    /// Movement vector value for translate object
    /// </summary>
    Vector3 movement;
    /// <summary>
    /// Force aplicate in automatic move
    /// </summary>
    float h = 0.5f;
    /// <summary>
    /// Speed object move
    /// </summary>
    float speed = 2.0f;
    /// <summary>
    /// Element move
    /// </summary>
    GameElement gameElement = null;
    /// <summary>
    /// power for jump
    /// </summary>
    float power = 5;
    /// <summary>
    /// active atomatic move
    /// </summary>
    bool automatic = false;


    GameObject jet = null;
    #endregion

    #region Methods
    /// <summary>
    /// Construct, add event component update
    /// </summary>
    /// <param name="gameElement"></param>
    /// <param name="tapCanvas"></param>
    public AutomaticMove(GameElement gameElement, int speed)
    {
        this.gameElement = gameElement;
        this.gameElement.elementObject.GetComponent<GEComponent>().updateEvent += Move;
        this.gameElement.elementObject.GetComponent<GEComponent>().updateEvent += Jump;
        this.jet = GameObject.Find("Jet");
        this.speed = speed;
    }

    /// <summary>
    /// translate element
    /// </summary>
    void Move()
    {
        if (automatic)
        {
            movement.Set(h, 0f, 0f);
        }
        else
        {
            movement.Set(Input.GetAxisRaw("Horizontal"), 0f, 0f);
        }
        movement = movement.normalized * speed * Time.deltaTime;

        this.gameElement.elementObject.transform.Translate(movement);

    }

    /// <summary>
    /// apply velocity for impulse object in Y
    /// </summary>
    void Jump()
    {
        if (Input.GetButton("Jump"))
        {
            this.gameElement.rb.velocity = new Vector3(this.gameElement.rb.velocity.x, power, this.gameElement.rb.velocity.z);
            //this.jet.GetComponent<ParticleSystem>().Play();
        }
        else
        {
            //this.jet.GetComponent<ParticleSystem>().Pause();
        }
    }
    #endregion
}
