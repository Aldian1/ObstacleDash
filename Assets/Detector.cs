using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour {

    private void OnCollisionEnter(Collision collision) {

        if (collision.transform.tag == "Player" && this.gameObject.activeSelf == true) {
            // Debug.Log("Dead!");
            //collision.transform.position = new Vector3(16.28F,6.95F,-19.89F);
            collision.gameObject.GetComponent<Communicator>().Dead();
            Debug.Log("Killed by: " + this.name);
        }
    }
} 

