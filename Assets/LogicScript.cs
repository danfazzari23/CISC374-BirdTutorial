using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int playerScore;
    public Text scoreText;

    public Text highScoreText;
    public GameObject gameOverScreen;
    public bool isGameOver = false;

    public AudioSource scoreSound;
    public AudioSource backgroundMusic;

    public string highScoreKey = "HighScore";

    void Start(){
        if(backgroundMusic != null){
            backgroundMusic.loop = true;
            backgroundMusic.Play();
        }
        int savedHighScore = PlayerPrefs.GetInt(highScoreKey, 0);
        if(highScoreText != null){
            highScoreText.text = "High Score: " + savedHighScore.ToString();
        }
    }

    public void addScore(int scoreToAdd){

        if (isGameOver == true){
            return;
        }
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();

        if(scoreSound != null){
            scoreSound.Play();
        }
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        isGameOver = true;
        gameOverScreen.SetActive(true);

        int currentHighScore = PlayerPrefs.GetInt(highScoreKey, 0);
        if(playerScore > currentHighScore){
            PlayerPrefs.SetInt(highScoreKey, playerScore);
        }
        PlayerPrefs.Save();

        if(highScoreText != null){
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt(highScoreKey, 0).ToString();
        }

    }
}
