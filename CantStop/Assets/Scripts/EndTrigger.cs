using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameManager _gameManager;
    private void OnTriggerEnter(Collider other)
    {
        _gameManager.CompleteLevel();
    }
}
