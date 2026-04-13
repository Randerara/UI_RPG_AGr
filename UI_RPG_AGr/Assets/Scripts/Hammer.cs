using UnityEngine;

public class Hammer : Blade
{
    [SerializeField] private float hammerDamage;

    [SerializeField] private int bleedCount;

    public override float GetDamage()
    {
        float baseDamage = base.GetDamage();
        if(bleedCount > 0)
        {
            bleedCount--;
            return baseDamage + bleedCount;
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
