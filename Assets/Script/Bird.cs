using UnityEngine;

public class Bird : MonoBehaviour
{
    public void ToggleBird()
    {
        Debug.Log("Toggle the brid please!");
        //gameObject.SetActive(false);
        // gameObject.activeInHierarchy //

        //if bird active, do false
        //<-->
        //    if (gameObject.activeInHierarchy == true)
        //    {
        //        gameObject.SetActive(false);
         //   }
         //   else if (gameObject.activeInHierarchy == false)
         //   {
        //        gameObject.SetActive(true);
         //   }
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
