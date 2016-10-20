using UnityEngine;
using System.Collections;

public class AutomaticMove
{

    Vector3 movement;
    float h = 0.5f;
    float speed = 2.0f;
    GameElement gameElement = null;
    float power = 5;

    bool automatic = false;
    public float maxSpeed = 10f;
    public float forceMagnitude = 2f;

    public AutomaticMove(GameElement gameElement, Tap tapCanvas)
    {
        this.gameElement = gameElement;
#if UNITY_STANDALONE_WIN
        this.gameElement.elementObject.GetComponent<GEComponent>().updateEvent += Move;
        this.gameElement.elementObject.GetComponent<GEComponent>().updateEvent += Jump;
#endif
    }

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

    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            this.gameElement.rb.velocity = new Vector3(this.gameElement.rb.velocity.x, power, this.gameElement.rb.velocity.z);
        }
    }
}
