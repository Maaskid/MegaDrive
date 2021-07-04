using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPlayerAmount : MonoBehaviour
{
    public int amount;
    public Button self;
    
    // Start is called before the first frame update
    void Start()
    {
        self.onClick.AddListener(() => GM_Info.Instance.setPlayerAmount(amount));
    }

}
