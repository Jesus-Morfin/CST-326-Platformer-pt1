using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UITimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private int timer = 400;
    // Update is called once per frame
    void Update()
    {
        int wholeSecond = timer - (int)Mathf.Floor(Time.realtimeSinceStartup);
        timerText.text = $"Time \n {wholeSecond.ToString()}";
    }
}
