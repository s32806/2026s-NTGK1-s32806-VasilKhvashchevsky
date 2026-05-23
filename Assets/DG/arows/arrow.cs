using UnityEngine;

public class ArrowDestroy : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 8f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
    }
}