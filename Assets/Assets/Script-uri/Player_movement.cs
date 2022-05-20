using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    [SerializeField] private float moveForce;
    [SerializeField] private float jumpForce;
    

    private float movementX;
    private float movementY;
    [SerializeField]
    private Rigidbody2D mybody;
    
    [SerializeField]
    private Animator anim;
    
    [SerializeField]
    private SpriteRenderer sr;

    private bool m_FacingRight = true;
    private string WALK_ANIMATION = "Walk";
    private string FLY_ANIMATION = "fly";

    bool isJumping = true;

    private void Awake()
    {
        
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
        jumpForce = 1f;
    }

    // Update is called once per frame
    
    void Update()
    {
         Playermovement();
         AnimatePlayer();
         

         //PlayerJump();
    }

    void FixedUpdate()
    {
        
        PlayerJump();
    }

    void PlayerJump()
    {
            if(!isJumping && movementY>0.1f)
                mybody.AddForce(new Vector2(0f, jumpForce),ForceMode2D.Impulse);
    }
    void Playermovement()
    {
        
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(movementX, 0, 0)*Time.deltaTime*moveForce;
        if (movementX > 0 && !m_FacingRight)
        {
            //firepoint.transform.Rotate(0f, 180f, 0);
            Flip();
        }
        //transform.localScale = new Vector3(0.5f, 0.5f, 1);
        else if (movementX < 0 && m_FacingRight)
        {

            Flip();
        }
        //transform.localScale = new Vector3(-0.5f, 0.5f, 1);
        //Debug.Log(movementX);
    }
    void AnimatePlayer()
    {
        if (movementX ==1)
            anim.SetBool(WALK_ANIMATION, true);
        else if (movementX ==-1)
            anim.SetBool(WALK_ANIMATION, true);
        else if (movementX == 0)
            anim.SetBool(WALK_ANIMATION, false);

        if(movementY>0.1f)
            anim.SetBool(FLY_ANIMATION, true);
        else
            anim.SetBool(FLY_ANIMATION, false);
    }
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Teren")
            isJumping = false;
    }

    private void Flip()
    {
        // Switch the way the player is labelled as facing.
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0f, 180f, 0f);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Teren")
        {
            isJumping = true;
        }
    }
}
