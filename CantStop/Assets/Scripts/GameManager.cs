using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool _gameOver = false;
    [SerializeField] float _restartTime = 1f;
    [SerializeField] GameObject _completeLevelUI;


    public void CompleteLevel()
    {
        _completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (_gameOver == false)
        {
            _gameOver = true;
            Invoke("Restart", _restartTime);
        }
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
