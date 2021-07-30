using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PathCreation.Examples
{
    public class CarMovement : MonoBehaviour
    {
        public PathCreator pathCreator;
        public float speed = 5;
        float distanceTravelled;

        public bool canMove;

        void Start()
        {
            canMove = true;
        }

        void Update()
        {
            if(canMove == true)
            {
                distanceTravelled += speed * Time.deltaTime;
                transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
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

