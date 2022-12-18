using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;

    void Start()
    {
        print("Hello, World!");
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("здровье играка: " + health);
    }
}
     
