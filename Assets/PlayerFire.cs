using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory; // �Ѿ� ������
    public Transform firePosition; // �߻� ��ġ

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0�� ���콺 ���� ��ư�� ��Ÿ���ϴ�.
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.position; // �߻� ��ġ�� �̵�
        }
    }
}

