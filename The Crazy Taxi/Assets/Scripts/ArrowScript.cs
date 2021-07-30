using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public WantingTaxiScript wantingTaxiScript;
    public Transform target;
    public GameObject arrow;
    public Transform player;
    public Transform wantingTaxiCharacter;

    void Update()
    {
        gameObject.transform.position = player.position;

        if(wantingTaxiScript.isInCar == true)
        {
            transform.LookAt(target);
        }

        if(wantingTaxiScript.isInCar == false)
        {
            transform.LookAt(wantingTaxiCharacter);
        }
    }
}
