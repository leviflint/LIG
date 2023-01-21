using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wood
{

    private int wood = 0;

    public int GetWood()
    {
        return wood;
    }

    public int SetWood()
    {
        wood++;
        return wood;
    }

}
