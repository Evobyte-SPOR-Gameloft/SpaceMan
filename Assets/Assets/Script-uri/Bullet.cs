using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float speed=20f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject gameObject;
    public int damage = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = rb.transform.right * speed;
        gameObject = GameObject.FindGameObjectWithTag("Glont");
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        Enemy enemy = collider.GetComponent<Enemy>();

        if(enemy!=null)
        {
            enemy.TakeDamage(damage);
            
        }
        Destroy(gameObject);
    }
   
    // Update is called once per frame
    void Update()
    {
         
    }
}
