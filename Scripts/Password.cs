using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour {

    public GameObject mainMenuObject;

    public Text Version;

    [Header("Version")]
    public string version;

    void Start() {

        Version.text = "Version : " + (string)(version);

    }

    public void StartGame() {

        SceneManager.LoadScene("Noob", LoadSceneMode.Single);

    }

    public void QuitGame() {

        Application.Quit();

    }

}