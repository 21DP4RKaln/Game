using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 moveVector;
    private float speed = 5.0f;
    private float VerticalVelocity = 0.0f;
    private float gravity = 12.0f;
    public int score = 0;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        moveVector = Vector3.zero;
        if (controller.isGrounded)
        {
            VerticalVelocity = -0.5f;
        }
        else
        {
            VerticalVelocity -= gravity * Time.deltaTime;
        }

        moveVector.x = Input.GetAxis("Horizontal") * speed;

        moveVector.y = VerticalVelocity;

        moveVector.z = speed;
        controller.Move(moveVector * Time.deltaTime);
    }
    public void SetSpeed(float modifier)
    {
        speed = 5.0f + modifier;
    }
    public void AddScore(int value)
    {
        score += value;
        UnityEngine.Debug.Log("Score: " + score); // Можно добавить вывод текущего количества очков в консоль или интерфейс игры
    }

}
