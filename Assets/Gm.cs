using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Player Stats")]
    public int maxHealth = 100;
    public int currentHealth;

    public int coins = 0;

    private UIManager uiManager;

    public Animator an;

    public GameObject deathScreen;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        currentHealth = maxHealth;

        uiManager = FindObjectOfType<UIManager>();

        an = GetComponent<Animator>();

        deathScreen.SetActive(false);

        UpdateUI();
    }

    private void Update()
    {
        //test

        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            Heal(10);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            AddCoins(1);
        }
    }
    

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateUI();
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        an.SetTrigger("die");
        StartCoroutine(ShowDeathScreen());
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateUI();
    }
    IEnumerator ShowDeathScreen()
    {
    yield return new WaitForSeconds(1f);
    deathScreen.SetActive(true);
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (uiManager != null)
        {
            uiManager.UpdateHealth(currentHealth, maxHealth);
            uiManager.UpdateCoins(coins);
        }
    }
}