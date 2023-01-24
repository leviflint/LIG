﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public string PlayerName;
    public Sprite PlayerImage;
    public int TotalWood;
    public int WoodMultiplyer;
    public int ClickMultiplyer;
    public int ClickAdditive;
    public int ButtonOnePurchases;

}