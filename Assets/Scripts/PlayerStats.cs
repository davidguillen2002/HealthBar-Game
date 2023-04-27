using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    static float Health;
    static float MaxHealth = 100;

    public Slider HealthBar;

    private void Start()
    {
        HealthBar.minValue = 0;
        HealthBar.maxValue = MaxHealth;
        Health = MaxHealth;

    }

    private void Update()
    {
        HealthBar.value = Health;
        Damage();

    if (Health <= 0)
        {
            Debug.Log("Has muerto");
            Time.timeScale = 0; // detiene el tiempo para detener el juego
        }
    }

    void Damage()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Health -= 10;
        }
    }
    
}
