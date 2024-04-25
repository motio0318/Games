using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHP = 10;
    int HP;
    //Slider
    public Slider slider;

     void Start()
    {
        //Sliderを最大にする
        slider.value = 10;
        //HPを最大HPと同じ値に。
        HP = maxHP;
    }



    public void TakeDamage()
    {
        //HPから１引く
        HP -= 1;
        //HPをSliderに反映。
        slider.value = HP;

    }
}
