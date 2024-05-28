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