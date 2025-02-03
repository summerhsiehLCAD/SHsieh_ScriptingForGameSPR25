using UnityEngine;

public class ScriptReferencePractice : MonoBehaviour
{
    public BeefMarioifer marioController;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        marioController.scaleIncrease = 5f;
        marioController.RotateBeegMario();
        marioController.RotateBeegMario();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
