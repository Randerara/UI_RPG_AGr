using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapons activeWeapon;
    [SerializeField] private GameObject gameOver;
    public override void Attack(Character enemyToHit)
    {
        enemyToHit.TakeDamage(activeWeapon);
        /*float damage = activeWeapon.GetDamage();
        enemyToHit.TakeDamage(damage);*/
        
    }

    public override void Death()
    {
        Time.timeScale = 0f;
        gameOver.SetActive(true);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
