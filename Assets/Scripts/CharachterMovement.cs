using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharachterMovement : MonoBehaviour
{
    [SerializeField] float dodgeSpeed;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalAxis = Input.GetAxis("Horizontal");
        gameObject.transform.Translate(HorizontalAxis * dodgeSpeed * Time.deltaTime, 0, 0);
    }

    public void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
}
