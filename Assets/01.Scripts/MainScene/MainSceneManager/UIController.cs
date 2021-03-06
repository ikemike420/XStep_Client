﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private Text informationBoxText;
    
    [SerializeField]
    private FreeStyleViewController freeStyleViewController;

    public void SetInformationBoxText(string value){
        informationBoxText.text = value;
    }

    public void OpenSongInformationPanner(SongItemInformation information){
        freeStyleViewController.OpenPanner(information);
    }

    public void CloseSongInformationPaner(){
        freeStyleViewController.ClosePanner();
    }
}
