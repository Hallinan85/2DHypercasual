using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float asteroidSpeed;
    Rigidbody2D myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(-asteroidSpeed,0f);
        // Atempt at Rotation myRigidbody.rotation = new Vector3(0f, 0f, 10f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Shredder")
        {
            Destroy(gameObject);
        }
    }



}
