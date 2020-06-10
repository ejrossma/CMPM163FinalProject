﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashAnimation : MonoBehaviour
{
    ParticleSystem muzzleFlash;
    //Start is called before the first frame update
    void Start()
    {
        muzzleFlash = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKeyDown("z"))
        {
            muzzleFlash.Play();
        }
    }
}
