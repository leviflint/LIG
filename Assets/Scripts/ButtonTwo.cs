using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTwo : MonoBehaviour
{

    public Text buttonTwoText;
    public PlayerData playerData;
    private int buttonTwoCost;
    private int buttonTwoBasePrice = 1000;
    public SpriteRenderer spriteRenderer;
    public Sprite nextItem;
    public QuanityData quanityData;

    // Start is called before the first frame update
    void Start()
    {
        buttonTwoText.text = "" + ButtonTwoCost();
    }

    // Update is called once per frame
    void Update()
    {
        buttonTwoText.text = "" + ButtonTwoCost();
    }

    public void OnButtonTwoClick()
    {
        if (playerData.ButtonTwoPurchases <= 0 && playerData.TotalWood >= ButtonTwoCost())
        {
            playerData.TotalWood -= buttonTwoBasePrice;
            playerData.ButtonTwoPurchases++;
            playerData.WoodMultiplyer++;
            buttonTwoText.text = "" + ButtonTwoCost();
            ChangeSprite();
        } if (playerData.ButtonTwoPurchases >= 1 && playerData.TotalWood >= ButtonTwoCost())
        {
            playerData.TotalWood -= ButtonTwoCost();
            playerData.ButtonTwoPurchases++;
            playerData.WoodMultiplyer++;
            buttonTwoText.text = "" + ButtonTwoCost();
        } else
        {
            // Throw Error Here
        }
    }

    private int ButtonTwoCost()
    {

        if (playerData.ButtonTwoPurchases <= 0)
        {
            buttonTwoCost = buttonTwoBasePrice;
            return buttonTwoCost;
        }
        else
        {
            buttonTwoCost = (buttonTwoBasePrice * (playerData.ButtonTwoPurchases + 1) * quanityData.currentQuanity);
            return buttonTwoCost;
        }
        
    }

    private void ChangeSprite() {
        spriteRenderer.sprite = nextItem;
    }   
}
