using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    void Start() {

        

    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {

        Vector3 charaScale = transform.localScale;

        if (movement.x < 0) {

            transform.localRotation = Quaternion.Euler(0, 0, 0);

        }

        else if (movement.x > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Kill")
        {
            Destroy(this.gameObject);
        }

    }

}
