using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour
{

    int score = 0;
    int bullet = 10;
    GameObject scoreText;
    GameObject gameOverText;
    GameObject bulletText;

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
    }

    public void AddScore()
    {
        this.score += 10;
    }

    public void GemAddScore()
    {
	this.score += 50;
    }

    public void ReduceBullet()
    {
        if (bullet > 0)
        {
            this.bullet--;
        }
        else
        {
            this.bullet = 0;
        }
    }

    public void AddBullet()
    {
        this.bullet += 5;
    }

    // Use this for initialization
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
        this.bulletText = GameObject.Find("Bullet");
    }

    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
        bulletText.GetComponent<Text>().text = "écíeêîÅ®" + bullet.ToString("D3");
    }
}