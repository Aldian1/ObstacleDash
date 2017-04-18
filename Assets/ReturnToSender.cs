using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToSender : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        if (other.transform.tag == "Player") {
            other.transform.position = new Vector3(2.9F, 4.5F, -17.4F);
        }
    } 
}
