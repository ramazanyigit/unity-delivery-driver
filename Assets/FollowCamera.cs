using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followedObject;

    // Update is called once per frame
    void Update()
    {
        transform.position = followedObject.transform.position + new Vector3(0,0, -10);
    }
}
