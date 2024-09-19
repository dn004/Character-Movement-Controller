using UnityEngine;

public class AbeController : MonoBehaviour
{
    public Animator AbeNim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S pressed");
            bool activeState = AbeNim.GetBool("FightPosition");
            AbeNim.SetBool("FightPosition", !activeState);

            if (!activeState)
            {
                Debug.Log("Switched to fighting position.");
            }
            else
            {
                Debug.Log("Switched to stretching arms.");
                AbeNim.SetTrigger("ArmStreching");
            }
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("F pressed");
            AbeNim.SetBool("FightPosition", true);
        }
    }
}
