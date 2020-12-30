using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerNoob : MonoBehaviour {

    public Transform player;
    public Rigidbody rb;

    [Header("UI Elements")]
    public Text deathText;
    public Text startText;

    [Header("")]
    public int deaths;
    public bool start = true;

    private void Start(){
        
        start = false;
        PrintText();
        rb.useGravity = false;
        player.position = new Vector3(0, 10, 0);

    }

    private void Update() {

        CheckDead();

        if (Input.GetKey("q")){

            Application.Quit();
        
        }

        deathText.text = "Deaths :  " + (int)(deaths);

        if (!start)
            player.position = new Vector3(0, 10, 0);

        if (Input.GetKey("p")){
            start = true;
            startText.text = "";
            rb.useGravity = true;
        }

    }

    private void CheckDead() {

        if (player.position.y < -10f && player.position.z < 160f){

            if (player.position.z > 53f){
                player.position = new Vector3(0, 1, 55);
            } else if (player.position.z > 37f){
                player.position = new Vector3(0, 1, 39);
            } else if (player.position.z > 22f){
                player.position = new Vector3(0, 1, 23);
            } else if (player.position.z > -1f){
                player.position = new Vector3(0, 1, 0);
            }

            deaths += 1;

        } else if (player.position.z > 180) {
            SceneManager.LoadScene("Pro", LoadSceneMode.Single);
        }

        if (deaths == 10) {

            deaths = 0;
            player.position = new Vector3(0, 1, 0);

        }

    }

    private void PrintText() {

        startText.text = "This is my first game by myself";
        startText.text += "\n";
        startText.text += "Controls:";
        startText.text += "\n";
        startText.text += "Use 'w','a','s','d' to move";
        startText.text += "\n";
        startText.text += "Use your mouse to point to the direction you want to face";
        startText.text += "\n";
        startText.text += "You will restart when you died 10 times";
        startText.text += "\n";
        startText.text += "Press 'q' to quit";
        startText.text += "\n";
        startText.text += "Press 'p' to play!";
        startText.text += "\n";
        startText.text += "Gordon";

    }

}