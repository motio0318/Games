using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class HP: MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 20;
    int currentHp;
    int damage = 1;

    //Slider������
    public Slider slider;

    void Start()
    {
        //Slider�𖞃^���ɂ���B
        slider.value = 1;


        //���݂�HP���ő�HP�Ɠ����ɁB
        currentHp = maxHp;


        //Debug.Log("Start currentHp : " + currentHp);
    }

    void Update()
    {

           

        // �X�y�[�X�L�[�������ꂽ���ǂ��������o
        if (Input.GetKeyDown(KeyCode.Space))
        {

            currentHp = currentHp - damage;
            //���݂�HP����_���[�W������
            slider.value = currentHp / (float)maxHp;


            // currentHp�̕ۑ�
            PlayerPrefs.SetInt("currentHp", currentHp);



            // currentHp�̓ǂݍ��݂��鎞�ɂ��̃R�[�h��`��
            //int currentHp = PlayerPrefs.GetInt("currentHp", 0);

        }

        if(currentHp <= 0)
        {
            Destroy(gameObject);

            //�V�[�����������ɓ���
            SceneManager.LoadScene("clear");

        }


    }


}







//public class HP : MonoBehaviour
//{
//    public Slider hpGauge;   //�c��HP�Q�[�W
//    public TextMeshProUGUI hpText;  //�c��HP��\������e�L�X�g
//    float hpEnemy; // �GHP

//    void Start()
//    {
//        hpGauge.value = 1f; // HP�Q�[�W�̏����l��ݒ�
//        hpEnemy = 30f; // �����̓GHP��ݒ�
//        enemyPoint(); // HP�e�L�X�g���X�V
//    }

//    void Update()
//    {
//        // �X�y�[�X�L�[�������ꂽ���ǂ��������o
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            float attack = Random.Range(0f, 10f); // 0����10�܂ł̍U��
//            hpEnemy -= attack;      // �G��HP�������_���Ō���������
//            Debug.Log("�U����:" + attack);
//            Debug.Log("�GHP" + hpEnemy);
//            hpGauge.value = hpEnemy / 30f;  // �Q�[�W�̒l���X�V
//            hpEnemy = Mathf.Max(hpEnemy, 0f); // HP��0�����ɂȂ�Ȃ��悤�ɒ���
//            enemyPoint();   // HP�e�L�X�g���X�V
//        }
//    }
//    void enemyPoint()
//    {
//        hpText.text = hpEnemy.ToString("F1");   // �GHP���e�L�X�g�Ƃ��ĕ\��
//    }

//}