using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomCharacterMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    Vector3 randomPostion;
    public float randomX;
    public float randomZ;
    public float y = 0;

    public float randomTime;

    void Start()
    {
        StartCoroutine(SearchTargetPos());
    }

    IEnumerator SearchTargetPos()
    {
        while(true)
        {
        randomX = Random.Range(-160, 160);
        randomZ = Random.Range(-160, 160);
        randomTime = Random.Range(30, 50);
        randomPostion = new Vector3(randomX, y, randomZ);
        agent.SetDestination(randomPostion);
        yield return new WaitForSeconds(randomTime);
        }
    }
}
