using System.Collections;
using System.Collections.Generic;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class RoomButtonScript : MonoBehaviour
{
    public TextMeshProUGUI buttonText;

    private RoomInfo info;


    public void SetButtonDetail(RoomInfo inputInfo) {
        info = inputInfo;
        buttonText.text = info.Name;
    }

    public void OpenRoom() {
        Launcher.instance.JoinRoom(info);
    }
}
