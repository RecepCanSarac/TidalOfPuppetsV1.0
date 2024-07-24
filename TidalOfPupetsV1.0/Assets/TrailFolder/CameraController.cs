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
    public Vector3 offset;
    public Transform ship;

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

        if (cam.orthographicSize < 15)
        {
            Vector3 targetPosition = playerController.transform.position + new Vector3(0, 0, -10);
            transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * zoomSpeed);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(ship.position.x, ship.position.y - offset.y, -10), Time.deltaTime * zoomSpeed);
        }

        bool isZoomedIn = cam.orthographicSize < (minZoom + maxZoom) / 2;
        if (playerController.isOkey != isZoomedIn)
        {
            playerController.isOkey = isZoomedIn;
        }
    }
}
