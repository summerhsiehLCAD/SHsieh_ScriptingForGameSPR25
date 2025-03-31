using UnityEngine;

public class Mammal : Animal
{
    protected virtual void Start()
    {
        bType = BloodType.WarmBlooded;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Eat(int energyGained)
    {
        Debug.Log("Chomp Chomp eating with mah mouf");
        base.Eat(energyGained);
    }

    public virtual void GiveBirth()
    {
        Debug.Log("Giving Birth To A Mammal");
    }
}
