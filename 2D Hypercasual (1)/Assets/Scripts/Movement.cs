using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    

    [Header("Player")]
    [SerializeField] float jumpSpeed;
        

    [Header("Sounds")]
    AudioSource thrusterSound;
    
    Vector2 moveInput;
    Rigidbody2D myRigidbody;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        thrusterSound = FindObjectOfType<AudioSource>();
    }

    
    void Update()
    {
        
    }

    void OnJump(InputValue value)
    {
        if (value.isPressed)
        {
            myRigidbody.velocity += new Vector2(0f, jumpSpeed);
            thrusterSound.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
