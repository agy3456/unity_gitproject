using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f; // �Ѿ� �ӵ�

    void Update()
    {
        // �Ѿ��� ������ �̵�
        transform.Translate(Vector2.up * speed * Time.deltaTime);

        // �Ѿ��� ȭ�� ������ ������ ����
        if (GetComponent<Renderer>() != null && !GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
    }
}
