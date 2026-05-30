using UnityEngine;

public class SpikeDetector : MonoBehaviour
{
    [SerializeField] string dangerTag = "danger";
    [SerializeField] private int dangerDamage = 10;

    private Animator an;

    private void Start()
    {
        an = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(dangerTag))
        {
            GameManager.Instance.TakeDamage(dangerDamage);
            an.SetTrigger("hit");
        }

        if (other.CompareTag("DeathZone"))
        {
            Die();
        }
        if (other.CompareTag("DeathZone"))
{
    GameManager.Instance.currentHealth = 0;
    GameManager.Instance.TakeDamage(0);
}
    }

    void Die()
    {
        an.SetTrigger("die");
    }
}