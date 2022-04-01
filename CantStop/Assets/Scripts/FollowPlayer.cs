using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] Vector3 _offset;

    private void Update()
    {
        transform.position = _player.position + _offset;
    }
}
