using UnityEngine;

public class GreenPotion : MonoBehaviour, IPickable
{
    [SerializeField] private int healthValue = 10;

    public void PickUp()
    {
        GameManager.Instance.Heal(-healthValue);
        Destroy(gameObject);
    }
}