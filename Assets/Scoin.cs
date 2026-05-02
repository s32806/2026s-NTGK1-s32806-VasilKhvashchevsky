using UnityEngine;

public class SilverCoin : MonoBehaviour, IPickable
{
    [SerializeField] private int value = 1;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.Instance;
    }

    public void PickUp()
    {
        gameManager.AddCoins(-value);
        Destroy(gameObject);
    }
}