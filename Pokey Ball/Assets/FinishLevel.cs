using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    public void OnTriggerExit(Collider other)
    {
        UiManager.instence.nextLvl();
    }
}
