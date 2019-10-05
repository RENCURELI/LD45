﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    //Define all different game states
    private enum GameState
    {
        None = 0,
        MainMenu,
        Zone1,
        Zone2,
        Zone3,
        Zone4,
        Zone5,
        Zone6,
        End,
    };

    public string messageTriggered;
    public string receivedDeathMessage;

    //Store current game state
    private GameState curState;

    //Check player current state
    private bool playerDead = false;

    // Start is called before the first frame update
    void Start()
    {
        //Setup listeners to enable message reciving
        Messenger.AddListener<GameObject>(messageTriggered, onDeathMessage);
        Messenger.AddListener<GameObject>(receivedDeathMessage, onDeathMessage);
    }

    /// <summary>
    /// React to player death
    /// </summary>
    /// <param name="propType"></param>
    void onDeathMessage(GameObject propType)
    {
        Debug.Log("PlayerDead");
    }
}