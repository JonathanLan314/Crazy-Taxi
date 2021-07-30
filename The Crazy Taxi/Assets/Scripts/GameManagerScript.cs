using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public MoneyCounter moneyCounter;
    float timer;
    public float timeSpeed = 0.5f;
    public float randomCash;

    public GameObject destination;
    public LocationScript locationScript;
    public WantingTaxiScript wantingTaxiScript;

    public GameObject characerWantTaxi;

    float randomPickup;
    float randomLocation;

    public GameObject location1;
    public GameObject location2;
    public GameObject location3;
    public GameObject location4;
    public GameObject location5;
    public GameObject location6;
    public GameObject location7;
    public GameObject location8;
    public GameObject location9;
    public GameObject location10;
    public GameObject location11;
    public GameObject location12;
    public GameObject location13;

    public GameObject location1Pickup;
    public GameObject location2Pickup;
    public GameObject location3Pickup;
    public GameObject location4Pickup;
    public GameObject location5Pickup;
    public GameObject location6Pickup;
    public GameObject location7Pickup;
    public GameObject location8Pickup;
    public GameObject location9Pickup;
    public GameObject location10Pickup;
    public GameObject location11Pickup;
    public GameObject location12Pickup;
    public GameObject location13Pickup;

    public bool restart;

    void Start()
    {
        timer = 10;
        restart = false;
        randomPickup = Random.Range(1, 13);
        randomLocation = Random.Range(1, 13);

        if (randomLocation == 1)
        {
            destination.transform.position = location1.transform.position;
        }
        if (randomLocation == 2)
        {
            destination.transform.position = location2.transform.position;
        }
        if (randomLocation == 3)
        {
            destination.transform.position = location3.transform.position;
        }
        if (randomLocation == 4)
        {
            destination.transform.position = location4.transform.position;
        }
        if (randomLocation == 5)
        {
            destination.transform.position = location5.transform.position;
        }
        if (randomLocation == 6)
        {
            destination.transform.position = location6.transform.position;
        }
        if (randomLocation == 7)
        {
            destination.transform.position = location7.transform.position;
        }
        if (randomLocation == 8)
        {
            destination.transform.position = location8.transform.position;
        }
        if (randomLocation == 9)
        {
            destination.transform.position = location9.transform.position;
        }
        if (randomLocation == 10)
        {
            destination.transform.position = location10.transform.position;
        }
        if (randomLocation == 11)
        {
            destination.transform.position = location11.transform.position;
        }
        if (randomLocation == 12)
        {
            destination.transform.position = location12.transform.position;
        }
        if (randomLocation == 13)
        {
            destination.transform.position = location13.transform.position;
        }
        ////
        if (randomPickup == 1)
        {
            characerWantTaxi.transform.position = location1Pickup.transform.position;
        }

        if (randomPickup == 2)
        {
            characerWantTaxi.transform.position = location2Pickup.transform.position;
        }

        if (randomPickup == 3)
        {
            characerWantTaxi.transform.position = location3Pickup.transform.position;
        }

        if (randomPickup == 4)
        {
            characerWantTaxi.transform.position = location4Pickup.transform.position;
        }

        if (randomPickup == 5)
        {
            characerWantTaxi.transform.position = location5Pickup.transform.position;
        }

        if (randomPickup == 6)
        {
            characerWantTaxi.transform.position = location6Pickup.transform.position;
        }

        if (randomPickup == 7)
        {
            characerWantTaxi.transform.position = location7Pickup.transform.position;
        }

        if (randomPickup == 8)
        {
            characerWantTaxi.transform.position = location8Pickup.transform.position;
        }

        if (randomPickup == 9)
        {
            characerWantTaxi.transform.position = location9Pickup.transform.position;
        }

        if (randomPickup == 10)
        {
            characerWantTaxi.transform.position = location10Pickup.transform.position;
        }

        if (randomPickup == 11)
        {
            characerWantTaxi.transform.position = location11Pickup.transform.position;
        }

        if (randomPickup == 12)
        {
            characerWantTaxi.transform.position = location12Pickup.transform.position;
        }

        if (randomPickup == 13)
        {
            characerWantTaxi.transform.position = location13Pickup.transform.position;
        }
    }

    void Update()
    {
        if (wantingTaxiScript.isInCar == false)
        {
            destination.SetActive(false);         
        }

        if (wantingTaxiScript.isInCar == true)
        {
            destination.SetActive(true);
            timer -= Time.deltaTime * timeSpeed;
        }

        if (locationScript.isArrived == true)
        {
            randomCash = Random.Range(5, 15);
            locationScript.isArrived = false;
            restart = true;
            moneyCounter.tip += timer += randomCash;

        }

        if (restart == true)
        {
            timer = 10;
            randomPickup = Random.Range(1, 13);
            randomLocation = Random.Range(1, 13);
            characerWantTaxi.SetActive(true);
            wantingTaxiScript.isInCar = false;
            wantingTaxiScript.isNear = false;
            wantingTaxiScript.SetSkin();
            destination.SetActive(false);

        if (randomLocation == 1)
        {
            destination.transform.position = location1.transform.position;
        }
        if (randomLocation == 2)
        {
            destination.transform.position = location2.transform.position;
        }
        if (randomLocation == 3)
        {
            destination.transform.position = location3.transform.position;
        }
        if (randomLocation == 4)
        {
            destination.transform.position = location4.transform.position;
        }
        if (randomLocation == 5)
        {
            destination.transform.position = location5.transform.position;
        }
        if (randomLocation == 6)
        {
            destination.transform.position = location6.transform.position;
        }
        if (randomLocation == 7)
        {
            destination.transform.position = location7.transform.position;
        }
        if (randomLocation == 8)
        {
            destination.transform.position = location8.transform.position;
        }
        if (randomLocation == 9)
        {
            destination.transform.position = location9.transform.position;
        }
        if (randomLocation == 10)
        {
            destination.transform.position = location10.transform.position;
        }
        if (randomLocation == 11)
        {
            destination.transform.position = location11.transform.position;
        }
        if (randomLocation == 12)
        {
            destination.transform.position = location12.transform.position;
        }
        if (randomLocation == 13)
        {
            destination.transform.position = location13.transform.position;
        }

                ////
        if (randomPickup == 1)
        {
            characerWantTaxi.transform.position = location1Pickup.transform.position;
        }

        if (randomPickup == 2)
        {
            characerWantTaxi.transform.position = location2Pickup.transform.position;
        }

        if (randomPickup == 3)
        {
            characerWantTaxi.transform.position = location3Pickup.transform.position;
        }

        if (randomPickup == 4)
        {
            characerWantTaxi.transform.position = location4Pickup.transform.position;
        }

        if (randomPickup == 5)
        {
            characerWantTaxi.transform.position = location5Pickup.transform.position;
        }

        if (randomPickup == 6)
        {
            characerWantTaxi.transform.position = location6Pickup.transform.position;
        }

        if (randomPickup == 7)
        {
            characerWantTaxi.transform.position = location7Pickup.transform.position;
        }

        if (randomPickup == 8)
        {
            characerWantTaxi.transform.position = location8Pickup.transform.position;
        }

        if (randomPickup == 9)
        {
            characerWantTaxi.transform.position = location9Pickup.transform.position;
        }

        if (randomPickup == 10)
        {
            characerWantTaxi.transform.position = location10Pickup.transform.position;
        }

        if (randomPickup == 11)
        {
            characerWantTaxi.transform.position = location11Pickup.transform.position;
        }

        if (randomPickup == 12)
        {
            characerWantTaxi.transform.position = location12Pickup.transform.position;
        }

        if (randomPickup == 13)
        {
            characerWantTaxi.transform.position = location13Pickup.transform.position;
        }
            restart = false;
        }
    }
}
