using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class HealthBarController : MonoBehaviour
{
    private Slider slider;
    public Player player;
    private float currentHealth = 100;
    public static event Action isDead;

    private void Awake()
    {
        slider = GetComponent<Slider>();
        slider.minValue = 0;
        slider.maxValue = 100;
        slider.value = 100;
    }

    private void OnEnable()
    {
        Player.collidedWithEnemy += TakeDamage;
        Player.consumedHeal += Heal;
    }

    private void OnDisable()
    {
        Player.collidedWithEnemy -= TakeDamage;
        Player.consumedHeal -= Heal;
    }

    public void TakeDamage()
    {
        currentHealth -= 20;
        currentHealth = Mathf.Clamp(currentHealth, slider.minValue, slider.maxValue);
        slider.value = currentHealth;
        if (currentHealth == 0)
            SceneManager.LoadScene("GameOver");
    }

    public void Heal()
    {
        currentHealth += 20;
        currentHealth = Mathf.Clamp(currentHealth, slider.minValue, slider.maxValue);
        slider.value = currentHealth;
    }
}
