using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{

    public HPManager hpManager;

    // Start is called before the first frame update
    void Start()
    {
        HPManager hpManager = GetComponentInParent<HPManager>();
    }

    // Update is called once per frame
    public void OnButtonPressed()
    {
        hpManager.DecreaseHp(1);
    }
}
