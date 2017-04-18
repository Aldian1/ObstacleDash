using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Communicator : MonoBehaviour {
    [SerializeField]
    private GameObject textobj;
public void Dead() {
        textobj.GetComponent<TextController>().isDead();
    }
}
