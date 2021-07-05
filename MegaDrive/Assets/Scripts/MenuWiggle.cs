using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class MenuWiggle : MonoBehaviour
{
    public float magnetude;
    public float roughness;
    public float fadeIn;
    public float fadeOut;
    // Update is called once per frame
    void Update()
    {
        CameraShaker.Instance.ShakeOnce(magnetude, roughness, fadeIn, fadeOut);
    }
}