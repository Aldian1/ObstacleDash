using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour {
    [SerializeField]
    private float rocketspeed;

    private GameObject target;
    [SerializeField]
    private GameObject hiteffect;

    private void Start() {
        target = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update() {
       
        transform.Translate(Vector3.forward * rocketspeed * Time.deltaTime);
    }


    private void OnCollisionEnter(Collision collision) {
        Instantiate(hiteffect, transform.position, Quaternion.identity);

        if(collision.transform.tag == "Player") {
            collision.gameObject.GetComponent<Communicator>().Dead();
            Debug.Log("Killed by rocket");
        }
    }
}
