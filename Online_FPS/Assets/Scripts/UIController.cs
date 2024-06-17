using System.Collections;
using System.Collections.Generic;
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
        
    }
}
