using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float hitPoint = 100f;

    public void TakeDamage( float damage )
    {
        BroadcastMessage("onDamageTaken");

        hitPoint -= damage;
        if(hitPoint<=0)
        {
            GetComponent<EnemyAI>().OnDead();
        }
    }
}
