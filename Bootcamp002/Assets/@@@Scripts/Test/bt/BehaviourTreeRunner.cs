
// 행위 트리 실행 클래스
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
