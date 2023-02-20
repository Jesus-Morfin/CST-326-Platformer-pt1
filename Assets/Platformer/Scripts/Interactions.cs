using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interactions : MonoBehaviour
{
    public TextMeshProUGUI question;
    private int coins = 0;
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000f))
            {
                if (hit.collider.gameObject.tag == "Brick")
                {
                    Destroy(hit.collider.gameObject);
                }

                if (hit.collider.gameObject.tag == "QuestionBlock")
                {
                    Debug.Log("Coins");
                    coins++;
                    if (coins < 10)
                    {
                        this.question.text = "x0" + coins.ToString();
                    }
                    else
                    {
                        this.question.text = "x" + coins.ToString();
                    }
                }
            }
        }

    }
}
