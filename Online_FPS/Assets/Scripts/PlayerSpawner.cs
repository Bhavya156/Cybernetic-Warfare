using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public static PlayerSpawner instance;

    private GameObject player;
    public GameObject deathEffect;

    public float respawnTime = 5f;

    private void Awake()
    {
        instance = this;
    }

    public GameObject playerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsConnected)
        {
            SpawnPlayer();
        }
    }

    public void SpawnPlayer()
    {
        Transform spawnPoint = SpawnManager.instance.GetSpawnPoint();

        player = PhotonNetwork.Instantiate(playerPrefab.name, spawnPoint.position, spawnPoint.rotation);
    }

    public void Die(string damager)
    {
        UIController.instance.deathText.text = "You were killed by " + damager;
        if (player != null)
        {
            StartCoroutine(DieCo());
        }
    }

    public IEnumerator DieCo()
    {
        PhotonNetwork.Instantiate(deathEffect.name, player.transform.position, Quaternion.identity);
        PhotonNetwork.Destroy(player);
        UIController.instance.DeathScreen.SetActive(true);

        yield return new WaitForSeconds(respawnTime);

        UIController.instance.DeathScreen.SetActive(false);

        SpawnPlayer();
    }
}
