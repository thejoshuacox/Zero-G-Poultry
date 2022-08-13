using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class systemHandler : MonoBehaviour
{
    private void Awake()
    {
        if (SceneManager.GetActiveScene().name == "Main_Game")
        {
            Time.timeScale = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }

    
}
