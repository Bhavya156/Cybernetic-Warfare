using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public TextMeshProUGUI overheatedMessage;
    public Slider WeaponTempSlider;

     public Slider HealthSlider;


    public GameObject DeathScreen;
    public TextMeshProUGUI deathText;

    public TextMeshProUGUI kills, deaths;

    public GameObject LeaderBoard;
    public LeaderboardPlayer leaderboardPlayerDisplay;
    public GameObject endScreen;

    public TextMeshProUGUI timerText;

    public GameObject optionsScreen;


    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            ShowHideOptions();
        }

        if (optionsScreen.activeInHierarchy && Cursor.lockState != CursorLockMode.None) {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void ShowHideOptions() {
        if(!optionsScreen.activeInHierarchy) {
            optionsScreen.SetActive(true);
        } else {
            optionsScreen.SetActive(false);
        }
    }

    public void ReturnToMainMenu() {
        PhotonNetwork.AutomaticallySyncScene = false;
        PhotonNetwork.LeaveRoom();
    }

    public void QuitGame() {
        Application.Quit();
    }
}
