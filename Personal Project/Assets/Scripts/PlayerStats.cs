using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float totalHealth;
    public float currentHealth;
    public float speed;
    public float jumpHeight;
    public float sprintSpeed;
    public float primaryAttackDamage;
    public float specialAttackDamage;
    public int playerLevel;    

    // Start is called before the first frame update
    void Start()
    {
        totalHealth = 100.0f;
        currentHealth = 100.0f;
        speed = 12.0f;
        jumpHeight = 500.0f;
        sprintSpeed = speed * 1.5f;
        primaryAttackDamage = 10.0f;
        specialAttackDamage = 20.0f;
        playerLevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
