using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tengio {
    public class InteractiveObjectBehaviour : MonoBehaviour {
        public void OnGazeEnter() {
            transform.name = "Gazed";
        }

        public void OnGazeExit() {
            transform.name = "Not Gazed";
        }
    }
}
