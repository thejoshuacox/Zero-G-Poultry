using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkScore : MonoBehaviour
{
    [SerializeField]
    private IntSO scoreSO;

    public Canvas goodEnding;
    public Canvas badEnding;
    public Canvas secretEnding;

    // Start is called before the first frame update
    void Awake()
    {
        if(scoreSO.Value >= 40)
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

        scoreSO.Value = 0;
    
    }

    
}
