using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_PlayerAmount : MonoBehaviour
{

    public Camera playerCamera1;
    public Camera playerCamera2;
    public Camera playerCamera3;
    public Camera playerCamera4;
    public Camera spectateCamera;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    int playerAmount;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawnt Spieler abhängig von der Variable 2 bis 4
    void PlayerSpawn(int amount){
        switch(amount)
        {
            case 2:
                Debug.Log("2 Spieler");
                DeactivateAllPlayers();
                player1.SetActive(true);
                player2.SetActive(true);
                playerCamera1.rect = new Rect(0.0f, 0.0f, 0.5f, 1.0f);
                playerCamera2.rect = new Rect(0.5f, 0.0f, 0.5f, 1.0f);
                break;
            case 3:
                Debug.Log("3 Spieler");
                DeactivateAllPlayers();
                player1.SetActive(true);
                player2.SetActive(true);
                player3.SetActive(true);
                playerCamera1.rect = new Rect(0.0f, 0.5f, 0.5f, 0.5f);
                playerCamera2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
                playerCamera3.rect = new Rect(0.0f, 0.0f, 0.5f, 0.5f);
                spectateCamera.enabled = true;
                break;
            case 4:
                Debug.Log("4 Spieler");
                DeactivateAllPlayers();
                player1.SetActive(true);
                player2.SetActive(true);
                player3.SetActive(true);
                player4.SetActive(true);
                playerCamera1.rect = new Rect(0.0f, 0.5f, 0.5f, 0.5f);
                playerCamera2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
                playerCamera3.rect = new Rect(0.0f, 0.0f, 0.5f, 0.5f);
                playerCamera4.rect = new Rect(0.5f, 0.0f, 0.5f, 0.5f);
                break;
        }
    }

    void SetPlayerAount(int amount){
        playerAmount = amount;
    }

    public void TestFunctions(int amount){
        SetPlayerAount(amount);
        PlayerSpawn(playerAmount);
    }

    void DeactivateAllPlayers(){
        spectateCamera.enabled = false;
        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(false);
    }

}
