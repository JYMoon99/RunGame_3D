using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadMoving : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == ("Player"))
        {
            RoadManager.roadCallback();

        }
    }
}
