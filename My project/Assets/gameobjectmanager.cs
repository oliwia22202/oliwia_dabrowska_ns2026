using UnityEngine;

public class gameobjectmanager : MonoBehaviour
{
    public float minY = -5f;
    public float maxY = 5f;
    public GameObject[] gameObjects;
    public Gradient gradient;

    void Start()
    {
        CheckGameObjects();
    }
    void Update()
    {
        foreach (GameObject obj in gameObjects)
        {
            SpriteRenderer sprite = obj.GetComponent<SpriteRenderer>();
            if (sprite != null)
            {
                kolorowakostka(sprite);
            }
        }
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
    public void kolorowakostka(SpriteRenderer sprite)
    {
        float y = sprite.transform.position.y;

        float t = Mathf.InverseLerp(minY, maxY, y);

        sprite.color = gradient.Evaluate(t);
    }
}
