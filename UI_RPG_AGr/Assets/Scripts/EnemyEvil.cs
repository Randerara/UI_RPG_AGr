using UnityEngine;

public class EnemyEvil : Character
{
    [SerializeField] private float minDamage, maxDamage;
    [SerializeField] private int fastAttack;
    
    public override void Attack(Character toHit)
    {
        float damage = Random.Range(minDamage, maxDamage);
        toHit.TakeDamage(damage);
        if(fastAttack > 0)
        {
            fastAttack--;
        }
    }

    public override void Death()
    {
        return;
    }
    
}
