using UnityEngine;

public class GameStates : MonoBehaviour
{
    public static GameStates Instance;

    private GameState gameState;

    [SerializeField] private GameObject game;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject dieMenu;
    [SerializeField] private GameObject characterSelectMenu;

    public enum GameState
    {
        InGame,
        MainMenu,
        Die,
        CharacterSelect
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ChangeGameState(GameState.MainMenu);
    }

    public void ChangeGameState(GameState state)
    {
        gameState = state;

        OnGameStateChange();
    }

    private void OnGameStateChange()
    {
        game.SetActive(gameState == GameState.InGame);
        mainMenu.SetActive(gameState == GameState.MainMenu);
        dieMenu.SetActive(gameState == GameState.Die);
        characterSelectMenu.SetActive(gameState == GameState.CharacterSelect);
    }
}
