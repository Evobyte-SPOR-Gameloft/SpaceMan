using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DMGbar : MonoBehaviour
{
    public Slider slider;
    
    public void MaxHealth(int dmg)
    {
        slider.maxValue = dmg;
        slider.value = dmg;

    }

    // Start is called before the first frame update
    public void SetDMG(int dmg)
    {
        slider.value = dmg;
    }
}
