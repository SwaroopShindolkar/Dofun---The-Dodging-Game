using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timer = 2f;
    
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timer)
        {
            Debug.Log("Time Up!!");
            myRigidBody.useGravity = true;
        }
        
    }
}
