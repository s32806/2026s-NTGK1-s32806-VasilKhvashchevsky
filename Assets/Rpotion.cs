using UnityEngine;

public class RedPotion : MonoBehaviour, IPickable
{
    [SerializeField] private int healthValue = 10;

    public void PickUp()
    {
        GameManager.Instance.Heal(healthValue);
        Destroy(gameObject);
    }
}