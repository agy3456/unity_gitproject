using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab; // �Ѿ� Prefab
    public Transform firePoint; // �Ѿ� �߻� ��ġ

    void Update()
    {
        // ���콺 Ŭ������ �Ѿ� �߻�
        if (Input.GetButtonDown("Fire1")) // Fire1�� �⺻������ ���콺 ���� ��ư�� ��Ÿ���ϴ�.
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // �Ѿ��� �߻� ��ġ���� ����
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // �Ѿ��� �����̰� �ϰų� �߰����� ������ ���⿡ �߰��� �� �ֽ��ϴ�.
    }
}
