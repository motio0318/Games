using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I

public class NextButton : MonoBehaviour
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

        Invoke("SceneChange", 0.5f);

    }

    //public void TitleSceneChange()
    //{
    //    SceneManager.LoadScene("Title");
    //}

    public void SceneChange()
    {
        cnt = true;
        //�G�V�[����
        SceneManager.LoadScene("Stage1");
    }

}


