using UnityEngine;
using UnityEngine.SceneManagement;


public class ObstacleCollision : MonoBehaviour
{
    public ObstacleMove movement;


    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }

        if (collisionInfo.collider.tag == "floor")
        {
            movement.enabled = true;
        }
    }
}
