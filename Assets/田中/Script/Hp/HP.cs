using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class HP: MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 10;
    int currentHp;
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

        currentHp = PlayerPrefs.GetInt("currentHp",0);
        slider.value = currentHp / (float)maxHp;

        HP_herasu();
    }

    void HP_herasu()
    {
        NextButton nextButton = GetComponent<NextButton>();
           

        // NextButtton�������ꂽ���ǂ��������o
        if (NextButton.cnt == true)
        {

            currentHp = currentHp - damage;
            //���݂�HP����_���[�W������
            slider.value = currentHp / (float)maxHp;
            NextButton.cnt = false;

            PlayerPrefs.SetInt("currentHp",currentHp);

        }

        if(currentHp <= 0)
        {
            Destroy(gameObject);

            //�V�[�����������ɓ���
            SceneManager.LoadScene("clear");

            Debug.Log(currentHp);
        }

        Invoke("ChangeScene_Interval", 5);


    }
    void ChangeScene_Interval()
    {

        SceneManager.LoadScene("Stage3 interval");
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