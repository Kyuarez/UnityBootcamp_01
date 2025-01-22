
// ���� Ʈ�� ���� Ŭ����
// root -> selector -> sequences
public class BehaviourTreeRunner
{
    INode _rootNode;
    
    public BehaviourTreeRunner(INode rootNode)
    {
        _rootNode = rootNode;
    }

    public void Operator()
    {
        _rootNode.Evaluate();
    }
}
