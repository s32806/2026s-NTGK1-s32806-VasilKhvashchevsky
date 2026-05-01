using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private TMP_Text healthText;
    [SerializeField] private TMP_Text coinsText;

    public void UpdateHealth(int current, int max)
    {
        healthText.text = current + "/" + max;
    }

    public void UpdateCoins(int coins)
    {
        coinsText.text = "Coins: " + coins;
    }
}