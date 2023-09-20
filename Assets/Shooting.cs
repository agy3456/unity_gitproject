using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab; // �Ѿ� ������
    public Transform firePoint; // �Ѿ� �߻� ��ġ

    public float bulletSpeed = 10f; // �Ѿ� �ӵ�

    void Update()
    {
        // ���콺 ���� ��ư�� Ŭ���ϸ� �Ѿ� �߻�
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // �Ѿ��� �ѱ� ��ġ���� ����
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // �Ѿ˿� �ӵ��� �����Ͽ� �߻�
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * bulletSpeed;
        }
    }
}
