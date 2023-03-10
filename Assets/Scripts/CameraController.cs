using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        offSet = target.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - offSet;

        transform.LookAt(target);
    }
}
