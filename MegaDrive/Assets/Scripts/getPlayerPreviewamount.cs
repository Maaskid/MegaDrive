using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getPlayerPreviewamount : MonoBehaviour
{
    public GameObject prewPlayer3;
    public GameObject prewPlayer4;

    // Start is called before the first frame update
    void Start()
    {

        switch(GM_Info.Instance.playerAmount){
            case 2:
                prewPlayer3.SetActive(false);
                prewPlayer4.SetActive(false);
                break;
            case 3:
                prewPlayer3.SetActive(true);
                prewPlayer4.SetActive(false);
                break;
            case 4:
                prewPlayer3.SetActive(true);
                prewPlayer4.SetActive(true);
                break;
        }
    }

}
