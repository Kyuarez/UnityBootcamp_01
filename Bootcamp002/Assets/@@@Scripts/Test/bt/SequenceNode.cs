using System.Collections.Generic;
/*
 SequnceNode :�ڽ� ��带 ���ʿ��� ������ �����ϸ鼭 Failure ���� ������ ����
 Running -> Running
 Success -> ���� ���� �̵�
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
