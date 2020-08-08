using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovements movement;    // A reference to PlayerMovement script

    // This function runs when we hit another object.
    // We get information about the collision and call it "collisionInfo"
    void OnCollisionEnter (Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle"
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;   // Disable the player's movement
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
