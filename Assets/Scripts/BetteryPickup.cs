using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetteryPickup : MonoBehaviour
{
    [SerializeField] float restoreAngle = 70;
    [SerializeField] float restoreIntensity = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponentInChildren<FlashLightSystem>().RestoreLightAngle(restoreAngle);
            other.gameObject.GetComponentInChildren<FlashLightSystem>().RestoreLightIntensity(restoreIntensity);
            Destroy(gameObject);
        }
    }
}
