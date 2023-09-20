using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody rb;
    Vector3 dir = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Ű �Է°� �̵����� ���
    void Update()
    {
        InputAndDir();
    }

    // ���� �������� �������� �̵� ����
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + dir * speed * Time.deltaTime);
    }

    // Ű �Է°� �׿� ���� �̵������� ����ϴ� �Լ�
    void InputAndDir()
    {
        dir.x = Input.GetAxis("Horizontal");   // x�� ���� Ű �Է�
        dir.z = Input.GetAxis("Vertical");     // z�� ���� Ű �Է�
        if (dir != Vector3.zero)   // Ű�Է��� �����ϴ� ���
        {
            transform.forward = dir;	// Ű �Է� ��, �Էµ� �������� ĳ������ ������ �ٲ�
        }
    }
}