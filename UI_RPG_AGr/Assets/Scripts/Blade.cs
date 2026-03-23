using UnityEngine;

public class Blade : Weapons
{
    public float minDamage, maxDamage;

    public override float GetDamage()
    {
        return Random.Range(minDamage, maxDamage);
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
