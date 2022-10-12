using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelNum : MonoBehaviour
{
    public Text Text;
    public Game Game;

    private void Start()
    {
        Text.text = "Level " + (Game.LevelIndex + 1).ToString();
    }
}
