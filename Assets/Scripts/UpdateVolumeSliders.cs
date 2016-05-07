using UnityEngine;
using System.Collections;

public class UpdateVolumeSliders : MonoBehaviour
{

    void OnEnable()
    {
        AudioManager.audio_manager.SetVolumeSliders();
    }
}
