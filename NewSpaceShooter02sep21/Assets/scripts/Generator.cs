using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] private float productionLevel = 1f;
    [SerializeField] private float productionRate = 0.1f;
    private float timePassed;
    private float power;

    private void Start()
    {
        timePassed = 0;
    }

    private void Update()
    {
        timePassed += Time.deltaTime;

        if(timePassed >= productionRate)
        {
            power += productionLevel;
            timePassed = 0;
        }
    }

    public float GetPower()
    {
        float _power = power;

        if(power > 0) { power = 0; }

        return _power;
    }
}
