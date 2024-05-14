using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[3];
    private int lifePoint = 3;

    public void OnClick()
    {
        lifeArray[lifePoint - 1].SetActive(false);
        lifePoint--;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && lifePoint > 0)
        {
            //lifeArray[lifePoint - 1].SetActive(false);
            //lifePoint--;
        }


        else
        {
            // 敵のHPが０になったら敵オブジェクトを破壊する。
            if (enemyHeart == 0)
            {

                // オブジェクトを破壊する
                Destroy(transform.root.gameObject);


            }

        }



        Debug.Log(states.Heart);
    }
}