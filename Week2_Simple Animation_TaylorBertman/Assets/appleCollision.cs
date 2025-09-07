using UnityEngine;

public class appleCollision : MonoBehaviour
{

    public MoveScript moveSpeedUp;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  

    public void OnTriggerEnter(Collider other)
    {
        print("ive been collided with");
        moveSpeedUp.moveSpeed += 2;
        moveSpeedUp.messageText.text="Your current speed is " + moveSpeedUp.moveSpeed.ToString("N0");
        gameObject.SetActive(false);
        
    }

}

