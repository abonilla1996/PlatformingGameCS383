
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPosX; 
    private Vector3 velocity = Vector3.zero;

    //FollowPlayer
    [SerializeField] private Transform player;

    private void Update()
    {
        //Room Camera
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX, transform.position.y, transform.position.z), ref velocity, speed);

        //FollowPlayer
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x;
    }
}
