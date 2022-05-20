using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    [SerializeField]
    private float followSpeed=2f;
    [SerializeField]
    private float yOffset = 1f;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 newpos = new Vector3(target.position.x, target.position.y+yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newpos, followSpeed*Time.deltaTime);

    }
}
