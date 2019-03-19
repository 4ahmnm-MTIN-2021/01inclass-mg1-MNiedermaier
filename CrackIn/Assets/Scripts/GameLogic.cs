using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    public TextMeshProUGUI coinNumber;
    public int coinAmount;
    public GameObject player;

    void Update()
    {
        coinNumber.text = coinAmount.ToString();
       
    }

    public void AddCoin()
    {
        coinAmount++;
    }
}