using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class ItemData : ScriptableObject
{
    public string itemOneName;
    public string itemOneDescription;
    public string itemTwoName;
    public string itemTwoDescription;
    public int itemOneBasePrice;
    public int itemTwoBasePrice;
    public int quanityOne;
    public int quanityTwo;
    public int quanityThree;
    public int currentQuanity;
}
