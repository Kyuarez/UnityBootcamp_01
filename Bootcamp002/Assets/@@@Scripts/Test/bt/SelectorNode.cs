using System.Collections.Generic;

/* [Selector]
 자식 노드 중에서 처음으로 Success나 Running 상태를 가진 노드 발생 시 중단 
 Running -> Running
 Success -> Success
 Failure -> 다음 자식 이동
 */
public sealed class SelectorNode : INode
{
    List<INode> _childs;

    public SelectorNode(List<INode> childs)
    {
        _childs = childs;
    } 

    public INode.INodeState Evaluate()
    {
        if (_childs == null)
            return INode.INodeState.Failure;

        foreach (var child in _childs)
        {
            switch (child.Evaluate())
            {
                case INode.INodeState.Running:
                    return INode.INodeState.Running;
                case INode.INodeState.Success:
                    return INode.INodeState.Success;
            }
        }

        return INode.INodeState.Failure;
    }
}
