using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PHP : MonoBehaviour
{

    public static int P_Hp = 3;
    public int P_HP_herasu = 1;

    void Awake()
    {
        PlayerPrefs.GetInt("P_Hp",0);
    }

    // Start is called before the first frame update
    void Start()
    {
        PHP_herasu();
    }

    void PHP_herasu()
    {
        changeScene ChangeScene = GetComponent<changeScene>();


        // NextButttonが押されたかどうかを検出
        if (changescene.cnt2 == true)
        {
            P_Hp -= P_HP_herasu;
            PlayerPrefs.SetInt("P_Hp", P_Hp);

            if(P_Hp == 2)
            {
                //HP３を減らす

                cnt2 = false;
            }
            else if(P_Hp == 1)
            {
                //HP２を減らす

                cnt2 = false;
            }
            else if(P_Hp == 0)
            {
                cnt2 = false;
                //ゲームオーバー画面へ移行
                GameOverChange();
            }
        }
    }

    void GameOverChange()
    {
        //ゲームオーバー画面へ
        SceneManager.LoadScene("Select");
    }
}
