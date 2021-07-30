using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationScript : MonoBehaviour
{

    public bool isArrived;

    public WantingTaxiScript wantingTaxiScript;

    public GameObject BusinessManShirt;
    public GameObject BusinessManSuit;
    public GameObject BusinessWoman;
    public GameObject WomanCoat;
    public GameObject WomanJacket;
    public GameObject ManHoodie;
    public GameObject ManJacket;

    public Transform spawnPoint;

    bool spawned;

    void Start()
    {
        spawned = false;
        isArrived = false;
    }

    void Update()
    {
        if (isArrived == true && spawned == false)
        {
            isArrived = false;

            if (wantingTaxiScript.character1 == true)
            {
                Instantiate(BusinessManShirt, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character2 == true)
            {
               Instantiate(BusinessManSuit, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character3 == true)
            {
                  Instantiate(BusinessWoman, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character4 == true)
            {
                 Instantiate(WomanCoat, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character5 == true)
            {
                 Instantiate(WomanJacket, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character6 == true)
            {
                Instantiate(ManHoodie, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character7 == true)
            {
                Instantiate(ManJacket, spawnPoint.position, Quaternion.identity);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isArrived = true;

            if (wantingTaxiScript.character1 == true)
            {
                Instantiate(BusinessManShirt, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character2 == true)
            {
                Instantiate(BusinessManSuit, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character3 == true)
            {
                Instantiate(BusinessWoman, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character4 == true)
            {
                Instantiate(WomanCoat, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character5 == true)
            {
                Instantiate(WomanJacket, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character6 == true)
            {
                Instantiate(ManHoodie, spawnPoint.position, Quaternion.identity);
            }

            if (wantingTaxiScript.character7 == true)
            {
                Instantiate(ManJacket, spawnPoint.position, Quaternion.identity);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isArrived = false;
        }
    }

}
