using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // �Y��Ȃ��I�I


public class Timer : MonoBehaviour
{
    public float Rimmit = 15;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //��������
        Rimmit -= Time.deltaTime;

        //����2���ɂ��ĕ\��
        GetComponent<Text>().text = Rimmit.ToString("F0") + "�b";

        //Rimmit��0�ȉ��ɂȂ�����
        if(Rimmit <= 0)
        {

            //�V�[�����������ɓ���
            SceneManager.LoadScene("Stage3misstake");


        }

    }
}
