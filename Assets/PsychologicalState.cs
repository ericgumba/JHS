using UnityEngine;

public class PsychologicalState : MonoBehaviour
{
    public int health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void decrement_health()
    {
        health -= 10;
    }
    void increment_health()
    {
        health += 10;
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
