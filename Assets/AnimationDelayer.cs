using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDelayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Animation");
	}
	
    private IEnumerator Animation() {
        float time = Random.Range(0.1F, 4F);
        yield return new WaitForSeconds(time);
        GetComponent<Animation>().Play();
    }
}
