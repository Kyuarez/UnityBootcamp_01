using System;

//���� ��� (�̺�Ʈ �۾�)
// Func() ���� ���� �޾Ƽ� ����.
public sealed class ActionNode : INode
{
    Func<INode.INodeState> _onUpdate = null;

    public ActionNode(Func<INode.INodeState> onUpdate)
    {
        _onUpdate = onUpdate;
    }

    public INode.INodeState Evaluate()
    {
        return _onUpdate?.Invoke() ?? INode.INodeState.Failure;
    }
}
