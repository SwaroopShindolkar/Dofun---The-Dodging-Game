using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRot = 0f;
    [SerializeField] float yRot = 1f;
    [SerializeField] float zRot = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(xRot, yRot, zRot);
    }
}
