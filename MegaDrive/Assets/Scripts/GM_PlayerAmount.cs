using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GM_PlayerAmount : MonoBehaviour
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
    public TextMeshProUGUI player1Points;
    public TextMeshProUGUI player2Points;
    public TextMeshProUGUI player3Points;
    public TextMeshProUGUI player4Points;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawnt Spieler abhängig von der Variable 2 bis 4
    public void PlayerSpawn(int amount){
        switch(amount)
        {
            case 2:
                Debug.Log("2 Spieler");
                DeactivateAllPlayers();
                player1.SetActive(true);
                player2.SetActive(true);
                playerCamera1.rect = new Rect(0.0f, 0.0f, 0.5f, 1.0f);
                playerCamera2.rect = new Rect(0.5f, 0.0f, 0.5f, 1.0f);
                player1Points.enabled = true;
                player2Points.enabled = true;
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
                player1Points.enabled = true;
                player2Points.enabled = true;
                player3Points.enabled = true;
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
                player1Points.enabled = true;
                player2Points.enabled = true;
                player3Points.enabled = true;
                player4Points.enabled = true;
                break;
        }
    }


    void DeactivateAllPlayers(){
        spectateCamera.enabled = false;
        player1.SetActive(false);
        player2.SetActive(false);
        player3.SetActive(false);
        player4.SetActive(false);
        player1Points.enabled = false;
        player2Points.enabled = false;
        player3Points.enabled = false;
        player4Points.enabled = false;
    }

    public void PlayerAmountFuctionTest(){
        Debug.Log("PlayerAmount Test");
    }
}