using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonScript : MonoBehaviour
{
    public Button butt;
    public GameObject score;

    public void setText(string text)
    {
        butt.gameObject.SetActive(false);
    }

    public void startGame()
    {
        Time.timeScale = 1;
        score.gameObject.SetActive(true);
    }

    public void playGame()
    {
        Debug.Log("Entered PlayGame");
        SceneManager.LoadScene("Main_Game");
    }
}
