using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateStalker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        StalkingAI.isStalking = true;
    }
}
