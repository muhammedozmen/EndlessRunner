using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTrigger : MonoBehaviour
{
    public PlaneManager planeManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            planeManager.spawnNextPlane(transform.position + Vector3.forward * 200);
        }
    }

    private void Awake()
    {
        planeManager.SpawnObstacles(transform.position);
    }
}
