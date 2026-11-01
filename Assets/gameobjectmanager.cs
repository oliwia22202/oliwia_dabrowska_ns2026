using UnityEngine;

public class gameobjectmanager : MonoBehaviour
{
    public GameObject[] gameObjects;

    void Start()
    {
        CheckGameObjects();
    }

    void CheckGameObjects()
    {
        foreach (GameObject obj in gameObjects)
        {
            if (obj.GetComponent<MeshRenderer>() != null)
            {
                Debug.Log(obj.name + " - 3D");
            }
            else if (obj.GetComponent<SpriteRenderer>() != null)
            {
                Debug.Log(obj.name + " - 2D");
            }
            else
            {
                Debug.Log(obj.name + " - brak komponentu Renderer");
            }
        }
    }
}