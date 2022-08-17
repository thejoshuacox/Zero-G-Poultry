using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class buttonScript : MonoBehaviour
{
    public Button butt;
    public GameObject score;
    public VideoPlayer video;
    public GameObject videoScreen;
    public GameObject mainMenuScreen;

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

    public void playVideo()
    {
        Debug.Log("Entered PlayVideo");
        video.Play();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void stopVideo()
    {
        video.Stop();
        videoScreen.gameObject.SetActive(false);
        mainMenuScreen.gameObject.SetActive(true);
    }

    public void goToCredits()
    {
        SceneManager.LoadScene("End_Game");
    }
}
