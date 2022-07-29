using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class systemHandler : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
