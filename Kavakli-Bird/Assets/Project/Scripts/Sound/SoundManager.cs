using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    [SerializeField] private AudioClip BlockPassClip;
    [SerializeField] private AudioClip JumpClip;
    [SerializeField] private AudioClip DieClip;
    private AudioSource audioSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void PlayDieClip()
    {
        audioSource.PlayOneShot(DieClip);
    }

    public void PlayJumpClip()
    {
        audioSource.PlayOneShot(JumpClip);
    }

    public void PlayBlockPassClip()
    {
        audioSource.PlayOneShot(BlockPassClip);
    }
}