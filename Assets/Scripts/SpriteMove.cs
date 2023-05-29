using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMove : MonoBehaviour
{
    public bool Move = true;
    private Rigidbody2D rb;
    public float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Move)
        {
            rb.velocity = new Vector2(0, Speed * -1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            Speed = 0;
            Debug.Log("NJBHUJBUB");
        }
    }
}