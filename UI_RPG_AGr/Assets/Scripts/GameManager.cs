using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] private Character player;
    [SerializeField] private Character enemy;
    [SerializeField] TMP_Text playerName, playerHP, enemyName, enemyHP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateUI();
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP: " + player.health.ToString("F1");
        enemyHP.text = "HP: "+ enemy.health.ToString("F1");
    }

    public void PlayerAttack()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
        
    }
    
    void Update()
    {
        
    }
}
