using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class QuanityData : ScriptableObject
{
    public int quanityOne = 1;
    public int quanityTwo = 10;
    public int quanityThree = 100;
    public int currentQuanity = 1;
    public bool ButtonOneActive = true;
    public bool ButtonTwoActive = false;
    public bool ButtonThreeActive = false;
}
