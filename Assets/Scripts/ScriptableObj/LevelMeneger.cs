using Assets.Scripts.ScriptableObj;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMeneger : MonoBehaviour
{
    [SerializeField] private LevelList _LevelList;
    [SerializeField] private SaveLoadSystem _saveLoadSystem;

    private int _currentLevelIndex;

    private void Awake()
    {
        _currentLevelIndex = _saveLoadSystem.GetLevelIndex();
        _currentLevelIndex %= _LevelList.Levels.Length;
        Instantiate(_LevelList.Levels[_currentLevelIndex]);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            LoadNextLevel();
        }
    }

    private void LoadNextLevel()
    {
        _currentLevelIndex++;
        _saveLoadSystem.SaveLevel(_currentLevelIndex);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
