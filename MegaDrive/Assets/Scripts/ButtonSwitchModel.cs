using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitchModel : MonoBehaviour
{
    public Button self;
    public int player;
    public bool boolean;
    // Start is called before the first frame update
    void Start()
    {
        self.onClick.AddListener(() => GM_Info.Instance.setPlayerModel(player, boolean));
    }

}
