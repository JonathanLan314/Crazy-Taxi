using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironementManager : MonoBehaviour
{
    public GameObject rain;
    float randomTime;

    public bool isRaining;

    void Start()
    {
        rain.SetActive(false);
    }

    void Update()
    {
        StartCoroutine(Rain());   
    }

    IEnumerator Rain()
    {
        if(isRaining == false)
        {
            randomTime = Random.Range(10, 30);
            yield return new WaitForSeconds(randomTime);
            rain.SetActive(false);
            isRaining = true;
        }

        if(isRaining == true)
        {
            randomTime = Random.Range(10, 30);
            yield return new WaitForSeconds(randomTime);
            rain.SetActive(true);
            isRaining = false;
        }
    }
}
