using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Test());
    }

    // position, localPosition 테스트
    public IEnumerator Test()
    {
        yield return new WaitForSeconds(2f);
        GameObject.Find("WorldObject").transform.position = new Vector2(-2, 0);
        GameObject.Find("ChildObject").transform.position = new Vector2(2, 0);
        Debug.Log("Change position : WorldObject = (-2, 0), ChildObject = (2, 0)");

        yield return new WaitForSeconds(2f);
        GameObject.Find("WorldObject").transform.localPosition = new Vector2(-2, 0);
        GameObject.Find("ChildObject").transform.localPosition = new Vector2(2, 0);
        Debug.Log("Change localPosition : WorldObject = (-2, 0), ChildObject = (2, 0)");

        yield return new WaitForSeconds(2f);
        GameObject.Find("Parent").transform.position = new Vector2(0, 1);
        GameObject.Find("ChildObject").transform.position = new Vector2(2, 0);
        Debug.Log("Change position : Parent = (0, 1), ChildObject = (2, 0)");

        yield return new WaitForSeconds(2f);
        GameObject.Find("Parent").transform.localPosition = new Vector2(0, 1);
        GameObject.Find("ChildObject").transform.localPosition = new Vector2(2, 0);
        Debug.Log("Change localPosition : Parent = (-2, 0), ChildObject = (2, 0)");
    }
}
