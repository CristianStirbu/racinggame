using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("player"))
        {
            Destroy(gameObject);
            Debug.Log("speedboost acquired");
        }
    }
}
