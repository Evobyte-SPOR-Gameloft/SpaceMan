using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health = 100;
    public DMGbar dmgStatus;
    int currentdamage = 0;
    int dmgTook;

    public void TakeDamage(int damage)
    {
        health -= damage;
        currentdamage += damage;
        dmgStatus.SetDMG(currentdamage);
        if (health <= 0)
        {
            Die();
        }    

    }

    void Die()
    {
        
        Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        currentdamage = dmgTook;
        dmgStatus.SetDMG(currentdamage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
