using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject go;
    public GameObject go2;

    public Color go2ElseColor;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //ColorGameObjectByName();
        ColorGameObjectByTag();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ColorGameObjectByName()
    {
        Debug.Log("go is named" + go.name);
        Debug.Log("go2 is named" + go2.name);

        //If we create a local variable in the function that does the GetComponent call
        //once, we can use this variable multiple times that refers to this object's
        //specific MeshRenderer, more efficient that calling GetComponent constantly.
        MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();
        //references the go.getcomponent command "goMeshRenderer"

        if (go.name == "Cube")
        {
            //Change the color to magenta 
            //go.getcomponent will look for the component on the gameobject it is being called on.
            //If there is no component of the type you are trying to get, when you use the
            //dot operator after it, it will throw a null reference exception.
            goMeshRenderer.material.color = Color.magenta;
        }
        else if (go.name == "Sphere")
        {
            goMeshRenderer.material.color = Color.cyan;
            //Change color to cyan
        }
        else if (go.name == "Cylinder")
        {
            goMeshRenderer.material.color = Color.black;
            //Change color to black
        }
        else
        {
            goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
        }

        MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

        if (go2.name == "Cube")
        {
            go2MeshRenderer.material.color = Color.grey;
        }
        else if (go2.name == "Sphere")
        {
            go2MeshRenderer.material.color = Color.white;
        }
        else if (go2.name == "Cylinder")
        {
            go2MeshRenderer.material.color = Color.red;
        }
        else
        {
            go2MeshRenderer.material.color = go2ElseColor;
        }
    }

    void ColorGameObjectByTag()
    {
        { 
            MeshRenderer goMeshRenderer = go.GetComponent<MeshRenderer>();
            //references the go.getcomponent command "goMeshRenderer"

            if (go.tag == "CoolGuy")
            {
                //Change the color to magenta 
                //go.getcomponent will look for the component on the gameobject it is being called on.
                //If there is no component of the type you are trying to get, when you use the
                //dot operator after it, it will throw a null reference exception.
                goMeshRenderer.material.color = Color.magenta;
            }
            else if (go.tag == "LameGuy")
            {
                goMeshRenderer.material.color = Color.cyan;
                //Change color to cyan
            }
            else if (go.tag == "OkayGuy")
            {
                goMeshRenderer.material.color = Color.black;
                //Change color to black
            }
            else
            {
                goMeshRenderer.material.color = new Color32(200, 100, 3, 255);
            }

            MeshRenderer go2MeshRenderer = go2.GetComponent<MeshRenderer>();

            if (go2.tag == "CoolGuy")
            {
                go2MeshRenderer.material.color = Color.yellow;
            }
            else if (go2.tag == "LameGuy")
            {
                go2MeshRenderer.material.color = Color.white;
            }
            else if (go2.tag == "OkayGuy")
            {
                go2MeshRenderer.material.color = Color.red;
            }
            else
            {
                go2MeshRenderer.material.color = go2ElseColor;
            }
        }
    }

}
