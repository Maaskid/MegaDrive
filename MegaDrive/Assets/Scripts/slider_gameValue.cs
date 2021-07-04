using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider_gameValue : MonoBehaviour
{
    public Slider self;

    // Start is called before the first frame update
    void Start()
    {
        self.value = GM_Info.Instance.gameValue;
        self.onValueChanged.AddListener((v) => {
            GM_Info.Instance.gameValue = v;
        });
    }
}
