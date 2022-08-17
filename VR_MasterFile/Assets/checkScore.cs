using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class checkScore : MonoBehaviour
{
    [SerializeField]
    private IntSO scoreSO;

    public Canvas goodEnding;
    public Canvas badEnding;
    public Canvas secretEnding;
    public TextMeshProUGUI score;

    // Start is called before the first frame update
    void Awake()
    {
        scoreSO.Value = 20;

        if (scoreSO.Value >= 40)
        {
            goodEnding.gameObject.SetActive(true);
        }
        else if(scoreSO.Value > 0)
        {
            badEnding.gameObject.SetActive(true);
        }
        else
        {
            secretEnding.gameObject.SetActive(true);
        }

        score.text = scoreSO.Value.ToString();
        scoreSO.Value = 0;
    
    }

    
}
