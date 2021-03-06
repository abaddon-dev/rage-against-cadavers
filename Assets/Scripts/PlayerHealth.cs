using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    // create public method which reduces hitPoints by the amount of damage
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        
        if(hitPoints <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }    
    }
}
