using UnityEngine;

public class BulletName : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        // ���� �浹�� ������Ʈ�� �±װ� "Ground"�̸� �Ѿ� ����
        if (other.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
