using UnityEngine;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public TMP_Text healthText;

    [SerializeField]
    private int currentHealth = 50;

    private int maxHealth = 50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateHealth(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateHealth(int value)
    {
        currentHealth += value;
        Mathf.Clamp(currentHealth, 0, maxHealth);

        if (healthText)
        {
            healthText.text = "HP: " + currentHealth + " / " + maxHealth;
        }
    }
}
