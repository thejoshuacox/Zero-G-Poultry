using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class goingUp : MonoBehaviour
{
    public Canvas background;
    public Image text;
    public Image suck;

    public float scrollRate;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (text.transform.position.y < 35)
        {
            text.transform.position = new Vector3(text.transform.position.x, text.transform.position.y + scrollRate, text.transform.position.z);
        }
        else
        {
            suck.gameObject.SetActive(true);
            background.transform.position = new Vector3(background.transform.position.x, background.transform.position.y + scrollRate + 0.2f, background.transform.position.z);
        }

        if (background.transform.position.y > 1000)
        {
            SceneManager.LoadScene("Main_Menu");
        }
    }
}
