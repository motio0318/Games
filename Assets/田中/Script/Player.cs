using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHP = 10;
    int HP;
    //Slider
    public Slider slider;

     void Start()
    {
        //Slider���ő�ɂ���
        slider.value = 10;
        //HP���ő�HP�Ɠ����l�ɁB
        HP = maxHP;
    }



    public void TakeDamage()
    {
        //HP����P����
        HP -= 1;
        //HP��Slider�ɔ��f�B
        slider.value = HP;

    }
}
