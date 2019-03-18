using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    private SceneLoader sceneLoader;
    public TextMeshProUGUI coinNumber;
    public int coinAmount;
    public GameObject player;

    void Start()
    {
    }

    void Update()

    {
        coinNumber.text = coinAmount.ToString();
       
    }

    public void AddCoin()
    {
        coinAmount++;
    }
}