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

    public TextMeshProUGUI winnerText;
    public TextMeshProUGUI score1Text;
    public TextMeshProUGUI score1Label;
    public TextMeshProUGUI score2Text;
    public TextMeshProUGUI score2Label;
    public TextMeshProUGUI score3Text;
    public TextMeshProUGUI score3Label;
    public TextMeshProUGUI score4Text;
    public TextMeshProUGUI score4Label;


    //time Attack
    
    public float timeLeft = 300;
    bool timeOver = false;

    //point attack
    public float pointsToGet = 300;
    bool scoreReached = false;

    public Material p1M;
    public Material p2M;
    public Material p3M;
    public Material p4M;

    public GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        setColors();
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
            gameOver = true;
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
            gameOver = true;
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
        setScore();
        winScreen.SetActive(true);
        if(player1Score > player2Score && player1Score > player3Score && player1Score > player4Score){
            winnerText.text = "Player 1 wins!";
            Debug.Log("Player 1 wins");
        }
        else if(player2Score > player1Score && player2Score > player3Score && player2Score > player4Score){
            winnerText.text = "Player 2 wins!";
            Debug.Log("Player 2 wins");
        }
        else if(player3Score > player1Score && player3Score > player2Score && player1Score > player4Score){
            winnerText.text = "Player 3 wins!";
            score3Text.enabled = true;
            score3Label.enabled = true;
            Debug.Log("Player 3 wins");
        }
        else{
            winnerText.text = "Player 4 wins!";
            score3Text.enabled = true;
            score3Label.enabled = true;
            score4Text.enabled = true;
            score4Label.enabled = true;
            Debug.Log("Player 4 wins");
        }
    }

    void setScore(){
        score1Text.text = player1Score.ToString("0");
        score2Text.text = player2Score.ToString("0");
        score3Text.text = player3Score.ToString("0");
        score4Text.text = player4Score.ToString("0");
    }

    void setColors(){
        player1Points.color = p1M.color;
        score1Text.color = p1M.color;
        score1Label.color = p1M.color;

        player2Points.color = p2M.color;
        score2Text.color = p2M.color;
        score2Label.color = p2M.color;

        player3Points.color = p3M.color;
        score3Text.color = p3M.color;
        score3Label.color = p3M.color;

        player4Points.color = p4M.color;
        score4Text.color = p4M.color;
        score4Label.color = p4M.color;
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
