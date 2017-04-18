using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets;
public class TextController : MonoBehaviour {
    [SerializeField]private GameObject textobj;
    private GameObject player;
    bool dead;
    [SerializeField]
    private GameObject PB;
    [SerializeField]
    private GameObject wavecontroller;
    // Use this for initialization
    void Start() {
        StartCoroutine("Text_");
        player = GameObject.FindGameObjectWithTag("Player");
        player.GetComponent<CharacterController>().enabled = false;
    }
    private void Update() {
            if(dead) {
            if(Input.GetKeyDown(KeyCode.R)) {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
    private IEnumerator Text_() {
        Time.timeScale = 1;
        PB.GetComponent<Text>().text = " ";
        textobj.GetComponent<Text>().text = "Reach the end of the room!";
        yield return new WaitForSeconds(2F);
        textobj.GetComponent<Text>().text = "3";
        yield return new WaitForSeconds(.2F);
        textobj.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(.2F);
        textobj.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(.2F);
        textobj.GetComponent<Text>().text = "Go!";
        player.GetComponent<CharacterController>().enabled = true;
        yield return new WaitForSeconds(.2F);
        textobj.GetComponent<Text>().text = "";


    }

    public void UpdateText(int waveid) {
        StartCoroutine(UpdateText_(waveid));
    }

    private IEnumerator UpdateText_(int waveid) {
        textobj.GetComponent<Text>().text = "Wave: " + waveid;
        yield return new WaitForSeconds(1);
        textobj.GetComponent<Text>().text = "";
    }

    public void isDead() {
        textobj.GetComponent<Text>().text = "Dead. Press R to retry!";
        PB.GetComponent<Text>().text = "Wave " + wavecontroller.GetComponent<WaveController>().CurrentWave +"/" + Time.timeSinceLevelLoad.ToString("00.00");
        Time.timeScale = 0;
        dead = true;
    }

    public void End() {
        textobj.GetComponent<Text>().text = "Game Over! - Press R to restart";
        PB.GetComponent<Text>().text = "You beat the game in: " + Time.timeSinceLevelLoad.ToString("00.00") + " nice job!";
        Time.timeScale = 0;
        dead = true;
    }
}
