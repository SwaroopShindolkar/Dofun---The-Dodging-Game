using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    int hits = 0;
    void OnCollisionEnter(Collision other) 
    {
        hits++;
        Debug.Log("The number of times you hit are : " + hits);
    }
}
