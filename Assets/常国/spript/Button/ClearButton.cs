using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class ClearButton : MonoBehaviour
{
    [SerializeField, Header("���艹")]
    private GameObject submitSE;

    public int Count = 0;

    void Start()
    {

        OnClick();
    }
    public void OnClick()
    {
        Instantiate(submitSE);

        Invoke("SceneChange", 0.5f);
    }

    public void SceneChange()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Title");
    }

}

