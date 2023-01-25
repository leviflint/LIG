using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeMenu : MonoBehaviour
{
    GameObject upgradeMenu;

    // Start is called before the first frame update
    void Start()
    {
        upgradeMenu = GameObject.Find("UpgradeMenu");
        upgradeMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
