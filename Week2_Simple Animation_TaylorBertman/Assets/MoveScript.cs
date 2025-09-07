using TMPro;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public GameObject cameraObj;
    public float moveSpeed = 3;
    public TMP_Text messageText;
    public float hAxisSpeed;
    public float vAxisSpeed;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float Xmove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float Zmove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        //built in feature that maps movement which is get axis horiz (a and d keys) or vertical (w and s keys)
        //we put moveSpeed in there to speed up the movement bc otherwise itll be the default

        transform.position += new Vector3(Xmove, 0, Zmove);

        float vertRot = Input.GetAxis("Mouse Y") * hAxisSpeed * Time.deltaTime;
        float horiRot = Input.GetAxis("Mouse X") * vAxisSpeed * Time.deltaTime;

        cameraObj.transform.Rotate(-vertRot, horiRot, 0);


    

    }
}
