using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float cameraSpeed = 3f; 

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        offset = Quaternion.AngleAxis(mouseX * cameraSpeed, Vector3.up) * offset;
        offset = Quaternion.AngleAxis(-mouseY * cameraSpeed, transform.right) * offset;

        transform.position = player.position + offset;
        transform.LookAt(player.position);
    }
}