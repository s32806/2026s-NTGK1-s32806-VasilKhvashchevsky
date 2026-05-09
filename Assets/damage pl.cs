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
    }
}