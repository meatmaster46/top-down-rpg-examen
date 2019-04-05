using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHealthPotion : MonoBehaviour
{
    public int healing = 6;

    public void ButtonHealth()
    {
        GameObject.FindObjectOfType<PlayerAttack>().health += healing;
        DestroyImmediate(gameObject, true);
        //this.gameObject.SetActive(false);
    }
}