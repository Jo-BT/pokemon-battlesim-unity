using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTLUI_Button : MonoBehaviour
{
    public Image image;
    public Color colorSel, colorUnsel;
    [HideInInspector] public RectTransform rectTransform;

    public void InitializeSelf()
    {
        rectTransform = GetComponent<RectTransform>();
    }
}
