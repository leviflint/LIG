using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOne : MonoBehaviour
{
    public PlayerData playerData;
    public int buttonOneBasePrice = 100;
    public int buttonOneCost;
    public Text buttonOneText;


    // Start is called before the first frame update
    void Start()
    {
        buttonOneText.text = "+1 wood per click. Cost: " + ButtonOneCost();
    }

    public void OnButtonOneClick()
    {
  
        if (playerData.ButtonOnePurchases <= 0 && playerData.TotalWood >= buttonOneBasePrice)
        {
            playerData.TotalWood -= buttonOneBasePrice;
            playerData.ButtonOnePurchases++;
            playerData.ClickAdditive++;
            buttonOneText.text = "+1 wood per click. Cost: " + ButtonOneCost();

        } if (playerData.ButtonOnePurchases >= 1 && playerData.TotalWood >= ButtonOneCost())
        {

            playerData.TotalWood -= ButtonOneCost();
            playerData.ButtonOnePurchases++;
            playerData.ClickAdditive++;
            buttonOneText.text = "+1 wood per click. Cost: " + ButtonOneCost();
        } else
        {
            // Throw Error here
        }
        
    }

    public int ButtonOneCost()
    {
        buttonOneCost = buttonOneBasePrice + 50 * playerData.ButtonOnePurchases;
        return buttonOneCost;
    }
}
