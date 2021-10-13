using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    
    [SerializeField] GameObject rocket;
    bool runTimer;
    float timer;

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

