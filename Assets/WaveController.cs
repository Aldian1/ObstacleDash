using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveController : MonoBehaviour {
    [SerializeField]
    private GameObject[] waveset;
    [SerializeField]
    private float wavespeed;
    [SerializeField]
    public int CurrentWave;

    [SerializeField]
    private Text timerObject;

   [SerializeField] private TextController startcontroller;

    public void Update() {
        waveset[CurrentWave].transform.Translate(Vector3.right * wavespeed * Time.deltaTime);
        timerObject.text = "Time: " + Time.timeSinceLevelLoad.ToString("00.00");
        

    }

    public void nextWave() {
        if(CurrentWave >= waveset.Length) {
            startcontroller.End();
        }
        waveset[CurrentWave].SetActive(false);
        CurrentWave += 1;
        startcontroller.UpdateText(CurrentWave);
        waveset[CurrentWave].SetActive(true);
    }
}
