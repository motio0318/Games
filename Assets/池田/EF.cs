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



//        states = GameObject.Find("スケルトン").GetComponent<NightStutes>();
//        playerstates = GameObject.Find("主人公").GetComponent<PlayerStates>();

//        enemyHP = states.HP;


//        // ぶつかった相手に「Attack」というタグ（Tag）がついていたら、
//        if (other.gameObject.CompareTag("Attack"))
//        {

//            // 敵のHPをプレイヤーのatk分、減少させる
//            states.Heart -= playerstates.atk;



//            // 敵のHPが０になったら敵オブジェクトを破壊する。
//            if (enemyHeart == 0)
//            {

//                // オブジェクトを破壊する
//                Destroy(transform.root.gameObject);


//            }

//        }



//        Debug.Log(states.Heart);
//    }
//}