using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float value = 100;
    public RectTransform ValueRectTransform;

    public GameObject GameOverScreen;
    public GameObject GameplayUI;

    private float _maxValue;

    private void Start()
    {
        _maxValue = value;
        DrawHealthBar();
    }
    public void DealDamage(float damage)
    {
        value -= damage;
        if (value <= 0)
        {
            PlyerIsDead();
        }
        DrawHealthBar();
    }

    private void PlyerIsDead()
    {
        GameplayUI.SetActive(false);
        GameOverScreen.SetActive(true);
        GetComponent<PlatformerCharacterController>().enabled = false;
    }
    private void DrawHealthBar()
    {
        ValueRectTransform.anchorMax = new Vector2(value / _maxValue, 1);
    }
}
