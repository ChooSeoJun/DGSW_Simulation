﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseName : SceneBase
{
    public InputField PName;

    // Start is called before the first frame update
    new void Start()
    {
        PName.onEndEdit.AddListener((string name) =>
        {
            nextScene = "Prologue_birthday";
            CharacterManager.Get_instance().playerName = name;
            EndScene();
        });

        base.Start();
    }
}
