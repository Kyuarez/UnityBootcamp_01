using System.Collections.Generic;
/*
 SequnceNode :자식 노드를 왼쪽에서 오른쪽 진행하면서 Failure 나올 때까지 진행
 Running -> Running
 Success -> 다음 노드로 이동
 Failure -> Failure
 */
public sealed class SequenceNode : INode
{
    List<INode> _childs;

    public SequenceNode(List<INode> childs)
    {
        _childs = childs;
    }

    public INode.INodeState Evaluate()
    {
        if (_childs == null || _childs.Count == 0)
            return INode.INodeState.Failure;

        foreach (var child in _childs)
        {
            switch (child.Evaluate())
            {
                case INode.INodeState.Running:
                    return INode.INodeState.Running;
                case INode.INodeState.Success:
                    continue;
                case INode.INodeState.Failure:
                    return INode.INodeState.Failure;
            }
        }

        return INode.INodeState.Success;
    }
}
