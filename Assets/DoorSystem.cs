using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSystem : MonoBehaviour {
    [SerializeField]
    private Transform SpawnPos;

    [SerializeField]
    private WaveController wavecontroller;

    private void OnTriggerEnter(Collider other) {
     
        if(other.tag == "Player") {
            other.transform.position = SpawnPos.position;
            wavecontroller.nextWave();
        }


    }

} 


