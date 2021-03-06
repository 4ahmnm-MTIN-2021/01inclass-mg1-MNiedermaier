﻿using UnityEngine;

public class Fish : MonoBehaviour
{
    GameLogic gameLogic;

    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameLogic>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (gameLogic != null)
            {
                gameLogic.AddCoin();
                Destroy(this.gameObject);
            }
        }
    }
}
