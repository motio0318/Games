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


        // NextButtton�������ꂽ���ǂ��������o
        if (changescene.cnt2 == true)
        {
            P_Hp -= P_HP_herasu;
            PlayerPrefs.SetInt("P_Hp", P_Hp);

            if(P_Hp == 2)
            {
                //HP�R�����炷

                cnt2 = false;
            }
            else if(P_Hp == 1)
            {
                //HP�Q�����炷

                cnt2 = false;
            }
            else if(P_Hp == 0)
            {
                cnt2 = false;
                //�Q�[���I�[�o�[��ʂֈڍs
                GameOverChange();
            }
        }
    }

    void GameOverChange()
    {
        //�Q�[���I�[�o�[��ʂ�
        SceneManager.LoadScene("Select");
    }
}
