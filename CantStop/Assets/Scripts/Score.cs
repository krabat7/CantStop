using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] Text _scoreText;
    private void Update()
    {
        if (_player.position.z > 0)
        {
            _scoreText.text = _player.position.z.ToString("0");
        }
    }
}
