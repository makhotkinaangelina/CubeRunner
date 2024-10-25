using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;
    }

    void Update()
    {
        float verticalPosition = transform.position.y;
        transform.position = new Vector3(player.position.x + offset.x, verticalPosition, player.position.z + offset.z);
    }
}