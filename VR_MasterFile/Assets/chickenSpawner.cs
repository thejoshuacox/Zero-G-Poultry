using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class chickenSpawner : MonoBehaviour
{
    double timer = 100;
    public TextMeshProUGUI display;
    int tImer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            tImer = (int)Math.Round(timer);
            display.text = tImer.ToString();
            Debug.Log(tImer);
        }

        
    }
}
