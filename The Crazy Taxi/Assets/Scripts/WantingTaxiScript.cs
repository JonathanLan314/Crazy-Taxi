using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WantingTaxiScript : MonoBehaviour
{
    public Transform target;
    public float speed;
    public bool isNear;
    public bool isInCar;

    public GameManagerScript gameManagerScript;

    public SkinnedMeshRenderer BusinessManShirt;
    public SkinnedMeshRenderer BusinessManSuit;
    public SkinnedMeshRenderer BusinessWoman;
    public SkinnedMeshRenderer WomanCoat;
    public SkinnedMeshRenderer WomanJacket;
    public SkinnedMeshRenderer ManHoodie;
    public SkinnedMeshRenderer ManJacket;

    public bool character1;
    public bool character2;
    public bool character3;
    public bool character4;
    public bool character5;
    public bool character6;
    public bool character7;


    float rand;

    void Start()
    {
        SetSkin();
        rand = Random.Range(1, 7);
        isInCar = false;
        gameObject.SetActive(true);
    }

    void Update()
    {
        transform.LookAt(target);
        if(isNear == true)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isNear = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isNear = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            isInCar = true;
        }
    }

    public void SetSkin()
    {
        character1 = false;
        character2 = false;
        character3 = false;
        character4 = false;
        character5 = false;
        character6 = false;
        character7 = false;

        rand = Random.Range(1, 7);

                    if (rand == 1)
            {
                BusinessManShirt.enabled = true;
                BusinessManSuit.enabled = false;
                BusinessWoman.enabled = false;
                WomanCoat.enabled = false;
                WomanJacket.enabled = false;
                ManHoodie.enabled = false;
                ManJacket.enabled = false;
                character1 = true;
            }

            if (rand == 2)
            {
                BusinessManShirt.enabled = false;
                BusinessManSuit.enabled = true;
                BusinessWoman.enabled = false;
                WomanCoat.enabled = false;
                WomanJacket.enabled = false;
                ManHoodie.enabled = false;
                ManJacket.enabled = false;
                character2 = true;
            }

            if (rand == 3)
            {
                BusinessManShirt.enabled = false;
                BusinessManSuit.enabled = false;
                BusinessWoman.enabled = true;
                WomanCoat.enabled = false;
                WomanJacket.enabled = false;
                ManHoodie.enabled = false;
                ManJacket.enabled = false;
                character3 = true;
            }

            if (rand == 4)
            {
                BusinessManShirt.enabled = false;
                BusinessManSuit.enabled = false;
                BusinessWoman.enabled = false;
                WomanCoat.enabled = true;
                WomanJacket.enabled = false;
                ManHoodie.enabled = false;
                ManJacket.enabled = false;
                character4 = true;
            }

            if (rand == 5)
            {
                BusinessManShirt.enabled = false;
                BusinessManSuit.enabled = false;
                BusinessWoman.enabled = false;
                WomanCoat.enabled = false;
                WomanJacket.enabled = true;
                ManHoodie.enabled = false;
                ManJacket.enabled = false;
                character5 = true;
            }

            if (rand == 6)
            {
                BusinessManShirt.enabled = false;
                BusinessManSuit.enabled = false;
                BusinessWoman.enabled = false;
                WomanCoat.enabled = false;
                WomanJacket.enabled = false;
                ManHoodie.enabled = true;
                ManJacket.enabled = false;
                character6 = true;
            }

            if (rand == 7)
            {
                BusinessManShirt.enabled = false;
                BusinessManSuit.enabled = false;
                BusinessWoman.enabled = false;
                WomanCoat.enabled = false;
                WomanJacket.enabled = false;
                 ManHoodie.enabled = false;
                ManJacket.enabled = true;
                character7 = true;
            }
    }

}
