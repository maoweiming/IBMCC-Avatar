﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextLogItem : MonoBehaviour
{
    public void SetText(string myText, Color myColour)
    {
        GetComponent<Text>().text = myText;
        GetComponent<Text>().color = myColour;
    }
}