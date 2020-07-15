using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; //writing transform in lowercase refers to gameobject in this file
    }
}
