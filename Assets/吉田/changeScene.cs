using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public int Q_count = 0;
    //public static int
    private void Awake()
    {
        //����ڂ��擾����
        Q_count = PlayerPrefs.GetInt("count", 0);
    }

    public void change_button()
    {
        if (Q_count == 3)
        {
            TitleSceneChange();
        }
        else
        {
            Invoke("SceneChange", 0.5f);
        }
    }

    public void TitleSceneChange()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Title");
    }
    public void SceneChange()
    {
        //�V�[�����������ɓ���
        SceneManager.LoadScene("Stage3 interval");
    }
}
