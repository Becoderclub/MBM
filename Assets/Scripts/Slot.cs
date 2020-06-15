using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public static Action<int> slotClicked;
    public Text contentName;
    public Image image;
    public int number;

    public void OnClick() {
        slotClicked(number);
    }
}