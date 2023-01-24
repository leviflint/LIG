using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public TextMeshProUGUI woodCounter;

    public PlayerData playerData;
    

    // Start is called before the first frame update
    void Start()
    {
        woodCounter.text = "" + playerData.TotalWood;
    }

    // Update is called once per frame
    void Update()
    {
        woodCounter.text = "" + playerData.TotalWood;
    }

    private void SpawnPlayer()
    {
        
    }
}
