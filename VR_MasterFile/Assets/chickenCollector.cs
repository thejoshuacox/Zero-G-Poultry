using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenCollector : MonoBehaviour
{
    public int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "chicken")
        {
            Destroy(other.gameObject);
            score++;
        }
    }
}
