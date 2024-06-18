using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderboardPlayer : MonoBehaviour
{
    public TextMeshProUGUI playerName, kills_text, death_text;

    public void SetDetails(string name, int kills, int deaths) {
        playerName.text = name;
        kills_text.text = kills.ToString();
        death_text.text = deaths.ToString();
    }
}
