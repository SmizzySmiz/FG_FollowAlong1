using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivePlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private Image healthBar;

    private float currentHealth;

   // private Vector3 initialPosition;
   // private Vector3 initialRotation;

    void Start() // Set health
    {
        currentHealth = maxHealth;
        //initialPosition = transform.position;
        //initialRotation = transform.eulerAngles;
        healthBar.fillAmount = 1f;
    }

    public void TakeDamage(float damage) // Take damage & interact with health bar
    {
        currentHealth -= damage;
        healthBar.fillAmount = currentHealth / maxHealth;

        if (currentHealth <= 0) // Death on 0 health
        {
            // Set back to initial position
            //transform.position = initialPosition;
            //transform.eulerAngles = initialRotation;

            Destroy(gameObject);
            FindObjectOfType<GamePersistance>().EndGame();            
        }
    }
   
}