﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stamina : MonoBehaviour
{

    [SerializeField] private Slider staminaBar;

    void Start()
    {
        staminaBar.value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
