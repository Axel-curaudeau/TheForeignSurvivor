using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 posOffset;
    public float timeOffset;
    public Vector3 velocity;

    void Update()
    {
        Vector3 startPos = transform.position;
        Vector3 endPos = player.transform.position;
        //transform.position = Vector3.Lerp(startPos, endPos, 3*Time.deltaTime);
        transform.position = Vector3.SmoothDamp(startPos, endPos + posOffset, ref velocity, timeOffset);
    }
}
