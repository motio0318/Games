using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PHP : MonoBehaviour
{

    public static int P_Hp = 3;
    public int P_HP_herasu = 1;

   public GameObject obj1;
   public GameObject obj2;
   public GameObject obj3;



    void Awake()
    {

        PlayerPrefs.GetInt("P_Hp", 0);
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
        if (changeScene.cnt2 == true)
        {

            P_Hp -= P_HP_herasu;
            Debug.Log(P_Hp);


            if (P_Hp == 2)
            {
                PlayerPrefs.SetInt("P_Hp", P_Hp);
                this.obj1.SetActive(false);


            }

            if (P_Hp == 1)
            {

                //HP�R�����炷

                changeScene.cnt2 = false;
                this.obj2.SetActive(false);


            }
            else if (P_Hp == 0)
            {
                changeScene.cnt2 = false;
                this.obj3.SetActive(false);


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
