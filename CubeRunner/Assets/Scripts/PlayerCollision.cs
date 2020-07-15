using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement; //reference to our PlayerMovement script
    
    //This function runs when the player collides with an obstacle
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; //disable player's movement (stop)
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
