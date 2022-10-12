using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider Slider;
    public Player Player;
    public Transform Finish;
    public float FinishPlayer = 1f;

    private float _startX;
    private float _minimX;

    private void Start()
    {
        _startX = Player.transform.position.x;
    }

    private void Update()
    {
        _minimX = Mathf.Min(_minimX, Player.transform.position.x);
        float finishX = Finish.position.x;
        float t = Mathf.InverseLerp(_startX, finishX + FinishPlayer, _minimX);
        Slider.value = t;
    }
}
