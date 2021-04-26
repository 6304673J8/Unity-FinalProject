using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour {
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string bgmPref = "bgmPref";
    private static readonly string sfxPref = "sfxPref";
    private int firstPlayInt;
    public Slider bgmSlider, sfxSlider;
    private float bgmFloat, sfxFloat;
    public AudioSource bgmAudio;
    public AudioSource[] sfxAudio;

    // Start is called before the first frame update
    void Start() {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt == 0) {
            bgmFloat = .5f;
            sfxFloat = .5f;
            bgmSlider.value = bgmFloat;
            sfxSlider.value = sfxFloat;
            PlayerPrefs.SetFloat(bgmPref, bgmFloat);
            PlayerPrefs.SetFloat(sfxPref, sfxFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        } else {
            bgmFloat = PlayerPrefs.GetFloat(bgmPref);
            bgmSlider.value = bgmFloat;
            sfxFloat = PlayerPrefs.GetFloat(sfxPref);
            sfxSlider.value = sfxFloat;
        }
    }

    public void SaveSoundSettings() {
        PlayerPrefs.SetFloat(bgmPref, bgmSlider.value);
        PlayerPrefs.SetFloat(sfxPref, sfxSlider.value);
        Debug.Log(sfxSlider.value + ": Valor del Slider de SFX");
        Debug.Log(bgmSlider.value + ": Valor del Slider de BGM");
    }

    private void OnApplicationFocus(bool focus) {
        if (!focus) {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        bgmAudio.volume = bgmSlider.value;
        for(int i = 0; i < sfxAudio.Length; i++) {
            sfxAudio[i].volume = sfxSlider.value;
        }
    }
}
