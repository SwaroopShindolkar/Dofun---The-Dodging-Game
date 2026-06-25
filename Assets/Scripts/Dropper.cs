using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timer = 2f;

    private MeshRenderer myMeshRenderer;
    private Rigidbody myRigidBody;
    private float dropTime;
    private bool hasDropped;

    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();

        if (myMeshRenderer != null)
        {
            myMeshRenderer.enabled = false;
        }

        if (myRigidBody != null)
        {
            myRigidBody.useGravity = false;
        }

        dropTime = Time.time + timer;
    }

    private void Update()
    {
        if (hasDropped)
        {
            return;
        }

        if (Time.time >= dropTime)
        {
            hasDropped = true;
            Debug.Log("Time Up!!");

            if (myMeshRenderer != null)
            {
                myMeshRenderer.enabled = true;
            }

            if (myRigidBody != null)
            {
                myRigidBody.useGravity = true;
            }
        }
    }
}
