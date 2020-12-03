using UnityEngine;
using UnityEngine.UI;
public class TextBehaviour : MonoBehaviour
{
     public Text myText; // initialize it.
     private int _texNumber = 0;
     
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _texNumber++;
            myText.text = _texNumber.ToString();
            print($"Pressed space- {_texNumber}");
        }else if (Input.GetKeyDown("b"))
        {
            print("User pressed b!");
            myText.text = "Pressed B!";
        }
    }
}
