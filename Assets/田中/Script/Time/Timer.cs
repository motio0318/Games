using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // 忘れない！！


public class Timer : MonoBehaviour
{
    public float Rimmit = 15;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //制限時間
        Rimmit -= Time.deltaTime;

        //少数2桁にして表示
        GetComponent<Text>().text = Rimmit.ToString("F0") + "秒";

        //Rimmitが0以下になった時
        if(Rimmit <= 0)
        {

            //シーン名をここに入力
            SceneManager.LoadScene("Stage3misstake");


        }

    }
}
