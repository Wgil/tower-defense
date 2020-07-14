using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float startSpeed = 10f;
    [HideInInspector]
    public float speed;

    public float startHealth = 100;
    private float health;

    public int money = 50;

    public GameObject deathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;

    private bool isDead = false;

    private void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        healthBar.fillAmount = health / startHealth;

        Debug.Log("Amount " + amount +  "HEALTH " + health);
        if (health <= 0 && !isDead)
        {
            Die();
        }
    }

    public void Slow(float percentage)
    {
        speed = startSpeed * (1 - percentage);
    }

    void Die()
    {
        isDead = true;

        PlayerStats.Money += money;

        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5);

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);

    }

}
