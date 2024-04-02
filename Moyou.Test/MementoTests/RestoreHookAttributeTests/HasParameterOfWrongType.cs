﻿using Moyou.Aspects.Memento;

namespace Moyou.CompileTimeTest.MementoTests.RestoreHookAttributeTests;
[Memento]
internal class HasParameterOfWrongType
{
    [MementoCreateHook]
    public void CreateMementoHook(int parameter)
    {
    }

    private record Memento
    {

    }
}
