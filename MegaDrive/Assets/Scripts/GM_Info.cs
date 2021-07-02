using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM_Info : MonoBehaviour
{

    public GM_Info Instance;
    public int playerAmount = 4;
    //timer oder Punkte Cap
    public float gameValue = 60;
    //bei true Time Attack
    public bool gameModeBool = true;

    private void Awake() {
        if(Instance == null){
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if(Instance != this){
            Destroy(gameObject);
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
}