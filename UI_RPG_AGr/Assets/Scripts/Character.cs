using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health;
    [SerializeField]
    private string charName;

    public string CharName
    {
        get { return charName; }
    }

    public void TakeDamage(float damage)
    {
        health = health - damage;
        Debug.Log(charName + " takes " + damage + " damage. Health: " + health);
        if (health < 0f)
        {
            Death();
        }

    }

    public void TakeDamage(Weapons throwWeapons)
    {
        float damage = throwWeapons.GetDamage();
        TakeDamage(damage);
        /*health = health - throwWeapons.GetDamage();
        Debug.Log(charName + " takes " + damage + " damage. Health: " + health);*/
    }

    public abstract void Death();
    
    public abstract void Attack(Character toHit);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
