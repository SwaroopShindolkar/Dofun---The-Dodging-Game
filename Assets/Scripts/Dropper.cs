using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timer = 2f;
    [SerializeField] private float destroyDelay = 1.2f;

    private MeshRenderer myMeshRenderer;
    private Rigidbody myRigidBody;

    private float dropTime;
    private bool hasDropped;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

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

        // Time when the object should start dropping
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

            // Destroy the object after it has been falling for destroyDelay seconds
            Destroy(gameObject, destroyDelay);
        }
    }
}