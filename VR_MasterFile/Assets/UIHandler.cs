using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class UIHandler : MonoBehaviour
{
    public GameObject mainMenu;
    public VideoPlayer video;
    public GameObject videoScreen;

    private void Start()
    {
        video.Stop();
    }

    private void Update()
    {
        if (video.isPlaying)
        {
            videoScreen.gameObject.SetActive(true);
            mainMenu.gameObject.SetActive(false);
        }
        else
        {
            videoScreen.gameObject.SetActive(false);
            mainMenu.gameObject.SetActive(true);
        }
    }
}
