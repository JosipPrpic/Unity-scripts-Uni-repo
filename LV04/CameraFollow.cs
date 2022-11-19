using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        //pozicija kamere je pozicija targeta
        //(u ovom slucaju playera odnosno sfere) sa nadodanim offsetom.
        transform.position = target.position + offset;
    }
}
