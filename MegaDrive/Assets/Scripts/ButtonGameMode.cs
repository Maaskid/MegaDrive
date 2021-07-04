using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGameMode : MonoBehaviour
{
    public bool timebool;
    public Button self;
    // Start is called before the first frame update
    void Start()
    {
            self.onClick.AddListener(() => TaskOnClick(timebool));
    }

    void TaskOnClick(bool thing){
        Debug.Log("Click");
        GM_Info.Instance.gameModeBool = thing;
    }
}
