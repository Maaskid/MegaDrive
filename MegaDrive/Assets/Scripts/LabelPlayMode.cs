using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelPlayMode : MonoBehaviour
{
    public GameObject label1;
    public GameObject label2;
    
    // Start is called before the first frame update
    void Start()
    {
        if(GM_Info.Instance.gameModeBool == true){
            label1.SetActive(true);
            label2.SetActive(false);
        }
        else{
            label2.SetActive(true);
            label1.SetActive(false);
        }
    }

}
