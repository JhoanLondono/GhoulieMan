using UnityEngine;

public class KnifeDestruction : MonoBehaviour
{
    public float lifeSpan = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, lifeSpan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
