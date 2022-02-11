using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour
{

    public GameObject flashlight;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            flashlight.SetActive(false);
        }
        else
        {
            flashlight.SetActive(true);
        }
    }
}