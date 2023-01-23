using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tree : MonoBehaviour
{
    public int wood;
    public TextMeshProUGUI woodCounter;

    // Start is called before the first frame update
    void Start()
    {
        woodCounter.text = "Wood: " + wood;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onTreeClick()
    {
        wood++;
        woodCounter.text = "Wood: " + wood;
    }
}
