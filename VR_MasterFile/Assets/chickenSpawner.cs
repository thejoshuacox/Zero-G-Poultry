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

    public List<GameObject> objectsToSpawn = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(erinChick, new Vector3(0f,0.5f,6f), new Quaternion(0,0,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            tImer = (int)Math.Round(timer);
            display.text = tImer.ToString();
        }

        if (tImer+3 % 5 == 0)
        {
            spawnChicken1();
        }

        if (tImer % 6 == 0)
        {
            spawnChicken2();
        }

        if (tImer % 9 == 0)
        {
            spawnChicken3();
        }

    }

    private void spawnChicken1()
    {
        int index = UnityEngine.Random.Range(0, objectsToSpawn.Count);
        Instantiate(objectsToSpawn[index], new Vector3(0f, 0.5f, 6f), new Quaternion(0, 0, 0, 0));
    }

    private void spawnChicken2()
    {
        int index = UnityEngine.Random.Range(0, objectsToSpawn.Count);
        Instantiate(objectsToSpawn[index], new Vector3(0f, 0.5f, 6f), new Quaternion(0, 0, 0, 0));
    }

    private void spawnChicken3()
    {
        int index = UnityEngine.Random.Range(0, objectsToSpawn.Count);
        Instantiate(objectsToSpawn[index], new Vector3(0f, 0.5f, 6f), new Quaternion(0, 0, 0, 0));
    }
}
