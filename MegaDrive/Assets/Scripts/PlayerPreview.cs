using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPreview : MonoBehaviour
{
    public int player;
    public GameObject model1;
    public GameObject model2;
    // Start is called before the first frame update
    void Start()
    {
        switch(player){
            case 1:
                setPlayerModel(GM_Info.Instance.player1Model); 
                break; 
            case 2:
                setPlayerModel(GM_Info.Instance.player2Model); 
                break; 
            case 3:
                setPlayerModel(GM_Info.Instance.player3Model); 
                break; 
            case 4:
                setPlayerModel(GM_Info.Instance.player4Model); 
                break; 
        }
    }

    public void setPlayerModel(bool plbool){
        if(plbool == true){
            model1.SetActive(true);
            model2.SetActive(false);
        }
        else{
            model2.SetActive(true);
            model1.SetActive(false);
        }
    }

}
