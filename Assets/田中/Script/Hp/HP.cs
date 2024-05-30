using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class HP: MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 10;
    public int currentHp;
    int damage = 1;

    //Slider������
    public Slider slider;

    public static HP i_HP;

    public void Awake()
    {
        if (i_HP == null)
        {
            i_HP = this;
        }
    }

    void Start()
    {
        //Slider�𖞃^���ɂ���B
        slider.value = 1;


        //���݂�HP���ő�HP�Ɠ����ɁB
        currentHp = maxHp;

        //�ۑ�����Ă���G��HP���擾
        currentHp = PlayerPrefs.GetInt("currentHp",0);

        HP_herasu();
    }

    void HP_herasu()
    {
        //NextButton���擾
        NextButton nextButton = GetComponent<NextButton>();
           

        // NextButtton�������ꂽ���ǂ��������o
        if (NextButton.cnt == true)
        {
            //���݂�HP����_���[�W������
            currentHp = currentHp - damage;
            slider.value = currentHp / (float)maxHp;
            NextButton.cnt = false;

            //�G��HP��ۑ�
            PlayerPrefs.SetInt("currentHp",currentHp);

        }

        //�����G��HP��0�ɂȂ�����
        if(currentHp <= 0)
        {
            //�G��HP������
            Destroy(gameObject);

            //7�b��ɌĂяo��
            Invoke("ChangeScene_clear", 7);
            Debug.Log(currentHp);
        }
        //5�b��ɌĂяo��
        Invoke("ChangeScene_Interval", 5);


    }
    void ChangeScene_Interval()
    {
        //�扽��V�[����
        SceneManager.LoadScene("Stage3 interval");
    }

    void ChangeScene_clear()
    {
        //�N���A�V�[����
        SceneManager.LoadScene("clear");
    }
}