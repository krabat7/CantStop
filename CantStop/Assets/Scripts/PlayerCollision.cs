using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] PlayerMovement _playerMovement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            _playerMovement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
