using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Vector2 screeenSize { get; private set; }

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        screeenSize = FindScreenSize();
    }


    private void Update()
    {
        
    }

    private Vector2 FindScreenSize()
    {
        float _x = Camera.main.aspect * Camera.main.orthographicSize;
        float _y = Camera.main.orthographicSize;
        Vector2 _screenSize = new Vector2(_x, _y);

        return _screenSize;
    }
}
