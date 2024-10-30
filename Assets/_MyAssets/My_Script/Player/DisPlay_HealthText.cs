using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisPlay_HealthText : MonoBehaviour
{
    [SerializeField] private Text textHealth;
    [SerializeField] private Health health;
    [SerializeField] private Image healthBar;
    private void Start()
    {
        health.onChangedHealth.AddListener(UpdateHealth);
    }
    public void UpdateHealth(float health, float maxHealth)
    {
        textHealth.text = health.ToString();
        healthBar.fillAmount = health / maxHealth;
    }
}
