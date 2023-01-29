using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerData : ScriptableObject
{
    public string PlayerName;
    public Sprite PlayerImage;
    public Sprite CurrentAxe;
    public int TotalWood;
    public int ClickAdditive;
    public int ItemOnePurchases;
    public int WoodMultiplyer;
    public int ItemTwoPurchases;
}
