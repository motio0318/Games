using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundScript : MonoBehaviour
{
    private static SoundScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            // ���̃I�u�W�F�N�g���V���O���g���̃C���X�^���X�Ƃ��Đݒ肳���
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // ���ɃC���X�^���X�����݂���ꍇ�A���̃I�u�W�F�N�g��j��
            Destroy(gameObject);
        }
        
    }

    public AudioSource A_BGM;//AudioSource�^�̕ϐ�A_BGM��錾�@�Ή�����AudioSource�R���|�[�l���g���A�^�b�`
    private string beforeScene;//string�^�̕ϐ�beforeScene��錾 

    public void Start()
    {
        beforeScene = "Title";
        A_BGM.Play();//A_BGM��AudioSource�R���|�[�l���g�Ɋ��蓖�Ă�AudioClip���Đ�
        //�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
        SceneManager.activeSceneChanged += OnActiveSceneChanged;

    }
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {
        if (beforeScene == "Title" && nextScene.name == "Stage")
            A_BGM.Stop();
    }
}
