﻿using Moyou.Aspects.Memento;

namespace Moyou.UnitTest.Memento;

[Memento]
internal partial class MementoDummy
{
    public int A { get; set; }
    private string B { get; set; }
    internal string? C { get; init; }

    public int D;
    private object _e;

    public object E { get => _e; set => _e = value; }

    [MementoIgnore]
    public int F { get; set; }
    public int G { get; }
    public int H { get => 123; }
    public int I => 123;
    protected readonly object _j;
    public readonly object K;
    public List<object> L { get; set; }

    public CloneableDummy M { get; set; }
    public IDictionary<int,int> N { get; set; }


    private record Memento
    {

    }
}

public class CloneableDummy : ICloneable
{
    public int Foo { get; set; }
    public object Clone()
    {
        return new CloneableDummy
        {
            Foo = Foo
        };
    }
}
