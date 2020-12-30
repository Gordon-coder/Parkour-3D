using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public Transform player;

    [Header("UI Elements")]
    public Text level;
    public Text deathText;

    [Header("")]
    public int deaths;

    [Header("")]
    public int Game;

    private void Update() {

        CheckDead();

        if (Input.GetKey("q")){

            Application.Quit();
        
        }

        deathText.text = "Deaths :  " + (int)(deaths);

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
            if (Game == 2)
                SceneManager.LoadScene("Hacker", LoadSceneMode.Single);
            if (Game == 3)
                level.text = "YOU WON!!\n\nPress 'q' to quit";

        }

        if (deaths == 10) {

            deaths = 0;
            player.position = new Vector3(0, 1, 0);

        }

    }

}