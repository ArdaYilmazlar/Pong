using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPU : MonoBehaviour
{
    public int speed;

    private Transform ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, new Vector2(transform.position.x, ball.position.y), speed * Time.deltaTime);   
    }
}
