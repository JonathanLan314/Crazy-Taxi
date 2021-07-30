using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCharacterDeath : MonoBehaviour
{
    HumanNPCSpawner humanNPCSpawner;
    GameObject spawner;

    public GameObject character;
    public GameObject ragdoll;
    public RandomCharacterMovement randomCharacterMovement;
    public Collider collider;

    KillCounter killCounter;
    GameObject UIManager;

    void Start()
    {
        collider.enabled = true;
        character.SetActive(true);
        randomCharacterMovement.enabled = true;
        ragdoll.SetActive(false);
        spawner = GameObject.FindGameObjectWithTag("spawner");
        humanNPCSpawner = spawner.GetComponent<HumanNPCSpawner>();

        UIManager = GameObject.FindGameObjectWithTag("UIManager");
        killCounter = UIManager.GetComponent<KillCounter>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collider.enabled = false;
            character.SetActive(false);
            randomCharacterMovement.enabled = false;
            ragdoll.SetActive(true);
            humanNPCSpawner.NPCnum += 1;
            killCounter.killCount += 1;
            StartCoroutine(destroyObject());
        }

        if (other.gameObject.CompareTag("carNPC"))
        {
            collider.enabled = false;
            character.SetActive(false);
            randomCharacterMovement.enabled = false;
            ragdoll.SetActive(true);
            humanNPCSpawner.NPCnum += 1;
            StartCoroutine(destroyObject());
        }
    }

    IEnumerator destroyObject()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
