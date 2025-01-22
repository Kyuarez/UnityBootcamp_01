using UnityEngine;
using System.Collections.Generic;


public class EnemyAI : MonoBehaviour
{
    BehaviourTreeRunner _BTRunner;

    private void Awake()
    {
        _BTRunner = new BehaviourTreeRunner(SettingBT());
    }

    private void Update()
    {
        _BTRunner.Operator();
    }

    INode SettingBT()
    {
        return new SelectorNode(new List<INode>()
        {

        });
    }
}
