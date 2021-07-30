using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCdelete : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(delete());
    }

    IEnumerator delete()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
