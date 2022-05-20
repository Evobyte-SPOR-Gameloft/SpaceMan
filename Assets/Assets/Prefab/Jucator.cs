using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jucator : MonoBehaviour
{
    public int currentdmg = 0;
    public int dmgtaken;
    public DMGbar dmgbar;

    // Start is called before the first frame update
    void Start()
    {
        currentdmg = dmgtaken;
        dmgbar.SetDMG(currentdmg);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage(10);

        }
    }
    void takeDamage(int damage)
    {
        currentdmg+=damage;
        dmgbar.SetDMG(currentdmg);
    }
}
