using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOne : MonoBehaviour
{
    public PlayerData playerData;
    public int buttonOneCost;
    public Text buttonOnePriceText;
    public Text buttonOneDescriptionText;
    public Text buttonOnePurchasedText;
    public ItemData itemData;


    // Start is called before the first frame update
    void Start()
    {
        buttonOnePriceText.text = "" + ButtonOneCost();
        buttonOneDescriptionText.text = "+" + itemData.currentQuanity + " " + itemData.itemOneDescription;
        buttonOnePurchasedText.text = "Owned: " + playerData.ItemOnePurchases;
        playerData.ClickAdditive = playerData.ItemOnePurchases;
    }

    void Update()
    {
        buttonOnePriceText.text = "" + ButtonOneCost();
        buttonOneDescriptionText.text = "+" + itemData.currentQuanity + " " + itemData.itemOneDescription;
        buttonOnePurchasedText.text = "Owned: " + playerData.ItemOnePurchases;
        playerData.ClickAdditive = playerData.ItemOnePurchases;
    }

    public void OnButtonOneClick()
    {
  
        if (playerData.ItemOnePurchases <= 0 && playerData.TotalWood >= itemData.itemOneBasePrice)
        {
            playerData.TotalWood -= itemData.itemOneBasePrice;
            playerData.ItemOnePurchases = playerData.ItemOnePurchases + itemData.currentQuanity;
            playerData.ClickAdditive = playerData.ClickAdditive + itemData.currentQuanity;

        } if (playerData.ItemOnePurchases >= 1 && playerData.TotalWood >= ButtonOneCost())
        {

            playerData.TotalWood -= ButtonOneCost();
            playerData.ItemOnePurchases = playerData.ItemOnePurchases + itemData.currentQuanity;
            playerData.ClickAdditive = playerData.ClickAdditive + itemData.currentQuanity;
        } else
        {
            // Throw Error here
        }
        
    }

    public int ButtonOneCost()
    {
        buttonOneCost = (itemData.itemOneBasePrice + 50 * playerData.ItemOnePurchases) * itemData.currentQuanity;
        return buttonOneCost;
    }
}
