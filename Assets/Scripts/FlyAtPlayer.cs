using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
   
    void Start()
    {
        playerPosition = player.transform.position;
    }

    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, 1f);
    }
}
