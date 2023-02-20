using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMpvement : MonoBehaviour
{
    private float scroll;
    void Update()
    {
        scroll = Input.GetAxis("Horizontal");
        if (scroll != 0)
        {
            movement();
        }

    }

    private void movement()
    {
        transform.position += transform.right * scroll * Time.deltaTime;
    }
}
