using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float movement = 0.0f;
    private Rigidbody2D rb;

 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        movement = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(0, speed * movement * Time.deltaTime);
    }

}
