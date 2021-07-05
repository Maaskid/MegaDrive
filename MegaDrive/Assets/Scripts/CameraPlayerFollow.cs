using UnityEngine;
using EZCameraShake;
public class CameraPlayerFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset = new Vector3(0.0f, 2.75f, -7.5f);

    void Update()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, Player.eulerAngles.y, transform.eulerAngles.z);
        transform.position = Player.position;
        transform.Translate(offset);
    }
}
