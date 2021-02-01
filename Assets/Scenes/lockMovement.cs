using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockMovement : MonoBehaviour
{
    public Vector3 minBounds;
    public Vector3 maxBounds;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
           Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x),
           Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y),
           Mathf.Clamp(transform.position.z, minBounds.z, maxBounds.z));

    }
}
