using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager : MonoBehaviour
{

    public int maxHP = 10;
    public int currentHP;
    public Image hpBar;//HPバーのImageコンポーネント


    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        UpdateHPBar();


    }

    public void DecreaseHp(int amount)
    {
        currentHP -= amount;
        if (currentHP < 0)
        {
            currentHP = 0;
        }
        UpdateHPBar();
    }

    void UpdateHPBar()
    {
        float fillamount = (float)currentHP / maxHP;
        hpBar.fillAmount = fillamount;

    }


}
