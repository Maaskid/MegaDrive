using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GM_GameMode : MonoBehaviour
{
    public bool timeModBool = true;
    public GoalBallBehavior goalBall;
    
    public TextMeshProUGUI timerText;

    public TextMeshProUGUI player1Points;
    float player1Score = 0;
    public TextMeshProUGUI player2Points;
    float player2Score = 0;
    public TextMeshProUGUI player3Points;
    float player3Score = 0;
    public TextMeshProUGUI player4Points;
    float player4Score = 0;

    bool gameOver = false;

    //time Attack
    
    public float timeLeft = 300;
    bool timeOver = false;

    //point attack
    public float pointsToGet = 300;
    bool scoreReached = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(timeModBool){
            setLables(timeLeft);
            timeAttackMode();
        }
        else{
            setLables(pointsToGet);
            pointAttackMode();
        }


    }

    void setLables(float gameModeFloat){
        timerText.text = gameModeFloat.ToString("0");
        player1Points.text = player1Score.ToString("0");
        player2Points.text = player2Score.ToString("0");
        player3Points.text = player3Score.ToString("0");
        player4Points.text = player4Score.ToString("0");
    }

    void timeAttackMode(){

        if(timeLeft > 0){
            timeLeft -= Time.deltaTime;

            if (goalBall.carCapture.name != null && timeLeft > 0){
            
            switch(goalBall.carCapture.name){
                case "Player 1":
                    player1Score += Time.deltaTime;
                    break;
                 case "Player 2":
                    player2Score += Time.deltaTime;
                    break;
                case "Player 3":
                    player3Score += Time.deltaTime;
                    break;
                case "Player 4":
                    player4Score += Time.deltaTime;
                    break;
            }
        }
        }
        else{
            Debug.Log("Game has endet");
            getWinner();
        }
    }

    void pointAttackMode(){
        if (goalBall.carCapture.name != null){
        if(scoreReached == false){
                switch(goalBall.carCapture.name){
                    case "Player 1":
                        player1Score += Time.deltaTime;
                        break;
                    case "Player 2":
                        player2Score += Time.deltaTime;
                        break;
                    case "Player 3":
                        player3Score += Time.deltaTime;
                        break;
                    case "Player 4":
                        player4Score += Time.deltaTime;
                        break;
                    }
                }
        }
        if(player1Score >= pointsToGet || player2Score >= pointsToGet || player3Score >= pointsToGet || player3Score >= pointsToGet && scoreReached == false){
            scoreReached = true;
            getWinner();
        }
    }

    public void switchModes(){
        //PointAttack
        if(timeModBool){
            timeModBool = false;
        }
        //TimeAttack
        else{
            timeModBool = true;
        }
    }

    void getWinner(){
        if(player1Score > player2Score && player1Score > player3Score && player1Score > player4Score){
            Debug.Log("Player 1 wins");
        }
        else if(player2Score > player1Score && player2Score > player3Score && player2Score > player4Score){
            Debug.Log("Player 2 wins");
        }
        else if(player3Score > player1Score && player3Score > player2Score && player1Score > player4Score){
            Debug.Log("Player 3 wins");
        }
        else{
            Debug.Log("Player 4 wins");
        }
    }

    public void setGameModePoints(float i){
        timeLeft = i;
        pointsToGet = i;
    }

    public void setGameModeBool(bool i){
        timeModBool = i;
    }

    public void GameModeFuctionTest(){
        Debug.Log("GameMode Test");
    }
}
