using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1; // Количество очков, которое приносит предмет

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            if (player != null)
            {
                player.AddScore(scoreValue); // Вызываем метод AddScore() у скрипта персонажа
                Destroy(gameObject); // Уничтожаем предмет после подбора
            }
        }
    }
}