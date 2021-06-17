using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    [SerializeField] private TextMeshProUGUI _sliderText;
    // Start is called before the first frame update
    void Start()
    {
        SetSliderText(_slider.value);

        _slider.onValueChanged.AddListener((v) => {
            SetSliderText(v);
        });
    }

    void SetSliderText(float v){
        float percent = (v / ((-1)*_slider.minValue) + 1) * 100;
        int show_percent = (int)percent;
        _sliderText.text = (show_percent + "%");
    }

}
