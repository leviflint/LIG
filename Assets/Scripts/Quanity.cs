using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quanity : MonoBehaviour
{

    public QuanityData quanityData;
    public Text quanityButtonOneText;
    public Text quanityButtonTwoText;
    public Text quanityButtonThreeText;

    // Start is called before the first frame update
    void Start()
    {
        quanityButtonOneText.text = "x" + quanityData.quanityOne;
        quanityButtonTwoText.text = "x" + quanityData.quanityTwo;
        quanityButtonThreeText.text = "x" + quanityData.quanityThree;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuanityButtonOneClick()
    {
        quanityData.currentQuanity = quanityData.quanityOne;
        quanityData.ButtonOneActive = true;
        quanityData.ButtonTwoActive = false;
        quanityData.ButtonThreeActive = false;
    }

    public void QuanityButtonTwoClick()
    {
        quanityData.currentQuanity = quanityData.quanityTwo;
        quanityData.ButtonOneActive = false;
        quanityData.ButtonTwoActive = true;
        quanityData.ButtonThreeActive = false;
    }

    public void QuanityButtonThreeClick()
    {
        quanityData.currentQuanity = quanityData.quanityThree;
        quanityData.ButtonOneActive = false;
        quanityData.ButtonTwoActive = false;
        quanityData.ButtonThreeActive = true;
    }
}
