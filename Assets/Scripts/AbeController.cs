using System.Collections;
using UnityEngine;

public class AbeController : MonoBehaviour
{
    public Animator AbeNim;

    void Start()
    {
        Debug.Log("Starting...");
        StartCoroutine(PerformActions());
    }

    IEnumerator PerformActions()
    {
        Debug.Log("Waiting 5 seconds before stretching arms...");
        yield return new WaitForSeconds(5f);

        StrechArms();

        Debug.Log("Waiting for 5 more seconds before going into fight position...");
        yield return new WaitForSeconds(5f);

        GoIntoFightingPosition();
    }

    public void StrechArms()
    {
        AbeNim.SetTrigger("ArmStreching");
        Debug.Log("WE ARE NOW STRECHING.");
    }

    public void GoIntoFightingPosition()
    {
        AbeNim.SetTrigger("FightPosition");
        Debug.Log("WE ARE READY TO FIGHT");
    }
}
