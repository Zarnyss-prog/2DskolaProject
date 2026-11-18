using UnityEngine;

public class GameControler : MonoBehaviour
{
    public GameObject vzor;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       GameObject klon = Instantiate(vzor, new Vector3(-5, 9, 0), vzor.transform.rotation);
        float scale = Random.Range(0.1f, 1.9f);
       klon.transform.localScale = new Vector3(scale, scale, 1); //Vector3.one; //Vector3(1, 1, 1) jednotkovy vektor
        klon.GetComponent<SpriteRenderer>().color = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)); //random geneator barev
        
        Destroy(klon, 5f);
    }
}
