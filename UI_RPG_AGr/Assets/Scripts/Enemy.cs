using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float minDamage, maxDamage;
    [SerializeField] private GameObject[] enemies;
    private GameObject enemy;
    
    public override void Attack(Character toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        toHit.TakeDamage(damage);
    }

    void SelectEnemy(int index)
    {
        /*if (enemy != null)
            enemy = SelectEnemy[];*/
    }

    public override void Death()
    {
        SelectEnemy(0);
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
