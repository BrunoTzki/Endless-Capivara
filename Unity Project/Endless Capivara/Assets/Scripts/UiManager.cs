using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Image[] lifeHearts;
    public Text coinText;

    public void UpdateCoins(int coin)
    {
        coinText.text = coin.ToString();
    }
    public void UpdateLive(int lives)
    {
        for (int i = 0; i < lifeHearts.Length; i++)
        {
            if (lives > i)
            {
                lifeHearts[i].color = Color.white;
            }
            else
            {
                lifeHearts[i].color = Color.black;
            }
        }
    }

}

