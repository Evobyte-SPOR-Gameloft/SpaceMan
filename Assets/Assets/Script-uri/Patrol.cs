using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject enemy;
    public float speed;
    [SerializeField]
    public Transform movespot;

    
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Player");    
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.MoveTowards(transform.position, movespot.position, speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision1)
    {
        if(collision1.gameObject.name=="Inamic")
        {

            Destroy(enemy) ;
            Debug.Log("Alo");

        }
    }

}
