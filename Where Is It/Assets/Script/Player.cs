using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject camera;

    private void Start()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        camera.transform.Rotate(-Input.gyro.rotationRateUnbiased.x, 0, 0);
        transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
        if (Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.forward * 6*Time.deltaTime);
        }
    }
}
