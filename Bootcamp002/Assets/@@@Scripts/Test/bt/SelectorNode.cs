using System.Collections.Generic;

/* [Selector]
 �ڽ� ��� �߿��� ó������ Success�� Running ���¸� ���� ��� �߻� �� �ߴ� 
 Running -> Running
 Success -> Success
 Failure -> ���� �ڽ� �̵�
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
