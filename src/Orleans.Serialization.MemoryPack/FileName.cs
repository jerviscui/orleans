using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryPack;

namespace Orleans.Serialization.MemoryPack;

[MemoryPackable]
public sealed partial record MyMessagePackClass
{
    [MemoryPackOrder(0)]
    public int IntProperty { get; set; }

    [MemoryPackOrder(1)]
    public string StringProperty { get; set; }

    [MemoryPackOrder(2)]
    public MyMessagePackSubClass SubClass { get; set; }

    [MemoryPackOrder(3)]
    public IMyMessagePackUnion Union { get; set; }
}

[MemoryPackable]
public sealed partial record MyMessagePackSubClass
{
    [MemoryPackOrder(0)]
    public Guid Id { get; set; }
}

[MemoryPackable]
[MemoryPackUnion(0, typeof(MyMessagePackUnionVariant1))]
[MemoryPackUnion(1, typeof(MyMessagePackUnionVariant2))]
public interface IMyMessagePackUnion
{
}

[MemoryPackable]
public sealed partial record MyMessagePackUnionVariant1 : IMyMessagePackUnion
{
    [MemoryPackOrder(0)]
    public int IntProperty { get; set; }
}

[MemoryPackable]
public sealed partial record MyMessagePackUnionVariant2 : IMyMessagePackUnion
{
    [MemoryPackOrder(0)]
    public string StringProperty { get; set; }
}
