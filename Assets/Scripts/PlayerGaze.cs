using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tengio {
    public class PlayerGaze : MonoBehaviour {

        private Transform mCamera;
        private PlayerGrab playerGrab;


        private void Awake() {
            mCamera = Camera.main.transform;
            playerGrab = GetComponent<PlayerGrab>();

        }

        private void Update() {
            RaycastForward();
        }

        private void RaycastForward() {
            Ray ray = new Ray(mCamera.position, mCamera.forward);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo) && hitInfo.transform != null) {
                string layerName = LayerMask.LayerToName(hitInfo.transform.gameObject.layer);
                switch (layerName) {
                    case "Interactive":
                        hitInfo.transform.SendMessage("OnGazeEnter");
                        playerGrab.gazedObject = hitInfo.transform;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
