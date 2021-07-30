using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanNPCSpawner : MonoBehaviour
{
    public float randomX;
    public float randomZ;
    public float y = 0;
    Vector3 randomPostion;
    public GameObject NPC;

    public float NPCnum = 3;

    void Update()
    {
        while (NPCnum > 0)
        {
            randomX = Random.Range(-70, 100);
            randomZ = Random.Range(-80, 70);
            randomPostion = new Vector3(randomX, y, randomZ);
            Instantiate(NPC, randomPostion, Quaternion.identity);
            NPCnum = NPCnum - 1;
        }
    }
}
