using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class TitleStartButton : MonoBehaviour
{
    [SerializeField, Header("���艹")]
    private GameObject submitSE;

    private void Awake()
    {
        PlayerPrefs.SetInt("count", 0);//�ۑ�
        PlayerPrefs.SetInt("currentHp", 10);//�ۑ�
        PlayerPrefs.SetInt("P_Hp", 3);//�ۑ�
    }

    public void OnClick()
    {
        Instantiate(submitSE);

       Invoke("SceneChange", 0.5f);
    }

    public void SceneChange()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Select");
    }

}