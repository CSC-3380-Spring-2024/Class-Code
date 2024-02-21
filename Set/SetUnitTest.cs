namespace Set;
using Node;

[TestFixture]
public class StringTests
{

    Set<string> emptyString;
    Set<string> StringSet1;
    Set<string> StringSet2;
    Set<string> IntersectString;
    Set<string> UnionString;
    Set<string> SubtractString;
    Set<string> AddString;

    [SetUp]
    public void CreateSets()
    {
        emptyString = new Set<string>();
        StringSet1 = new Set<string>(["abba", "breakfast", "charlie", "great", "zebra"]);
        StringSet2 = new Set<string>(["breakfast", "delta", "united", "zebra"]);
        IntersectString = new Set<string>(["breakfast", "zebra"]);
        UnionString = new Set<string>(["abba", "breakfast", "charlie", "delta", "great", "united", "zebra"]);
        SubtractString = new Set<string>(["abba", "charlie", "great"]);
        AddString = new Set<string>(["abba", "breakfast", "charlie", "great", "hello", "zebra"]);
    }


    [Test]
    public void TestSetIndex()
    {
        Assert.True(StringSet1[3] == "great");
    }

    [Test]
    public void TestSetAdd()
    {
        Assert.True((StringSet1 + "hello") == AddString);
    }

    [Test]
    public void TestSetSubtract()
    {
        Assert.True((StringSet1 - StringSet2) == SubtractString);
    }

    [Test]
    public void TestSetUnion()
    {
        Assert.True((StringSet1 | StringSet2) == UnionString);
    }

    [Test]
    public void TestSetIntersect()
    {
        Assert.True((StringSet1 & StringSet2) == IntersectString);
    }

    [Test]
    public void TestSetEmptiness()
    {
        Assert.NotNull(emptyString);
        if(emptyString){
            Assert.Fail();
        }
        else{
            Assert.Pass();
        }
    }


    [Test]
    public void TestSetHasSomething()
    {
        Assert.NotNull(StringSet1);
        if(StringSet1){
            Assert.Pass();
        }
        else{
            Assert.Fail();
        }
    }
}

[TestFixture]
public class IntTests
{

    Set<int> emptyInt;
    Set<int> IntSet1;
    Set<int> IntSet2;
    Set<int> IntersectInt;
    Set<int> UnionInt;
    Set<int> SubtractInt;
    Set<int> AddInt;

    [SetUp]
    public void CreateSets()
    {
        emptyInt = new Set<int>();
        IntSet1 = new Set<int>([2, 4, 5, 7, 12, 13]);
        IntSet2 = new Set<int>([1, 3, 6, 8, 11, 12]);
        IntersectInt = new Set<int>([12]);
        UnionInt = new Set<int>([1, 2, 3, 4, 5, 6, 7, 8, 11, 12, 13]);
        SubtractInt = new Set<int>([2, 4, 5, 7, 13]);
        AddInt = new Set<int>([2, 4, 5, 7, 9, 12, 13]);
    }


    [Test]
    public void TestSetIndex()
    {
        Assert.True(IntSet1[3] == 7);
    }

    [Test]
    public void TestSetAdd()
    {
        Assert.True((IntSet1 + 9) == AddInt);
    }

    [Test]
    public void TestSetSubtract()
    {
        Assert.True((IntSet1 - IntSet2) == SubtractInt);
    }

    [Test]
    public void TestSetUnion()
    {
        Assert.True((IntSet1 | IntSet2) == UnionInt);
    }

    [Test]
    public void TestSetIntersect()
    {
        Assert.True((IntSet1 & IntSet2) == IntersectInt);
    }

    [Test]
    public void TestSetEmptiness()
    {
        Assert.NotNull(emptyInt);
        if(emptyInt){
            Assert.Fail();
        }
        else{
            Assert.Pass();
        }
    }


    [Test]
    public void TestSetHasSomething()
    {
        Assert.NotNull(IntSet1);
        if(IntSet1){
            Assert.Pass();
        }
        else{
            Assert.Fail();
        }
    }
}

[TestFixture]
public class DoubleTests
{

    Set<double> emptyDouble;
    Set<double> DoubleSet1;
    Set<double> DoubleSet2;
    Set<double> IntersectDouble;
    Set<double> UnionDouble;
    Set<double> SubtractDouble;
    Set<double> AddDouble;

    [SetUp]
    public void CreateSets()
    {
        emptyDouble = new Set<double>();
        DoubleSet1 = new Set<double>([3.4, 3.7, 4.9, 5.0, 5.7, 8.0]);
        DoubleSet2 = new Set<double>([4.9, 5.0, 8.0, 9.4, 11.6]);
        IntersectDouble = new Set<double>([4.9, 5.0, 8.0]);
        UnionDouble = new Set<double>([3.4, 3.7, 4.9, 5.0, 5.7, 8.0, 9.4, 11.6]);
        SubtractDouble = new Set<double>([3.4, 3.7, 5.7]);
        AddDouble = new Set<double>([3.4, 3.7, 4.9, 5.0, 5.7, 7.6, 8.0]);
    }


    [Test]
    public void TestSetIndex()
    {
        Assert.True(DoubleSet1[3] == 5.0);
    }

    [Test]
    public void TestSetAdd()
    {
        Assert.True((DoubleSet1 + 7.6) == AddDouble);
    }

    [Test]
    public void TestSetSubtract()
    {
        Assert.True((DoubleSet1 - DoubleSet2) == SubtractDouble);
    }

    [Test]
    public void TestSetUnion()
    {
        Assert.True((DoubleSet1 | DoubleSet2) == UnionDouble);
    }

    [Test]
    public void TestSetIntersect()
    {
        Assert.True((DoubleSet1 & DoubleSet2) == IntersectDouble);
    }

    [Test]
    public void TestSetEmptiness()
    {
        Assert.NotNull(emptyDouble);
        if(emptyDouble){
            Assert.Fail();
        }
        else{
            Assert.Pass();
        }
    }


    [Test]
    public void TestSetHasSomething()
    {
        Assert.NotNull(DoubleSet1);
        if(DoubleSet1){
            Assert.Pass();
        }
        else{
            Assert.Fail();
        }
    }
}

[TestFixture]
public class NodeTests
{

    Set<Node> emptyNode;
    Set<Node> NodeSet1;
    Set<Node> NodeSet2;
    Set<Node> IntersectNode;
    Set<Node> UnionNode;
    Set<Node> SubtractNode;
    Set<Node> AddNode;

    [SetUp]
    public void CreateSets()
    {
        emptyNode = new Set<Node>();
        NodeSet1 = new Set<Node>([new Node(1),new Node(2),new Node(3),new Node(4),new Node(5),new Node(6)]);
        NodeSet2 = new Set<Node>([new Node(1),new Node(3),new Node(5),new Node(7)]);
        IntersectNode = new Set<Node>([new Node(1),new Node(3),new Node(5)]);
        UnionNode = new Set<Node>([new Node(1),new Node(2),new Node(3),new Node(4),new Node(5),new Node(6),new Node(7)]);
        SubtractNode = new Set<Node>([new Node(2),new Node(4),new Node(6)]);
        AddNode = new Set<Node>([new Node(1),new Node(2),new Node(3),new Node(4),new Node(5),new Node(6),new Node(9)]);
    }


    [Test]
    public void TestSetIndex()
    {
        Assert.True(NodeSet1[3] == new Node(4));
    }

    [Test]
    public void TestSetAdd()
    {
        Assert.True((NodeSet1 + new Node(9)) == AddNode);
    }

    [Test]
    public void TestSetSubtract()
    {
        Assert.True((NodeSet1 - NodeSet2) == SubtractNode);
    }

    [Test]
    public void TestSetUnion()
    {
        Assert.True((NodeSet1 | NodeSet2) == UnionNode);
    }

    [Test]
    public void TestSetIntersect()
    {
        Assert.True((NodeSet1 & NodeSet2) == IntersectNode);
    }

    [Test]
    public void TestSetEmptiness()
    {
        Assert.NotNull(emptyNode);
        if(emptyNode){
            Assert.Fail();
        }
        else{
            Assert.Pass();
        }
    }


    [Test]
    public void TestSetHasSomething()
    {
        Assert.NotNull(NodeSet1);
        if(NodeSet1){
            Assert.Pass();
        }
        else{
            Assert.Fail();
        }
    }
    [Test]
    public void TestSetSubset()
    {
        Assert.True(NodeSet1 > IntersectNode);
        Assert.False(NodeSet1 < IntersectNode);
        Assert.True(NodeSet1 < UnionNode);
        Assert.False(NodeSet1 > UnionNode);
    }

}