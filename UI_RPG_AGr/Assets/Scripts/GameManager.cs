using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Character player;
    [SerializeField] private Character enemy;
    //[SerializeField] private Character evil;
    //[SerializeField] private Character boss;
    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP; //evilName, evilHP, bossName, bossHP;
    [SerializeField] private List<Character> allEnemies;
    [SerializeField] private Weapons normalBlade;
    [SerializeField] private Weapons poisonBlade;
    [SerializeField] private Weapons hammerBlade;
    private Character currentEnemy;

    private Transform spawnPoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var e in allEnemies)
        {
            e.gameObject.SetActive(false);
        }

        RandomEnemy();
        UpdateUI();
    }

    private void RandomEnemy()
    {
        if (currentEnemy != null)
        {
            currentEnemy.health = currentEnemy.maxHealth;
            currentEnemy.gameObject.SetActive(false);
        }
        
        int enemyIndex = Random.Range(0, allEnemies.Count);
        currentEnemy = allEnemies[enemyIndex];
        currentEnemy.gameObject.SetActive(true);
        UpdateUI();
    }
    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        //evilName.text = evil.CharName;
        //bossName.text = boss.CharName;
        playerHP.text = "HP: " + player.health.ToString("F0");
        enemyHP.text = "HP: "+ enemy.health.ToString("F0");
        //evilHP.text = "HP: " + evil.health.ToString("F0");
        //bossHP.text = "HP: " + boss.health.ToString("F0");
        if (currentEnemy != null)
        {
            enemyName.text = currentEnemy.CharName;
            enemyHP.text = "HP: " + currentEnemy.health.ToString("F0");
        }
    }

    public void PlayerAttack()
    {
        Damage(normalBlade);
        
    }

    public void DaggerAttack()
    {
        Damage(poisonBlade);
    }

    public void HammerAttack()
    {
        Damage(hammerBlade);
    }

    public void Damage(Weapons selectedWeapon)
    {
        
        if (currentEnemy == null)
            return;
        player.Attack(currentEnemy);
        currentEnemy.TakeDamage(selectedWeapon);
        if (currentEnemy.health <= 0)
        {
            RandomEnemy();
        }
        else
        {
            currentEnemy.Attack(player);
        }
        //enemy.Attack(player);
        UpdateUI();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("App escaped");
    }
    void Update()
    {
        
    }
}
