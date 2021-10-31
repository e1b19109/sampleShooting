using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{

    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;

    public void GameOver()
    {
       // this.gameOverText.GetComponent<Text>();
        gameOverText.SetActive(true);
    }

    public void AddScore()
    {
        this.score += 10;
    }

    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("Panel");
        gameOverText.SetActive(false);
    }

    void Update()
    {
        if (gameOverText.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
