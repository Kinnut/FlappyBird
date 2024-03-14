using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; // rigidbody 주소값

    public GameObject ending;

    public float jumpPower; // 점프값

    void Start() // 게임을 시작햇을때 실행
    {
        rb = GetComponent<Rigidbody2D>(); // rb에 rigidbody2D 컴포넌트를 가져옴
    }

    void Update() // 매 프레임마다 실행
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) // 만약 마우스 좌클릭을 했다면?
        {
            rb.velocity = Vector2.up * jumpPower;
            // rb의 velocity에 위쪽으로 점프값을 준다
        }

        if (transform.position.x <= -4.1f)
        {
            ending.SetActive(true);
        }
    }
}

    