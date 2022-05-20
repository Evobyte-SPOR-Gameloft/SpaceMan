using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    public float speed;
    private Transform player;
    public float lineofSight;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform ;    

    }

    // Update is called once per frame
    void Update()
    {
        
        float distancefromplayer = Vector2.Distance(player.position, transform.position);
        if(distancefromplayer<lineofSight)
        { 
            transform.position = Vector2.MoveTowards(this.transform.position,player.position, speed*Time.deltaTime);
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineofSight);
    }
}
