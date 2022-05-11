using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class chickenSpawner : MonoBehaviour
{
    public double timer = 100;
    public TextMeshProUGUI display;
    int tImer;
    private int chickenToSpawn = 0;
    public int amountPerSpawn = 5;
    public int chickenCount;
    bool changedAmount = true;

    public List<GameObject> objectsToSpawn = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(erinChick, new Vector3(0f,0.5f,6f), new Quaternion(0,0,0,0));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer >= 0)
        {
            timer -= Time.fixedDeltaTime;
            tImer = (int)Math.Round(timer);
            display.text = tImer.ToString();
        }

        if (tImer % 5 == 0 && tImer != 0)
        {
            if (chickenToSpawn < 5)
            {
                spawnChicken1(chickenToSpawn);
                chickenToSpawn++;
            }
            else 
            {
                chickenToSpawn = 0;
                spawnChicken1(chickenToSpawn);
                chickenToSpawn++;
            }
        }

        if (tImer % 5 == 0 && tImer != 0)
        {
            if (chickenToSpawn < 5)
            {
                spawnChicken2(chickenToSpawn);
                chickenToSpawn++;
            }
            else
            {
                chickenToSpawn = 0;
                spawnChicken2(chickenToSpawn);
                chickenToSpawn++;
            }
        }

        if (tImer % 5 == 0 && tImer != 0)
        {
            if (chickenToSpawn < 5)
            {
                spawnChicken3(chickenToSpawn);
                chickenToSpawn++;
            }
            else
            {
                chickenToSpawn = 0;
                spawnChicken3(chickenToSpawn);
                chickenToSpawn++;
            }
        }

        // Every 10 seconds, increase the number of chickens to be spawned by 5
        if (tImer % 10 == 0 && !changedAmount)
        {
            amountPerSpawn += 5;
            changedAmount = true;
        }

        // Every 5 seconds reset the chickenCount
        if ((tImer+1) % 5 == 0)
        {
            chickenCount = amountPerSpawn;
            changedAmount = false;
        }

    }

    private void spawnChicken1(int index)
    {
        if (chickenCount > 0)
        {
            Debug.Log("Chicken " + index + " is being spawned");
            Instantiate(objectsToSpawn[index], new Vector3(0f, 0.5f, 4f), new Quaternion(0, 0, 0, 0));

            chickenCount--;
        }
    }
    private void spawnChicken2(int index)
    {
        if (chickenCount > 0)
        {
            Debug.Log("Chicken " + index + " is being spawned");
            Instantiate(objectsToSpawn[index], new Vector3(-4f, 0.5f, 0f), new Quaternion(0, 0, 0, 0));

            chickenCount--;
        }
    }
    private void spawnChicken3(int index)
    {
        if (chickenCount > 0)
        {
            Debug.Log("Chicken " + index + " is being spawned");
            Instantiate(objectsToSpawn[index], new Vector3(4f, 0.5f, 0f), new Quaternion(0, 0, 0, 0));

            chickenCount--;
        }
    }
}
