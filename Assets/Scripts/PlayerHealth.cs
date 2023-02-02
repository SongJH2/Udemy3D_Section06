using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoint = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TakeDamage(float damage)
    {
        hitPoint -= damage;

        GetComponent<DisplayDamage>().ShowDamageImpact();

        if (hitPoint <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
