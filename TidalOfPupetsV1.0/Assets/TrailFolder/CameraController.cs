using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float zoomSpeed = 10f;
    public float minZoom = 5f;
    public float maxZoom = 10f;
    private Camera cam;
    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        cam.orthographicSize -= scrollInput * zoomSpeed;
        cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minZoom, maxZoom);

        bool isZoomedIn = cam.orthographicSize < 6;
        if (playerController.isOkey != isZoomedIn)
        {
            playerController.isOkey = isZoomedIn;
            Debug.Log("asdasdf");
        }
    }
}
