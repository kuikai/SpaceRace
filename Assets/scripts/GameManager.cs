using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    public GameObject GameOverCanvas;
    public Text Player1ScoreText;
    public Text Player2ScoreText;
    public Text PlayerWonText;
    public Text playerWonPoints;

    public bool GameOver;

    public bool Player1Won;

    private int Player1Score = 0;
    private int Player2Score = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        FindObjectOfType<Player1>().OnAddpointToplayer += AddUpdateAndaddScoreToPlayer1;
        FindObjectOfType<Player2>().OnAddpointToplayer += AddUpdateAndaddScoreToPlayer2;
        FindObjectOfType<GameTimerBar>().OnGameOver += Gameover;
           Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOver == true){
          if(Input.GetKeyDown(KeyCode.Space)){
              SceneManager.LoadScene(0);
          }
        }
    }


    public void Gameover(){


            if(Player1Score > Player2Score){
        
               PlayerWonText.text = "Player 1 WON!";
               playerWonPoints.text = "Points:"+ Player1Score;
        
            }
            if(Player1Score < Player2Score){
        
               PlayerWonText.text = "Player 2 WON!";
        
               playerWonPoints.text = "Points:"+ Player2Score;
            }

           if(Player1Score == Player2Score){
        
               PlayerWonText.text = "NobodyWon Try again!";
        
               playerWonPoints.text = "Points:"+ Player2Score;
            }


            GameOver =true;
            GameOverCanvas.SetActive(true);
            Time.timeScale = 0;   
    }

    public void AddUpdateAndaddScoreToPlayer1(){

        Player1Score += 1;

        Player1ScoreText.text = Player1Score.ToString();


    }
    public void AddUpdateAndaddScoreToPlayer2(){

        Player2Score +=1;

        Player2ScoreText.text = Player2Score.ToString();
        
    }
    
}
