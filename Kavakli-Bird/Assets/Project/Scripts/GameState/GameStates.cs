using UnityEngine;

public class GameStates : MonoBehaviour
{
    public static GameStates Instance;

    private GameState gameState1;

    [SerializeField] private GameObject Game;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private GameObject DieMenu;
    [SerializeField] private GameObject CharacterSelectMenu;

    public GameState GameState1 { get => gameState1; set => gameState1 = value; }

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
        ChangeGameState(GameState.MainMenu);
        
    }
   
    public void ChangeGameState(GameState state)
    {
        GameState1 = state;
    
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
        Game.SetActive(true);
        DieMenu.SetActive(false);
        MainMenu.SetActive(false);
        CharacterSelectMenu.SetActive(false);
    }
    public void OnDieMenu() { 
        DieMenu.SetActive(true);
        MainMenu.SetActive(false);
        CharacterSelectMenu.SetActive(false);
        Game.SetActive(false);

    }
    public void OnMainMenu()
    {
        DieMenu.SetActive(false);
        MainMenu.SetActive(true);
        CharacterSelectMenu.SetActive(false);
        Game.SetActive(false);

    }
    public void OnCharacterSelect()
    {
        CharacterSelectMenu.SetActive(true);
        MainMenu.SetActive(true);
        DieMenu.SetActive(false);
        Game.SetActive(false);
    }
}
