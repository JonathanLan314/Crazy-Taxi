using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PathCreation.Examples
{
    public class CarScript : MonoBehaviour
    {
        public PathFollower pathFollower;
        bool canMove;

        void Start()
        {
            canMove = true;
        }

        void Update()
        {
            if(canMove == true)
            {
                pathFollower.enabled = true;
            }

            if (canMove == false)
            {
                pathFollower.enabled = false;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("humanNPC") || other.gameObject.CompareTag("carNPC"))
            {
                StartCoroutine(RigidbodyActive());
            }
        }

        IEnumerator RigidbodyActive()
        {
            canMove = false;
            yield return new WaitForSeconds(5);
            canMove = true;
            yield break;
        }
    }

}
