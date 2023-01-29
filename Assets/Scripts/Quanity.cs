using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quanity : MonoBehaviour
{

    public ItemData itemData;
    public Text quanityButtonOneText;
    public Text quanityButtonTwoText;
    public Text quanityButtonThreeText;


    // Start is called before the first frame update
    void Start()
    {
        quanityButtonOneText.text = "x" + itemData.quanityOne;
        quanityButtonTwoText.text = "x" + itemData.quanityTwo;
        quanityButtonThreeText.text = "x" + itemData.quanityThree;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuanityButtonOneClick()
    {
        itemData.currentQuanity = itemData.quanityOne;
    }

    public void QuanityButtonTwoClick()
    {
        itemData.currentQuanity = itemData.quanityTwo;
    }

    public void QuanityButtonThreeClick()
    {
        itemData.currentQuanity = itemData.quanityThree;
    }
}
