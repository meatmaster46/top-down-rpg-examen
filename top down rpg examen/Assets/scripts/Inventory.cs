using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> inventory = new List<Item>();


    public GameObject[] inventorySlots;
    public bool inventoryOpen = false;
    public bool[] isFull;

    public GameObject inventoryMenu;

    private void Update()
    {
        if (Input.GetKeyDown("m") && inventoryOpen == false)
        {
            inventoryMenu.SetActive(true);
            inventoryOpen = true;
        }
        //if (Input.GetKeyDown("m") && inventoryOpen == true)
        //{
        //    inventoryMenu.SetActive(false);
        //    inventoryOpen = false;
        //}
    }
}