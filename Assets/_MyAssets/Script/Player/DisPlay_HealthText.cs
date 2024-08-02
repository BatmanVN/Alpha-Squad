using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisPlay_HealthText : MonoBehaviour
{
    [SerializeField] private Text textHealth;
    [SerializeField] private HealthComponent health;
    [SerializeField] private Image healthBar;
    private void Start()
    {
        health.onAttack.AddListener(UpdateHealth);
    }
    public void UpdateHealth(float Health)
    {
        textHealth.text = Health.ToString();
        healthBar.fillAmount = health.Health / health.MaxHealth;
    }
}
