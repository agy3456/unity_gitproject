using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 10�� �ڿ� �ڵ����� �����ϵ��� �Լ��� ȣ���մϴ�.
        Invoke("DestroyGameObject", 10f);
    }

    // �Լ��� ȣ���Ͽ� GameObject�� �����մϴ�.
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
