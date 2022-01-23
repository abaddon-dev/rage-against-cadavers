using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount = 10;

    public int GetCurrentAmmo()
    {
        return ammoAmount;
    }

    public void ReduceCurrentAmount()
    {
        int ammoAmountLeft = GetCurrentAmmo();
       
        if(ammoAmountLeft >0 && Input.GetMouseButtonDown(0))
        {
            ammoAmount--;
        }
    }
}
