using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid : MonoBehaviour
{
    [SerializeField] private float _power; //威力
    [SerializeField] private int _part; //分割数
    [SerializeField] private GameObject _cubePrefab; //単体アステロイドプレハブ

    private void OnDrawGizmos()
    {
        //ギズモの色を変更
        Gizmos.color = new Color32(145, 244, 139, 210);
        Gizmos.DrawWireCube(transform.position, transform.lossyScale);
    }

    // Start is called before the first frame update
    void Start()
    {
        float s = 1.0f / _part;
        int pHalf = _part / 2;
        var vs = new Vector3(s, s, s);
        float firstPoint = -1 * s * pHalf + ((_part % 2 != 0) ? 0 : s / 2);
        for (float i = firstPoint; i<=s*pHalf; i+=s)
        {
            Debug.Log(i);
            var o = Instantiate(_cubePrefab, new Vector3(0, 0, i),Quaternion.identity, transform);
            o.transform.localScale = vs;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
