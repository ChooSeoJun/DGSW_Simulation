﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectGender : SceneBase
{
    public Button genderM, genderF;

    // Start is called before the first frame update
    new void Start()
    {
        genderM.onClick.AddListener(() =>
        {
            CharacterManager.Get_instance().gender = Gender.man;
            EndScene();
        });

        genderF.onClick.AddListener(() =>
        {
            CharacterManager.Get_instance().gender = Gender.woman;
            EndScene();
        });
        base.Start();
        nextScene = "Prologue_name";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
