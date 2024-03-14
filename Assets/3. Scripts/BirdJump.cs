using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb; // rigidbody �ּҰ�

    public float jumpPower; // ������

    void Start() // ������ ���������� ����
    {
        rb = GetComponent<Rigidbody2D>(); // rb�� rigidbody2D ������Ʈ�� ������
    }

    void Update() // �� �����Ӹ��� ����
    {
        if (Input.GetMouseButtonDown(0)) // ���� ���콺 ��Ŭ���� �ߴٸ�?
        {
            rb.velocity = Vector2.up * jumpPower;
            // rb�� velocity�� �������� �������� �ش�
        }
    }
}

    