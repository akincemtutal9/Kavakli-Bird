using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    private GameStates gameStates;

    [SerializeField] private Button playButton;
    [SerializeField] private Button characterSelectionMenuButton;

    private void Start()
    {
        gameStates = GameStates.Instance;
        
        //Assign Button clicks
        playButton.onClick.AddListener(PlayGame);
        characterSelectionMenuButton.onClick.AddListener(GoToCharacterSelectionMenu);
    }

    private void GoToCharacterSelectionMenu()
    {
        gameStates.ChangeGameState(GameStates.GameState.CharacterSelect);
    }

    private void PlayGame()
    {
        gameStates.ChangeGameState(GameStates.GameState.InGame);x
    }
}
