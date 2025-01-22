using System;

//실제 노드 (이벤트 작업)
// Func() 값을 전달 받아서 실행.
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
