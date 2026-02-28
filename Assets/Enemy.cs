using UnityEngine;

public class Enemy : MonoBehaviour
{

    private SpriteRenderer sr;
    [SerializeField] private float redColorDuration = 1;
    
    [SerializeField] private float currentTimeInGame;
    [SerializeField] private float lastTimeWasDamage;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        ChangeColorIfNeeded();
    }

    private void ChangeColorIfNeeded()
    {
        currentTimeInGame = Time.time;

        if (currentTimeInGame > lastTimeWasDamage + redColorDuration)
        {
            if (sr.color != Color.white)
                sr.color = Color.white;
        }
    }

    public void TakeDemage()
    {
        sr.color = Color.red;
        lastTimeWasDamage = Time.time;
        

    }

}
