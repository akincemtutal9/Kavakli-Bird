using UnityEngine;
using UnityEngine.UI;

public class DieMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private void Start()
    { 
        playButton.onClick.AddListener(HandleRestart);   
    }

    private void HandleRestart()
    {
        GameStates.Instance.ChangeGameState(GameStates.GameState.MainMenu);
    }
}
