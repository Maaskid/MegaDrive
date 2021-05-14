using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class GoalBallBehavior : MonoBehaviour
{

    public Vector3 offset;
    public Collider GoalCol;
    //GoalBallMaterial
    public Transform GBM;
    //DefaultGoalBallMaterial
    public Material DGBM;
    public Transform carCapture = null;
    public Transform GoalBall;
    public Light lt;
    public int Cooldown = 1000;
    public ParticleSystem Flame;
    private float lastUse = 0f;



    // Start is called before the first frame update
    void Start()
    {
        //Greift auf die Main des Particle Systems zu
        ParticleSystem.MainModule ma = Flame.main;

        //Setzt das Material auf das Default Material
        GBM.GetComponent<Renderer>().material = DGBM;
        lt.color = DGBM.color;
        Flame.startColor = DGBM.color;
    }

    void OnTriggerEnter(Collider GoalCol)
    {
        //Greift auf die Prefabs zu und nicht auf die Kollisionen
        Follow(GoalCol.transform.parent.parent);
    }

    //bestimmt welches Auto der Ball folgen muss
    public void Follow(Transform toFollow)
    {
        //beendet die Schleife, wenn der Cooldown nicht abgelaufen ist
        if(cooldownNotPassed())
        {
            return;
        }
        //Auto ist nun == carCapture
        carCapture = toFollow;
        changeColor();
        //Aktualisiert uns setzt die Zeit
        lastUse = Time.time;
    }

    private bool cooldownNotPassed()
    {
        //gibt die restliche Cooldown Zeit zurück
        return lastUse >= Time.time - Cooldown;
    }

    private void changeColor()
    {
        //findet das Material des Autos
        Material carMaterial = carCapture.Find("SkyCar").Find("SkyCarBody").GetComponent<Renderer>().material;
        //setzt die Farbe des Balles die Farbe des Autos
        GBM.GetComponent<Renderer>().material.color = carMaterial.color;
        //Setzt die Farbe des Lichtes die Farbe des Autos
        lt.color = carMaterial.color;
        //Setzt die Farbe der Partikel in die Farbe des Autos
        ParticleSystem.MainModule ma = Flame.main;
        ma.startColor = carMaterial.color;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if(carCapture != null)
        {
            //Ball schwebt über Auto
            transform.position = carCapture.position + offset;
        }   
    }
}
