using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTwo : MonoBehaviour
{

    public Text buttonTwoPriceText;
    public Text buttonTwoDescriptionText;
    public Text buttonTwoPurchasedText;
    public PlayerData playerData;
    public ItemData itemData;
    public SpriteRenderer spriteRenderer;
    public Sprite nextItem;
    private int itemTwoCost;


    // Start is called before the first frame update
    void Start()
    {
        buttonTwoPriceText.text = "" + ButtonTwoCost();
        buttonTwoDescriptionText.text = "x" + itemData.currentQuanity + " " + itemData.itemTwoDescription;
        buttonTwoPurchasedText.text = "Owned: " + playerData.ItemTwoPurchases;
        playerData.WoodMultiplyer = playerData.ItemTwoPurchases + 1;
    }

    // Update is called once per frame
    void Update()
    {
        buttonTwoPriceText.text = "" + ButtonTwoCost();
        buttonTwoDescriptionText.text = "x" + itemData.currentQuanity + " " + itemData.itemTwoDescription;
        buttonTwoPurchasedText.text = "Owned: " + playerData.ItemTwoPurchases;
        playerData.WoodMultiplyer = playerData.ItemTwoPurchases + 1;
    }

    public void OnButtonTwoClick()
    {
        if (playerData.ItemTwoPurchases <= 0 && playerData.TotalWood >= ButtonTwoCost())
        {
            playerData.TotalWood -= itemData.itemTwoBasePrice;
            playerData.ItemTwoPurchases = playerData.ItemTwoPurchases + itemData.currentQuanity;
            playerData.WoodMultiplyer = playerData.WoodMultiplyer + itemData.currentQuanity;
            ChangeSprite();
        } if (playerData.ItemTwoPurchases >= 1 && playerData.TotalWood >= ButtonTwoCost())
        {
            playerData.TotalWood -= ButtonTwoCost();
            playerData.ItemTwoPurchases = playerData.ItemTwoPurchases + itemData.currentQuanity;
            playerData.WoodMultiplyer = playerData.WoodMultiplyer + itemData.currentQuanity;
            buttonTwoDescriptionText.text = "x" + itemData.currentQuanity + " " + itemData.itemTwoDescription;
        } else
        {
            // Throw Error Here
        }
    }

    private int ButtonTwoCost()
    {

        if (playerData.ItemTwoPurchases <= 0)
        {
            itemTwoCost = itemData.itemTwoBasePrice * itemData.currentQuanity;
            return itemTwoCost;
        }
        else
        {
            itemTwoCost = (itemData.itemTwoBasePrice * (playerData.ItemTwoPurchases + 1)) * itemData.currentQuanity;
            return itemTwoCost;
        }
        
    }

    private void ChangeSprite() {
        spriteRenderer.sprite = nextItem;
    }   
}
