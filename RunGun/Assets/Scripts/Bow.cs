using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    private bool fireButtonDown = false;

    public int bowMaxDrawTime = 100;
    private int bowDrawCounter = 0;

    public float bowMaxSpeed = 30;
    public float bowMinSpeed = 1;
    private float bowSpeedCounter = 0;
    private float bowSpeedIncrement = 0;

    public int bowMaxPower = 100;
    public int bowMinPower = 10;
    private int bowPowerCounter = 0;
    private int bowPowerIncrement = 0;

    public GameObject arrowPrefab;
    public Transform bowFirePoint;

    // Start is called before the first frame update
    void Start()
    {
        bowPowerIncrement = (bowMaxPower - bowMinPower) * 1000 / bowMaxDrawTime;
        bowSpeedIncrement = (bowMaxSpeed - bowMinSpeed) / bowMaxDrawTime;

        Debug.Log(bowSpeedIncrement + " " + bowPowerIncrement);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckFireBow();
    }

    void CheckFireBow()
    {
        if (Input.GetButton("Fire1"))
        {
            fireButtonDown = true;

            bowDrawCounter++;
            if(bowDrawCounter >= bowMaxDrawTime)
            {
                bowDrawCounter = bowMaxDrawTime;
            }

            bowPowerCounter += bowPowerIncrement;
            if(bowPowerCounter >= bowMaxPower * 1000)
            {
                bowPowerCounter = bowMaxPower * 1000;
            }

            bowSpeedCounter += bowSpeedIncrement;
            if (bowSpeedCounter >= bowMaxSpeed)
            {
                bowSpeedCounter = bowMaxSpeed;
            }
        }
        else
        {
            if (fireButtonDown)
            {
                ShootBow();
            }
            fireButtonDown = false;
            bowPowerCounter = 0;
            bowSpeedCounter = 0;
            bowDrawCounter = 0;
        }
    }

    void ShootBow()
    {
        GameObject arrow = Instantiate(arrowPrefab, bowFirePoint.position, bowFirePoint.rotation);
        Arrow arrowScript = arrow.GetComponent<Arrow>();
        arrowScript.IncreaseDamage(bowPowerCounter / 1000);
        arrowScript.IncreaseSpeed(bowSpeedCounter);
    }
}
