using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class NextButton : PHP
{
    [SerializeField, Header("���艹")]
    private GameObject submitSE;

    public static bool cnt = false;

    public int Q_count = 0;

    private void Awake()
    {
        //����ڂ��擾����
        Q_count = PlayerPrefs.GetInt("count", 0);
    }

    public void OnClick()
    {
        Instantiate(submitSE);



        if (PHP.P_Hp == 2)
        {
            changeScene.cnt2 = false;
            this.obj1.SetActive(false);


        }

        if (PHP.P_Hp == 1)
        {

            //HP�R�����炷

            changeScene.cnt2 = false;
            this.obj1.SetActive(false);
            this.obj2.SetActive(false);


        }
        Invoke("SceneChange", 0.5f);
        ////3��ڂȂ�^�C�g����(��)
        //if (Q_count == 3)
        //{
        //    TitleSceneChange();
        //}
        //else
        //{
        //    Invoke("SceneChange", 0.5f);
        //}

    }

    public void TitleSceneChange()
    {
        SceneManager.LoadScene("Title");
    }

    public void SceneChange()
    {

        cnt = true;
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage1");
    }

}


