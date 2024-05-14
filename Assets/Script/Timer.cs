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
        //§ŒÀŠÔ
        Rimmit -= Time.deltaTime;


        //­”2Œ…‚É‚µ‚Ä•\¦
        GetComponent<Text>().text = Rimmit.ToString("F0") + "•b";

        //Rimmit‚ª0ˆÈ‰º‚É‚È‚Á‚½‚Æ‚«
        if(Rimmit <= 0)
        {
            GetComponent<Text>().text ="ŠÔ‚É‚È‚è‚Ü‚µ‚½B";
        }


    }
}
