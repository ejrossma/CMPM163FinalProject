using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFlash : MonoBehaviour
{
    private Light myLight;


    void Start()
    {
        myLight = GetComponent<Light>();
    }


    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKeyDown("z"))
        {
            myLight.enabled = true;
        } else
        {
            myLight.enabled = false;
        }
    }
}
