using UnityEngine;

public enum GameState
{
    MainMenu,
    Playing,
    Paused,
    GameOver
}

public class GameStateManager : MonoBehaviour
{
    public GameState currentState = GameState.MainMenu;

    void Update()
    {
        switch (currentState)
        {
            case GameState.MainMenu:
                // Handle main menu logic
                break;
            case GameState.Playing:
                // Handle gameplay logic
                break;
            case GameState.Paused:
                // Handle pause logic
                break;
            case GameState.GameOver:
                // Handle game over logic
                break;
        }
    }

    // Example methods to change game state
    public void PlayGame()
    {
        currentState = GameState.Playing;
    }

    public void PauseGame()
    {
        currentState = GameState.Paused;
    }

    public void GameOver()
    {
        currentState = GameState.GameOver;
    }
}
