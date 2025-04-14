using DG.Tweening;
using UnityEngine;

public class DoTween : MonoBehaviour
{
    public Transform beegMario;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // beegMario.DOMoveX(500f, 5f, false); 
        //Will move to unity 500 in 5 seconds, and it will move smoothly

        // beegMario.transform.DOMoveX(beegMario.transform.position.x + 500f, 5f);
        //This will just add 500 units to its prexisting position

        // beegMario.transform.DOMove(beegMario.transform.position + (Vector3.right * 500), 5f);
        // Will move the whole thing to thr right by 500 units over 5 seconds

        // beegMario.transform.DORotate(beegMario.transform.rotation.eulerAngles + new Vector3(0f, 0f, -180), 5f);
        //Will rotate by the Z axis (do not use the quaternion)

        Sequence s = DOTween.Sequence();
        s.Append(beegMario.transform.DOMove(beegMario.transform.position + (Vector3.right * 500), 5f));
        //Asks for the append to do this all at the start
        s.Insert(0f, beegMario.transform.DORotate(beegMario.transform.rotation.eulerAngles + new Vector3(0f, 0f, -180), 5f));
        //Will insert itself with the Append, and the 0f means it will happen alongside the move.
        s.Append(beegMario.transform.DOMove(beegMario.transform.position, 5f));
        //Starts a new append, and it will move back in the opposite direction.
        //The transform position here is referencing the original position, hence why we don't need to add anything.
        //If we do subtract from it now, it will miuns that amount from its original position instead of its current.
        s.Insert(5f, beegMario.transform.DORotate(beegMario.transform.rotation.eulerAngles, 5f));
        //The insert will happen at the same time as the append, BUT it will happen during the 5 seconds after the first append happens.
        s.PlayForward();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DOTween.CompleteAll();
            //CompleteAll will set the tweens at their final position, then stops (including the ones in a sequence).
            //KillAll does the same as stopping the tweens during it's current position.

            //If we complete or kill a singular one, we need to pass in the object that
            //has a tween on it, in this case it's beegMario.transform

            //DOTween.Complete(beegMario.transform);
        }
    }
}

