using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Info : MonoBehaviour
{

    public static GM_Info Instance;
    public int playerAmount = 4;
    //timer oder Punkte Cap
    public float gameValue = 60;
    //bei true Time Attack
    public bool gameModeBool = true;

    public bool player1Model;
    public bool player2Model;
    public bool player3Model;
    public bool player4Model;

    private void Awake() {
         if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }

    public void setPlayerAmount(int i){
        playerAmount = i;
    }

    public void setGameValue(float i){
        gameValue = i;
    }

    public void setGameModeBool(bool i){
        gameModeBool = i;
    }

    public void setPlayerModel(int player, bool plbool){
            if(player == 1){
                player1Model = plbool;
            }
            else if(player == 2){
                player2Model = plbool;
            }
            else if(player == 3){
                player3Model = plbool;
            }
            else if(player == 4){
                player4Model = plbool;
            }
            
    }
}
