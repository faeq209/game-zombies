﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public void SETmAXhEALTH(int health)
    {
        slider.maxValue = health;
        slider.value = health;

    }
    public void SetHealth(int health)
    {
        slider.value = health;
    }

}

