using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour {

    private bool activated;

    private void Awake() {
        activated = false;
    }

    private void OnCollisionEnter(Collision collision) {
        if ("Box".Equals(collision.transform.tag)) {
            if (!activated) {
                activated = true;
                transform.Translate(0F, -0.05F, 0F);
            }
        }
    }

    //private void OnCollisionStay(Collision collision) {
    //    if ("Box".Equals(collision.transform.tag)) {
    //        transform.position =
    //    }
    //}

    private void OnCollisionExit(Collision collision) {
        if (activated) {
            transform.Translate(0F, 0.05F, 0F);
            activated = false;
        }
    }
}
