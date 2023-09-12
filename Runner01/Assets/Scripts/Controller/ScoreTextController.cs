using UnityEngine;
using UnityEngine.UI;

public class ScoreTextController : MonoBehaviour
{
    public int score = 0;
    public Text scoreText; // Ссылка на текстовый элемент

    // Вызывается при подборе предмета, чтобы добавить очки
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // Обновляет текстовый элемент с текущим количеством очков
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}