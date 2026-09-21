using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{   
    [SerializeField] float speed = 1.0f;

    [SerializeField] Transform player;
    Vector3 playerPosition;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();

    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
        
    }
}
