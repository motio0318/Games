//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class EF : MonoBehaviour
//{
//    private NightStutes states;
//    private PlayerStates playerstates;

//    public GameObject effectPrefab;
//    public AudioClip destroySound;
//    public int enemyHP;

//    public void OnClick()

//    void OnTriggerEnter(Collider other)
//    {

//    }



//        states = GameObject.Find("�X�P���g��").GetComponent<NightStutes>();
//        playerstates = GameObject.Find("��l��").GetComponent<PlayerStates>();

//        enemyHP = states.HP;


//        // �Ԃ���������ɁuAttack�v�Ƃ����^�O�iTag�j�����Ă�����A
//        if (other.gameObject.CompareTag("Attack"))
//        {

//            // �G��HP���v���C���[��atk���A����������
//            states.Heart -= playerstates.atk;



//            // �G��HP���O�ɂȂ�����G�I�u�W�F�N�g��j�󂷂�B
//            if (enemyHeart == 0)
//            {

//                // �I�u�W�F�N�g��j�󂷂�
//                Destroy(transform.root.gameObject);


//            }

//        }



//        Debug.Log(states.Heart);
//    }
//}