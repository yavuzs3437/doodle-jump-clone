using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Character"))
        {
            if (collision.relativeVelocity.y <= 0f)
            {
                collision.gameObject.GetComponent<CharachterMovement>().Jump();
            }
        }
    }
}
