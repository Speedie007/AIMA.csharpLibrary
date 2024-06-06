using AIMA.CSharpLibrary.Agent.AgentComponents;
using AIMA.CSharpLibrary.SearchAlgorithms.SearchComponents;

namespace AIMA.csharp.Tests
{
    [TestFixture]
    public class Tests
    {
        public static string AGENT_LOCATION = "location";
        private List<Node<AgentState, AgentAction>> ListOfNodes;
        [SetUp]
        public void Setup()
        {
            AgentState state = new AgentState();
            state.SetDynamicAttributeValue(AGENT_LOCATION, "Location_1");

            AgentAction MoveUpAction = new AgentAction("MOVE_Up");
            AgentAction MoveLeftAction = new AgentAction("MOVE_Left");
            AgentAction MoveDownAction = new AgentAction("MOVE_Down");
            AgentAction MoveRightAction = new AgentAction("MOVE_Right");

            //var node = new Node<DynamicState,BaseAgentAction>("");
            ListOfNodes = new List<Node<AgentState, AgentAction>>() {

                new Node<AgentState, AgentAction>(state,null,MoveUpAction,5),
                new Node<AgentState, AgentAction>(state,null,MoveDownAction,5),
                new Node<AgentState, AgentAction>(state,null,MoveRightAction,5),
                new Node<AgentState, AgentAction>(state,null,MoveLeftAction,5)
            };
        }

        [Test]
        public void Test1()
        {
            var q = new FontierFIFOQueue<Node<AgentState,AgentAction>,AgentState,AgentAction>();
            Assert.Pass();
        }
    }
}