using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BTLUI_ButtonFieldTarget : BTLUI_Button
{
    [Header("Text")]
    public Text nameTxt;
    public Text lvlTxt, 
        statusTxt;

    [Header("Health")]
    public GameObject hpObj;
    public Image icon,
        hpBar;
    public Color
        hpHigh,
        hpMed,
        hpLow;

    public Color colorUser;

    [HideInInspector] public Pokemon pokemon = null;
    [HideInInspector] public BattlePosition position = null;
}
