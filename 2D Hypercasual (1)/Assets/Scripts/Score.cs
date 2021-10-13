using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public float timer = 0f;
    [SerializeField] GameObject rocket;
    bool runTimer; 

    void Start()
    {
        
    }


    void Update()
    {
        
        if (rocket.activeSelf)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
        }
    }
}

