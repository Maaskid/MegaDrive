using UnityEngine;

public class CarReset : MonoBehaviour
{

    Rigidbody rb;

    bool noMovement;
    bool isUpsidedown;
    bool timesUp;
    bool isUp;
    public int timer = 5;
    private float flip1 = 0f;
    private float flip2 = 0f;

    public bool debug;

    //resettet das Auto in der Luft
    Vector3 resetOffset = new Vector3 (0, 4, 0);

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        BoolReset();
    }

    void FixedUpdate()
    {
        var orientation = Mathf.Abs(Vector3.Dot(transform.right, Vector3.up)) > 0.1 || Vector3.Dot(transform.up, Vector3.down) > 0;
        if (orientation && isUpsidedown == false)
        {
            isUpsidedown = true;
            isUp = true;
            flip1 = Time.time;
            //Debug.log("Upsidedown");
            return;
        }

        if(GetComponent<Rigidbody>().velocity.magnitude < 0.01 && isUpsidedown)
        {
            if(isUpsidedown && noMovement == false)
            {
                noMovement = true;
                flip2 = Time.time;
                //Debug.log("No movement");
                return;
            }

            if(noMovement && (Time.time - flip2) > timer && timesUp == false)
            {
                timesUp = true;
                //Debug.Log("Times Up");
                return;
            }
        }

        if(noMovement && isUpsidedown && timesUp)
        {
            BoolReset();
            Reset();
        }

        if(!orientation && isUp == true)
        {
            BoolReset();
        }
    }

    void BoolReset()
    {
        noMovement = false;
        isUpsidedown = false;
        timesUp = false;
        isUp = false;
    }

    void Reset()
    {
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        transform.position = transform.position + (transform.up *4);
    }
}
