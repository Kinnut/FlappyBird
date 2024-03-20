using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; // rigidbody �ּҰ�
    AudioSource audioSource;

    public float jumpPower; // ������

    void Start() // ������ ���������� ����
    {
        rb = GetComponent<Rigidbody2D>(); // rb�� rigidbody2D ������Ʈ�� ������
        audioSource = GetComponent<AudioSource>();
    }

    void Update() // �� �����Ӹ��� ����
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) // ���� ���콺 ��Ŭ���� �ߴٸ�?
        {
            rb.velocity = Vector2.up * jumpPower; // rb�� velocity�� �������� �������� �ش�
            audioSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Score.score > Score.bestScore)
            Score.bestScore = Score.score;

        SceneManager.LoadScene("2. GameOverScene");
    }
}

    