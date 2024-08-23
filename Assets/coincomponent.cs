using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincomponent : MonoBehaviour
{
    public gamemana gameMg;
    private void OnTriggerEnter(Collider other)
    {
       
       if (other.gameObject.tag=="Player")
        {
            gameMg.coinAdd();
            Destroy(gameObject);
        }
    }
}
