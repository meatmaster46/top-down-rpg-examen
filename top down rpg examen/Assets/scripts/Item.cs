using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    private void Start()
    {
        inventory = FindObjectOfType<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Inventory>())
        {
            for (int i = 0; i < inventory.inventorySlots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //add to inventory
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.inventorySlots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}