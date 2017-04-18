using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Tengio {
    public class PlayerGrab : MonoBehaviour {

        private const float MAX_GRABBING_DISTANCE = 1.5F;

        public Transform gazedObject { get; set; }
        private Transform grabbedObject;

        private void Update() {
            if (Input.GetMouseButtonDown(0) && gazedObject != null) {
                if (Vector3.Distance(gazedObject.position, transform.position) < MAX_GRABBING_DISTANCE) {
                    grabbedObject = gazedObject;
                    grabbedObject.SetParent(transform);
                    grabbedObject.localPosition = new Vector3(0F, 0.25F, 1.5F);
                    grabbedObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }

            if (Input.GetMouseButtonUp(0) && grabbedObject != null) {
                grabbedObject.GetComponent<Rigidbody>().isKinematic = false;
                grabbedObject.SetParent(null);
            }
        }
    }
}