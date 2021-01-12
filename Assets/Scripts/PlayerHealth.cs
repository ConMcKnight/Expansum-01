using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 10000;
    public int currentHealth;
    public int health;
    public int oxygenLoss = 1;
    public HealthBar healthBar; 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
       currentHealth -= oxygenLoss;
        
    }

   
}
