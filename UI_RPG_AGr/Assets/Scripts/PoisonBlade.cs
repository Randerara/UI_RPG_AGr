using UnityEngine;

public class PoisonBlade : Blade
{
    [SerializeField] private float posionDamage;

    [SerializeField] private int poisonCount;

    public override float GetDamage()
    {
        float baseDamage = base.GetDamage();
        if(poisonCount > 0)
        {
            poisonCount--;
            return baseDamage + posionDamage;
        }
        return baseDamage;
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
