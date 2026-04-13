using UnityEngine;

public class EnemyBoss : Character
{
    [SerializeField] private float minDamage, maxDamage;
    [SerializeField] private int bigAttack;
    
    public override void Attack(Character toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        toHit.TakeDamage(damage);
        if(bigAttack > 0)
        {
            bigAttack--;
        }
    }

    public override void Death()
    {
        return;
    }
    
}
