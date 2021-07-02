using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GM_Info GMI;
    GM_GameMode gameMode;
    GM_PlayerAmount playerAmount;

    // Start is called before the first frame update
    void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("GM_Info");
        GMI = g.GetComponent<GM_Info>();

        gameMode = gameObject.GetComponent<GM_GameMode>();
        playerAmount = gameObject.GetComponent<GM_PlayerAmount>();

        gameMode.GameModeFuctionTest();
        playerAmount.PlayerAmountFuctionTest();

        playerAmount.PlayerSpawn(GMI.playerAmount);
        gameMode.setGameModeBool(GMI.gameModeBool);
        gameMode.setGameModePoints(GMI.gameValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
