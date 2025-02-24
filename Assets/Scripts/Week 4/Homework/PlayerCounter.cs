using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerCounter : MonoBehaviour
{
    public GameObject booGhostpreFab;

    public class BooGhost
    {

    }

    public List<BooGhost> booghost = new List<BooGhost>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        booghost = FindObjectsByType<BooGhost>(FindObjectsSortMode.None).ToList();

        GameObject go = Instantiate(booGhostpreFab);
        booghost.Add(go.GetComponent<BooGhost>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
