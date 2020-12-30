using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour {

    public Transform player;

    [Header("UI Elements")]
    public Text text;

    void Update() {

        CheckLevel();

    }

    void CheckLevel() {

        if (player.position.z > -1f)
            text.text = "Level 1 :  normal jumps";
        if (player.position.z > 22f)
            text.text = "Level 2 :  spheres";
        if (player.position.z > 37f)
            text.text = "Level 3 :  ghost blocks";
        if (player.position.z > 53f)
            text.text = "Level 4 :  barriers";
        if (player.position.z > 71f)
            text.text = "Level 5 :  RUN!!!!!!!!!!!!!!!!!!!!!!";

    }

}