using UnityEngine;
using TMPro; // Add this line

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}