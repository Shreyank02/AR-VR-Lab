using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySoundOnTrack : MonoBehaviour
{
    void Start()
    {
        // 'Start' is called on the first frame this object is active.
        // This is a very reliable way to play a one-shot sound.

        AudioSource audioSource = GetComponent<AudioSource>();

        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            // This will log an error to your console if the AudioSource is missing
            // You can view this on your phone using 'Logcat'
            Debug.LogError("AudioSource component is missing on this prefab!");
        }
    }

    // We don't need Awake() or OnEnable() for this version.
}