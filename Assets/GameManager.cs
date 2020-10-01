using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    [SerializeField] float restartDelay = 2f;
    [SerializeField] GameObject completeLevelUI;
 
  public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over......");
            Invoke("Restart", restartDelay);// Invoke function is used to schedule method calls to occur at a later time.
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LevelComplete()
    {
        completeLevelUI.SetActive(true);
        Debug.Log("Level Complete.");
    }
}
