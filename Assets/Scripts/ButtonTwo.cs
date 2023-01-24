using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonTwo : MonoBehaviour
{

    public TextMeshProUGUI buttonTwoText;
    public PlayerData playerData;
    public int buttonTwoCost;
    public int buttonTwoBasePrice = 1000;
    public SpriteRenderer spriteRenderer;
    public Sprite nextItem;

    // Start is called before the first frame update
    void Start()
    {
        buttonTwoText.text = "Upgrade Axe! Cost: " + ButtonTwoCost();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonTwoClick()
    {
        if (playerData.ButtonTwoPurchases <= 0)
        {
            playerData.TotalWood -= buttonTwoBasePrice;
            playerData.ButtonTwoPurchases++;
            playerData.WoodMultiplyer++;
            ChangeSprite();
        } else
        {
            playerData.TotalWood -= ButtonTwoCost();
            playerData.ButtonTwoPurchases++;
            playerData.WoodMultiplyer++;
        }
    }

    public int ButtonTwoCost()
    {

        if (playerData.ButtonTwoPurchases <= 0)
        {
            buttonTwoCost = buttonTwoBasePrice;
            return buttonTwoCost;
        }
        else
        {
            buttonTwoCost = buttonTwoBasePrice * playerData.ButtonTwoPurchases;
            return buttonTwoCost;
        }
        
    }

    private void ChangeSprite() {
        spriteRenderer.sprite = nextItem;
    }   
}
