using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float  moveSpeed = 5f;
    

    void Start()
    {
        
    }


    void Update()
    {
        MovePlayer();   // HEllo this is the test

    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }


}
