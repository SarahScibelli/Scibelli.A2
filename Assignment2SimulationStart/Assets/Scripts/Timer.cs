using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int timeLeft;
    public TMP_Text timeText;
    public Image lose;
    public coinManager cm;

    //public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while(timeLeft >= 0)
        {
            timeText.text = timeLeft.ToString();
            yield return new WaitForSeconds(1f);
            timeLeft--;
        }

        if(cm.coinCount < 10)
        {
            lose.gameObject.SetActive(true);
        }


    }

    

    
}
