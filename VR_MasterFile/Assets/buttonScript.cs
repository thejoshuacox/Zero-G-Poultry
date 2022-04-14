using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    public Button butt;

    public void setText(string text)
    {
        butt.gameObject.SetActive(false);
    }

    public void startGame()
    {
        Time.timeScale = 1;
    }

}
