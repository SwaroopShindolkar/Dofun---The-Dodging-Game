using UnityEngine;

public class DropTrigger : MonoBehaviour
{
    [SerializeField] GameObject dropper;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            dropper.SetActive(true);
            Destroy(gameObject);
        }
    }
}
