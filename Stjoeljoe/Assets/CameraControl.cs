using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public float zoomSpeed = 3;
    public float targetOrtho;
    public float smoothSpeed = 2.0f;
    public float minOrtho = 1.0f;
    public float maxOrtho = 20.0f;

    public float movementSpeed = 0.5f;

    void Start()
    {
        targetOrtho = Camera.main.orthographicSize;
    }

    void Update()
    {
        UpdateCameraZoom();
        UpdateCameraLocation();
    }

    private void UpdateCameraLocation()
    {
        Vector3 newPos = Camera.main.transform.position;

        if (Input.GetKey(KeyCode.A))
            newPos.x -= movementSpeed;

        if (Input.GetKey(KeyCode.W))
            newPos.y += movementSpeed;

        if (Input.GetKey(KeyCode.S))
            newPos.y -= movementSpeed;

        if (Input.GetKey(KeyCode.D))
            newPos.x += movementSpeed;

        Camera.main.transform.position = newPos;
    }

    private void UpdateCameraZoom()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0.0f)
        {
            targetOrtho -= scroll * zoomSpeed;
            targetOrtho = Mathf.Clamp(targetOrtho, minOrtho, maxOrtho);
        }

        Camera.main.orthographicSize = Mathf.MoveTowards(Camera.main.orthographicSize, targetOrtho, smoothSpeed * Time.deltaTime);
    }
}
