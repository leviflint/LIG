using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public Text woodCounterTab;
    public Text woodCounterFull;
    GameObject fullCurrencyList;
    public PlayerData playerData;
    

    // Start is called before the first frame update
    void Start()
    {
        fullCurrencyList = GameObject.Find("CurrencyListFull");
        fullCurrencyList.SetActive(false);
        woodCounterTab.text = "" + playerData.TotalWood;
        woodCounterFull.text = "" + playerData.TotalWood;
    }

    // Update is called once per frame
    void Update()
    {
        woodCounterTab.text = "" + playerData.TotalWood;
    }

    private void SpawnPlayer()
    {
        
    }
}
