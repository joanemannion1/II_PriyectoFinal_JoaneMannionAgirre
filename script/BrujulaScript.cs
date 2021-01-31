using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrujulaScript : MonoBehaviour
{
	public Transform playerTransform;
	Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {

        Input.compass.enabled = true;
        transform.rotation = Quaternion.Euler(0, Input.compass.trueHeading, 0);
    }
}
