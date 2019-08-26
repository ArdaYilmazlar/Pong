using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(generatePositiveOrNegative() * Random.Range(8, 10), Random.Range(-10, 10));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.name == "BorderLeft" || collision.collider.gameObject.name == "BorderRight")
        {
            transform.position = Vector2.zero;
            rb.velocity = new Vector2(generatePositiveOrNegative() * Random.Range(8,10), Random.Range(-10, 10));
        }
    }

    private int generatePositiveOrNegative()
    {
        int num = Random.Range(0, 2);
        if (num == 0)
            return -1;
        return 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
