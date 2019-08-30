using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private int movement;
    private Rigidbody2D rb;
    public string controlUp;
    public string controlDown;
    private KeyCode controlUpKeyCode;
    private KeyCode controlDownKeyCode;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        controlUpKeyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), controlUp);
        controlDownKeyCode = (KeyCode)System.Enum.Parse(typeof(KeyCode), controlDown);
    }

    private void FixedUpdate()
    {
        movement = inputManager();
        rb.velocity = new Vector2(0, speed * movement * Time.deltaTime);
    }

    private int inputManager()
    {
        if (Input.GetKey(controlUpKeyCode))
        {
            return 1;
        }else if (Input.GetKey(controlDownKeyCode))
        {
            return -1;
        }
        return 0;
    }
}
