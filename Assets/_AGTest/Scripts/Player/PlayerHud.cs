using System.Collections.Generic;
using _AGTestLoot;
using UnityEngine;
using TMPro;

public class PlayerHud : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerHealthText;
    [SerializeField] private TextMeshProUGUI playerLootText;

    private void Awake()
    {
        PlayerHealth.OnUpdatePlayerHealth += UpdateHealthText;
        PlayerLoot.OnUpdatePlayerLoot += UpdateLootText;
    }

    private void UpdateHealthText(int health)
    {
        playerHealthText.text = $"Health: {health}";
    }

    private void UpdateLootText(Dictionary<CubeColor, int> lootList)
    {
        playerLootText.text = $"<color=#FF0000>{lootList[CubeColor.red]}  " +
                              $"<color=#00FF00>{lootList[CubeColor.green]}  " +
                              $"<color=#FFFF00>{lootList[CubeColor.yellow]}";
    }
}
