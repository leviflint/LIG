﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tree : MonoBehaviour
{
    public PlayerData playerData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTreeClick()
    {
        playerData.TotalWood += (1 + playerData.ClickAdditive)*playerData.WoodMultiplyer;
        
    }
}
