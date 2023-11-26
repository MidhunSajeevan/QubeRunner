using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SimpleLauncher : MonoBehaviourPunCallbacks
{
    public GameObject PlayerPrefab; // Change the type to GameObject
    private float spawnRadius = 5f; // Adjust this to set the spawn radius

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to master");
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined a Room");

        // Generate a random position within a circle for the new player
        Vector3 randomOffset = Random.insideUnitCircle * spawnRadius;
        Vector3 spawnPosition = new Vector3(randomOffset.x, 0f, randomOffset.y);

        // Instantiate the player with the adjusted position
        PhotonNetwork.Instantiate(PlayerPrefab.name, spawnPosition, Quaternion.identity);
    }
}
