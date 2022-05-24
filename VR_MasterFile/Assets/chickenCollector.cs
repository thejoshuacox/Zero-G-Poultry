using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class chickenCollector : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Score is " + score);
    }

    public int score = 0;
    public TextMeshProUGUI scoreDisplay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "chicken")
        {
            Destroy(other.gameObject);
            int.TryParse(scoreDisplay.text, out score);
            score++;
            scoreDisplay.text = score.ToString();
        }
    }
}
