using UnityEngine;

public class ArrowTrap : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform firePoint;

    public float shootInterval = 2f;
    public float arrowSpeed = 10f;

    void Start()
    {
        InvokeRepeating("Shoot", 0f, shootInterval);
    }

    void Shoot()
    {
        GameObject arrow = Instantiate(
            arrowPrefab,
            firePoint.position,
            firePoint.rotation
        );

        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

        rb.velocity = firePoint.right * arrowSpeed;
    }
}