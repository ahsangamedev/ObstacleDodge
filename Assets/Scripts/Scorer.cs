using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;


    void OnCollisionEnter(Collision other)
    {
        hits ++;
        print("You have bumped into a thing thi many times: " + hits);



    }


}
