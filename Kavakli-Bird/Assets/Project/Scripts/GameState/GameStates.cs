using UnityEngine;

public class GameStates : MonoBehaviour
{
    public static GameStates Instance;

    public GameState gameState;

    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject DieMenu;
    [SerializeField] private GameObject CharacterSelectMenu;

    public enum GameState
    {
        InGame,
        MainMenu,
        Die,
        CharacterSelect
    }
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }
    private void Start()
    {
        gameState = GameState.MainMenu;
    }
   
    public void ChangeGameState(GameState state)
    {
        gameState = state;
    
        if(state == GameState.MainMenu)
        {
            OnMainMenu();
        }
        else if(state == GameState.Die)
        {
            OnDieMenu();
        }
        else if(state == GameState.CharacterSelect)
        {
            OnCharacterSelect();
        }
        else if(state == GameState.InGame)
        {
            OnInGame();
        }
        else
        {
            state = GameState.MainMenu;
        }
    }
    public void OnInGame()
    {
        Time.timeScale = 1.0f;
        DieMenu.SetActive(false);
        MainMenu.SetActive(false);
        CharacterSelectMenu.SetActive(false);
    }
    public void OnDieMenu() { 
        Time.timeScale = 0.0f;
        DieMenu.SetActive(true);
        MainMenu.SetActive(false);
        CharacterSelectMenu.SetActive(false);

    }
    public void OnMainMenu()
    {
        Time.timeScale = 0.0f;
        DieMenu.SetActive(false);
        MainMenu.SetActive(true);
        CharacterSelectMenu.SetActive(false);
    }
    public void OnCharacterSelect()
    {
        CharacterSelectMenu.SetActive(true);
        MainMenu.SetActive(true);
        DieMenu.SetActive(false);
        Time.timeScale = 0.0f;
    }
}
