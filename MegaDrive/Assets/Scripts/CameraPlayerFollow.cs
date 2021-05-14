using UnityEngine;

public class CameraPlayerFollow : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    void FixedUpdate()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, Player.eulerAngles.y, transform.eulerAngles.z);
        transform.position = Player.position;
        transform.Translate(offset);
    }
}
