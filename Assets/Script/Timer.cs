using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Rimmit = 60; 


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

        //Rimmit��0�ȉ��ɂȂ����Ƃ�
        if(Rimmit <= 0)
        {
            GetComponent<Text>().text ="���ԂɂȂ�܂����B";
        }


    }
}
