using UnityEngine;

public class Generator : PowerSupply
{
    [SerializeField] protected float cyclesPerSecond;

    protected float timeRequired;
    protected float timePassed;
    
    protected override void Start()
    {
        base.Start();

        curPower = 0;
        maxDraw = curPower;

        timePassed = 0;

        SetTimeRequired();
    }

    protected void Update()
    {
        AdvanceTimer();
        CheckTimer();
    }

    protected void SetTimeRequired() { timeRequired = 100 / cyclesPerSecond; }
    protected void AdvanceTimer() { timePassed += Time.deltaTime; }
    protected void CheckTimer() { if (timePassed >= timeRequired) { CompleteCycle(); } }

    protected void CompleteCycle()
    {
        ProducePower();
        ResetTimer();
    }
    protected void ProducePower()
    { curPower += (maxPower / cyclesPerSecond); }

    protected void ResetTimer() { timePassed = 0; }

    protected void CapPower() { if (curPower < maxPower) curPower = maxPower; }

    public void DrawPower()
    {

    }
}
