using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public float PlayerLife = 10;

    public int Points = 0;

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }

    public static void StartGame()
    {
        instance.PlayerLife = 10;
        instance.Points = 0;
        SceneManager.LoadScene("Main");
    }

    public void GameOverDelayed(float delay)
    {
        Invoke("GameOver", delay);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void SaveHighScore()
    {
        var oldHighScore = GetHighScore();
        if (oldHighScore >= Points) return;

        PlayerPrefs.SetInt("HighScore", Points);
    }

    public int GetHighScore()
    {
        return PlayerPrefs.GetInt("HighScore", 0);
    }
}
