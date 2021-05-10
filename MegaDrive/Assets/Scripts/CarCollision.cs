using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public GoalBallBehavior GoalBall;

    void OnCollisionEnter(Collision coll)
    {
        //wenn ein Auto den Ball hält und es ein Auto ist, wird die Collision == carcapture gesetzt
        if(holdsBall() && isCar(coll.transform))
         {
             //greift auf die Funktion Follow() aus Ballbehavior zu
             GoalBall.Follow(coll.transform);
         }
    }

    //prüft ob das Auto den ball hält
    bool holdsBall()
    {
        return GoalBall.carCapture.name == this.name;
    }

    //Prüft, ob das Auto als "Car" getaggt ist
    bool isCar(Transform toTest)
    {
        return toTest.tag == "Car";
    }
}