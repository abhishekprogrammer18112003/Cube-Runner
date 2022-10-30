using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class soundmanager : MonoBehaviour
{
    [SerializeField] Image soundonicon, soundofficon;
    private bool muted = false;
    void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            load();
        }
        else
        {
            load();
        }
        updatebuttonicon();
        AudioListener.pause = muted;
    }
    public void onbtnpressed()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        save();
        updatebuttonicon();
    }


    private void updatebuttonicon()
    {
        if (muted == false)
        {
            soundonicon.enabled = true;
            soundofficon.enabled = false;
        }
        else
        {
            soundonicon.enabled = false;
            soundofficon.enabled = true;
        }
    }
    private void load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
}
