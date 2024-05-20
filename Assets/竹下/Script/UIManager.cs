using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //2��Panel���i�[����ϐ�
    //�C���X�y�N�^�[�E�B���h�E����Q�[���I�u�W�F�N�g��ݒ肷��
    [SerializeField] GameObject Panel1;
    [SerializeField] GameObject Panel2;

    // Start is called before the first frame update
    void Start()
    {
        //BackToMenu���\�b�h���Ăяo��
        BackToMenu();
    }

    public void SelectXrHubDescription()
    {
        Panel1.SetActive(true);
    }

    public void SelectUnityDescriptio()
    {
        Panel2.SetActive(true);
    }

    public void BackToMenu()
    {
        Panel1.SetActive(false);
        Panel2.SetActive(false);
    }
}
