#pragma warning disable CS1591, RS0016, RS0041
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization.UnitTests")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization.FSharp")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization.MemoryPack")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization.MessagePack")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization.NewtonsoftJson")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization.Protobuf")]
[assembly: global::Orleans.ApplicationPartAttribute("Orleans.Serialization.SystemTextJson")]
[assembly: global::Orleans.Serialization.Configuration.TypeManifestProviderAttribute(typeof(OrleansCodeGen.OrleansSerializationUnitTests.Metadata_OrleansSerializationUnitTests))]
namespace OrleansCodeGen.Orleans.Serialization.UnitTests
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_my_interface : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.IMyInvokableBaseType
    {
        public Proxy_my_interface(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "125")]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "E8B1F331")]
    public sealed class Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 : global::Orleans.Serialization.Invocation.UnitTestRequest
    {
        global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "Method", null, null);
        public override string GetMethodName() => "Method";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IProxyAliasTestGrain";
        public override string GetActivityName() => "IProxyAliasTestGrain/Method";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            _target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => _target.Method();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "Method")]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "5C35143D")]
    public sealed class Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D : global::Orleans.Serialization.Invocation.UnitTestRequest
    {
        public int arg0;
        global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "Method", null, new[] { typeof(int) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Method";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IProxyAliasTestGrain";
        public override string GetActivityName() => "IProxyAliasTestGrain/Method";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => _target.Method(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "StringMethod")]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "140733F1")]
    public sealed class Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 : global::Orleans.Serialization.Invocation.UnitTestRequest
    {
        public string arg0;
        global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "Method", null, new[] { typeof(string) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Method";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IProxyAliasTestGrain";
        public override string GetActivityName() => "IProxyAliasTestGrain/Method";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (string)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => _target.Method(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "MyOtherMethod")]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "FFED2C55")]
    public sealed class Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 : global::Orleans.Serialization.Invocation.UnitTestRequest
    {
        global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain), "OtherMethod", null, null);
        public override string GetMethodName() => "OtherMethod";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IProxyAliasTestGrain";
        public override string GetActivityName() => "IProxyAliasTestGrain/OtherMethod";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            _target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => _target.OtherMethod();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy__proxy_alias_test_ : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain
    {
        public Proxy__proxy_alias_test_(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain.Method()
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331();
            return base.InvokeAsync(request);
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain.Method(int arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D();
            request.arg0 = arg0;
            return base.InvokeAsync(request);
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain.Method(string arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1();
            request.arg0 = arg0;
            return base.InvokeAsync(request);
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain.OtherMethod()
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55();
            return base.InvokeAsync(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<,, >), "777")]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<,, >), "E150EAD8")]
    public sealed class Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> : global::Orleans.Serialization.Invocation.UnitTestRequest
    {
        global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<T, U, V> _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<T, U, V>), "Method", new[] { typeof(W), typeof(X), typeof(Y) }, null);
        public override string GetMethodName() => "Method<W, X, Y>";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<T,U,V>";
        public override string GetActivityName() => "IGenericProxyAliasTestGrain<T,U,V>/Method<W, X, Y>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<T, U, V>);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<T, U, V>>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            _target = default;
        }

        protected override global::System.Threading.Tasks.ValueTask InvokeInner() => _target.Method<W, X, Y>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_test_IGenericProxyAliasTestGrain_3<T, U, V> : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<T, U, V>
    {
        public Proxy_test_IGenericProxyAliasTestGrain_3(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.ValueTask global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<T, U, V>.Method<W, X, Y>()
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y>();
            return base.InvokeAsync(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_IG2<T1, T2> : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.IG2<T1, T2>
    {
        public Proxy_IG2(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_IG<T> : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.IG<T>
    {
        public Proxy_IG(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "897D5539")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>
    {
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "GetTypesExplicit", new[] { typeof(T), typeof(U), typeof(V) }, null);
        public override string GetMethodName() => "GetTypesExplicit<T, U, V>";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/GetTypesExplicit<T, U, V>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            _target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::System.Type[]> InvokeInner() => _target.GetTypesExplicit<T, U, V>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "4A2D8354")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>
    {
        public T arg0;
        public U arg1;
        public V arg2;
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "GetTypesInferred", new[] { typeof(T), typeof(U), typeof(V) }, new[] { typeof(T), typeof(U), typeof(V) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "GetTypesInferred<T, U, V>";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/GetTypesInferred<T, U, V>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                case 2:
                    return arg2;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (T)value;
                    return;
                case 1:
                    arg1 = (U)value;
                    return;
                case 2:
                    arg2 = (V)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Type[]> InvokeInner() => _target.GetTypesInferred<T, U, V>(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "2CE0CA54")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>
    {
        public T arg0;
        public U arg1;
        public global::System.Int32 arg2;
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "GetTypesInferred", new[] { typeof(T), typeof(U) }, new[] { typeof(T), typeof(U), typeof(global::System.Int32) });
        public override int GetArgumentCount() => 3;
        public override string GetMethodName() => "GetTypesInferred<T, U>";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/GetTypesInferred<T, U>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            arg1 = default;
            arg2 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                case 1:
                    return arg1;
                case 2:
                    return arg2;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (T)value;
                    return;
                case 1:
                    arg1 = (U)value;
                    return;
                case 2:
                    arg2 = (global::System.Int32)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 2);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<global::System.Type[]> InvokeInner() => _target.GetTypesInferred<T, U>(arg0, arg1, arg2);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "C62BC31B")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>
    {
        public T arg0;
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "RoundTrip", new[] { typeof(T) }, new[] { typeof(T) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "RoundTrip<T>";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/RoundTrip<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (T)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<T> InvokeInner() => _target.RoundTrip<T>(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "60E98DC2")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>
    {
        public int arg0;
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "RoundTrip", null, new[] { typeof(int) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "RoundTrip";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/RoundTrip";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (int)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<int> InvokeInner() => _target.RoundTrip(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "CA65C468")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>
    {
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "Default", new[] { typeof(T) }, null);
        public override string GetMethodName() => "Default<T>";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/Default<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            _target = default;
        }

        protected override global::System.Threading.Tasks.Task<T> InvokeInner() => _target.Default<T>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "EA8E38D2")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<string>
    {
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "Default", null, null);
        public override string GetMethodName() => "Default";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/Default";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            _target = default;
        }

        protected override global::System.Threading.Tasks.Task<string> InvokeInner() => _target.Default();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "48553A94")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TGrain> where TGrain : global::Orleans.Serialization.UnitTests.IMyInvokableBaseType
    {
        public TGrain arg0;
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "Constraints", new[] { typeof(TGrain) }, new[] { typeof(TGrain) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Constraints<TGrain>";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/Constraints<TGrain>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (TGrain)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<TGrain> InvokeInner() => _target.Constraints<TGrain>(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "7AA6BCD7")]
    public sealed class Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 : global::Orleans.Serialization.Invocation.UnitTestRequest<int>
    {
        public bool arg0;
        global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods), "ValueTaskMethod", null, new[] { typeof(bool) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "ValueTaskMethod";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGrainWithGenericMethods";
        public override string GetActivityName() => "IGrainWithGenericMethods/ValueTaskMethod";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (bool)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.ValueTask<int> InvokeInner() => _target.ValueTaskMethod(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_IGrainWithGenericMethods : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods
    {
        public Proxy_IGrainWithGenericMethods(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
        }

        global::System.Threading.Tasks.Task<global::System.Type[]> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.GetTypesExplicit<T, U, V>()
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V>();
            return base.InvokeAsync<global::System.Type[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Type[]> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.GetTypesInferred<T, U, V>(T arg0, U arg1, V arg2)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V>();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = copyContext.DeepCopy(arg0);
            request.arg1 = copyContext.DeepCopy(arg1);
            request.arg2 = copyContext.DeepCopy(arg2);
            return base.InvokeAsync<global::System.Type[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::System.Type[]> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.GetTypesInferred<T, U>(T arg0, U arg1, global::System.Int32 arg2)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U>();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = copyContext.DeepCopy(arg0);
            request.arg1 = copyContext.DeepCopy(arg1);
            request.arg2 = arg2;
            return base.InvokeAsync<global::System.Type[]>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<T> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.RoundTrip<T>(T arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T>();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = copyContext.DeepCopy(arg0);
            return base.InvokeAsync<T>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<int> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.RoundTrip(int arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2();
            request.arg0 = arg0;
            return base.InvokeAsync<int>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<T> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.Default<T>()
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T>();
            return base.InvokeAsync<T>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<string> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.Default()
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2();
            return base.InvokeAsync<string>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<TGrain> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.Constraints<TGrain>(TGrain arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain>();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = copyContext.DeepCopy(arg0);
            return base.InvokeAsync<TGrain>(request).AsTask();
        }

        global::System.Threading.Tasks.ValueTask<int> global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods.ValueTaskMethod(bool arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7();
            request.arg0 = arg0;
            return base.InvokeAsync<int>(request);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<>), "750C249C")]
    public sealed class Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>
    {
        public T arg0;
        global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T> _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>), "Method", null, new[] { typeof(T) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Method";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>";
        public override string GetActivityName() => "IGenericGrainWithGenericMethods<T>/Method";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (T)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<T> InvokeInner() => _target.Method(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<>), "2C5E9318")]
    public sealed class Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T_1>
    {
        public T_1 arg0;
        global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T> _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>), "Method", new[] { typeof(T_1) }, new[] { typeof(T_1) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Method<T>";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>";
        public override string GetActivityName() => "IGenericGrainWithGenericMethods<T>/Method<T>";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (T_1)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<T_1> InvokeInner() => _target.Method<T_1>(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_IGenericGrainWithGenericMethods<T> : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        public Proxy_IGenericGrainWithGenericMethods(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task<T> global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>.Method(T arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T>();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<T>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<T_1> global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<T>.Method<T_1>(T_1 arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1>();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = copyContext.DeepCopy(arg0);
            return base.InvokeAsync<T_1>(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<>), "D3CF5E24")]
    public sealed class Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>
    {
        public T arg0;
        global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T> _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>), "SetState", null, new[] { typeof(T) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "SetState";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>";
        public override string GetActivityName() => "IRuntimeCodeGenGrain<T>/SetState";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (T)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<T> InvokeInner() => _target.SetState(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<>), "F9B2D902")]
    public sealed class Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::Orleans.Serialization.UnitTests.@event>
    {
        global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T> _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>), "static", null, null);
        public override string GetMethodName() => "@static";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>";
        public override string GetActivityName() => "IRuntimeCodeGenGrain<T>/@static";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            _target = default;
        }

        protected override global::System.Threading.Tasks.Task<global::Orleans.Serialization.UnitTests.@event> InvokeInner() => _target.@static();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_IRuntimeCodeGenGrain<T> : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        public Proxy_IRuntimeCodeGenGrain(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task<T> global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>.SetState(T arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T>();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<T>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<global::Orleans.Serialization.UnitTests.@event> global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<T>.@static()
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T>();
            return base.InvokeAsync<global::Orleans.Serialization.UnitTests.@event>(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.INestedGenericGrain), "5EE6D1DA")]
    public sealed class Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>
    {
        public global::Orleans.Serialization.UnitTests.NestedGeneric<int> arg0;
        global::Orleans.Serialization.UnitTests.INestedGenericGrain _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.INestedGenericGrain), "Do", null, new[] { typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<int>) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Do";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.INestedGenericGrain";
        public override string GetActivityName() => "INestedGenericGrain/Do";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.INestedGenericGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.INestedGenericGrain>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Serialization.UnitTests.NestedGeneric<int>)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<int> InvokeInner() => _target.Do(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    [global::Orleans.CompoundTypeAliasAttribute("inv", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase), typeof(global::Orleans.Serialization.UnitTests.INestedGenericGrain), "C878BCCA")]
    public sealed class Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA : global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>
    {
        public global::Orleans.Serialization.UnitTests.NestedConstructedGeneric arg0;
        global::Orleans.Serialization.UnitTests.INestedGenericGrain _target;
        private static readonly global::System.Reflection.MethodInfo MethodBackingField = OrleansGeneratedCodeHelper.GetMethodInfoOrDefault(typeof(global::Orleans.Serialization.UnitTests.INestedGenericGrain), "Do", null, new[] { typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric) });
        public override int GetArgumentCount() => 1;
        public override string GetMethodName() => "Do";
        public override string GetInterfaceName() => "Orleans.Serialization.UnitTests.INestedGenericGrain";
        public override string GetActivityName() => "INestedGenericGrain/Do";
        public override global::System.Type GetInterfaceType() => typeof(global::Orleans.Serialization.UnitTests.INestedGenericGrain);
        public override global::System.Reflection.MethodInfo GetMethod() => MethodBackingField;
        public override void SetTarget(global::Orleans.Serialization.Invocation.ITargetHolder holder) => _target = holder.GetTarget<global::Orleans.Serialization.UnitTests.INestedGenericGrain>();
        public override object GetTarget() => _target;
        public override void Dispose()
        {
            arg0 = default;
            _target = default;
        }

        public override object GetArgument(int index)
        {
            switch (index)
            {
                case 0:
                    return arg0;
                default:
                    return OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
            }
        }

        public override void SetArgument(int index, object value)
        {
            switch (index)
            {
                case 0:
                    arg0 = (global::Orleans.Serialization.UnitTests.NestedConstructedGeneric)value;
                    return;
                default:
                    OrleansGeneratedCodeHelper.InvokableThrowArgumentOutOfRange(index, 0);
                    return;
            }
        }

        protected override global::System.Threading.Tasks.Task<int> InvokeInner() => _target.Do(arg0);
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_INestedGenericGrain : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.INestedGenericGrain
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedGeneric<int> _copier0;
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedConstructedGeneric _copier1;
        public Proxy_INestedGenericGrain(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedGeneric<int>>(this, CodecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedConstructedGeneric>(this, CodecProvider);
        }

        global::System.Threading.Tasks.Task<int> global::Orleans.Serialization.UnitTests.INestedGenericGrain.Do(global::Orleans.Serialization.UnitTests.NestedGeneric<int> arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier0.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<int>(request).AsTask();
        }

        global::System.Threading.Tasks.Task<int> global::Orleans.Serialization.UnitTests.INestedGenericGrain.Do(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric arg0)
        {
            var request = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA();
            using var copyContext = base.CopyContextPool.GetContext();
            request.arg0 = _copier1.DeepCopy(arg0, copyContext);
            return base.InvokeAsync<int>(request).AsTask();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyEnum : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyEnum>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MyEnum);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MyEnum @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int16Codec.WriteField(ref writer, fieldIdDelta, expectedType, (short)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyEnum ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Serialization.UnitTests.MyEnum)global::Orleans.Serialization.Codecs.Int16Codec.ReadValue(ref reader, field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_TypeWithListBase : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.TypeWithListBase>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.TypeWithListBase>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.TypeWithListBase);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.List<int>> _baseTypeSerializer;
        public Codec_TypeWithListBase(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.List<int>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.TypeWithListBase instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.OtherProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.TypeWithListBase instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.OtherProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.TypeWithListBase @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.TypeWithListBase))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TypeWithListBase ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.TypeWithListBase, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.TypeWithListBase();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.TypeWithListBase>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_TypeWithListBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.TypeWithListBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.TypeWithListBase>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.List<int>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TypeWithListBase DeepCopy(global::Orleans.Serialization.UnitTests.TypeWithListBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.TypeWithListBase existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.TypeWithListBase))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.TypeWithListBase();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_TypeWithListBase(global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.List<int>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.TypeWithListBase input, global::Orleans.Serialization.UnitTests.TypeWithListBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.OtherProperty = input.OtherProperty;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_TypeWithListBase : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.TypeWithListBase>
    {
        public global::Orleans.Serialization.UnitTests.TypeWithListBase Create() => new global::Orleans.Serialization.UnitTests.TypeWithListBase();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_TypeWithCollectionBase : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.TypeWithCollectionBase>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.TypeWithCollectionBase>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.TypeWithCollectionBase);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.ObjectModel.Collection<int>> _baseTypeSerializer;
        public Codec_TypeWithCollectionBase(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.ObjectModel.Collection<int>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.TypeWithCollectionBase instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.OtherProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.TypeWithCollectionBase instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.OtherProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.TypeWithCollectionBase @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.TypeWithCollectionBase))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TypeWithCollectionBase ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.TypeWithCollectionBase, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.TypeWithCollectionBase();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.TypeWithCollectionBase>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_TypeWithCollectionBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.TypeWithCollectionBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.TypeWithCollectionBase>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.ObjectModel.Collection<int>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TypeWithCollectionBase DeepCopy(global::Orleans.Serialization.UnitTests.TypeWithCollectionBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.TypeWithCollectionBase existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.TypeWithCollectionBase))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.TypeWithCollectionBase();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_TypeWithCollectionBase(global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.ObjectModel.Collection<int>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.TypeWithCollectionBase input, global::Orleans.Serialization.UnitTests.TypeWithCollectionBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.OtherProperty = input.OtherProperty;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_TypeWithCollectionBase : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.TypeWithCollectionBase>
    {
        public global::Orleans.Serialization.UnitTests.TypeWithCollectionBase Create() => new global::Orleans.Serialization.UnitTests.TypeWithCollectionBase();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_TypeWithDictionaryBase : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.Dictionary<string, int>> _baseTypeSerializer;
        public Codec_TypeWithDictionaryBase(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.Dictionary<string, int>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.OtherProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.OtherProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_TypeWithDictionaryBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.Dictionary<string, int>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase DeepCopy(global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_TypeWithDictionaryBase(global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.Dictionary<string, int>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase input, global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.OtherProperty = input.OtherProperty;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_TypeWithDictionaryBase : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase>
    {
        public global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase Create() => new global::Orleans.Serialization.UnitTests.TypeWithDictionaryBase();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_TypeWithHashSetBase : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.TypeWithHashSetBase>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.TypeWithHashSetBase>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.TypeWithHashSetBase);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.HashSet<string>> _baseTypeSerializer;
        public Codec_TypeWithHashSetBase(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.HashSet<string>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.TypeWithHashSetBase instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.OtherProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.TypeWithHashSetBase instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.OtherProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.TypeWithHashSetBase @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.TypeWithHashSetBase))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TypeWithHashSetBase ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.TypeWithHashSetBase, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.TypeWithHashSetBase();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.TypeWithHashSetBase>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_TypeWithHashSetBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.TypeWithHashSetBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.TypeWithHashSetBase>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.HashSet<string>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TypeWithHashSetBase DeepCopy(global::Orleans.Serialization.UnitTests.TypeWithHashSetBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.TypeWithHashSetBase existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.TypeWithHashSetBase))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.TypeWithHashSetBase();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_TypeWithHashSetBase(global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.HashSet<string>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.TypeWithHashSetBase input, global::Orleans.Serialization.UnitTests.TypeWithHashSetBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.OtherProperty = input.OtherProperty;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_TypeWithHashSetBase : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.TypeWithHashSetBase>
    {
        public global::Orleans.Serialization.UnitTests.TypeWithHashSetBase Create() => new global::Orleans.Serialization.UnitTests.TypeWithHashSetBase();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Codec_Base<T> : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.UnitTests.Base<T>>
    {
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Copier_Base<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.Base<T>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.Base<T>>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.Base<T> DeepCopy(global::Orleans.Serialization.UnitTests.Base<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.Base<T> input, global::Orleans.Serialization.UnitTests.Base<T> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331);
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest _baseTypeSerializer;
        public Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331();
            _baseTypeCopier.DeepCopy(original, result, context);
            return result;
        }

        public Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D);
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest _baseTypeSerializer;
        public Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            return result;
        }

        public Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1);
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest _baseTypeSerializer;
        public Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            return result;
        }

        public Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55);
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest _baseTypeSerializer;
        public Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55();
            _baseTypeCopier.DeepCopy(original, result, context);
            return result;
        }

        public Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y>);
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest _baseTypeSerializer;
        public Codec_Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y>>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<T, U, V, W, X, Y>();
            _baseTypeCopier.DeepCopy(original, result, context);
            return result;
        }

        public Copier_Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeSerializer;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<T, U, V>();
            _baseTypeCopier.DeepCopy(original, result, context);
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        private readonly global::System.Type _type1 = typeof(U);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<U> _codec1;
        private readonly global::System.Type _type2 = typeof(V);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<V> _codec2;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<U>>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<V>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
            _codec2.WriteField(ref writer, 1U, _type2, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<U> _copier1;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<V> _copier2;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<T, U, V>();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            result.arg1 = _copier1.DeepCopy(original.arg1, context);
            result.arg2 = _copier2.DeepCopy(original.arg2, context);
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<U>>(this, codecProvider);
            _copier2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<V>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        private readonly global::System.Type _type1 = typeof(U);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<U> _codec1;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<U>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
            _codec1.WriteField(ref writer, 1U, _type1, instance.arg1);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.arg2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.arg1 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.arg2 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<U> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<T, U>();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            result.arg1 = _copier1.DeepCopy(original.arg1, context);
            result.arg2 = original.arg2;
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::System.Type[]>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<U>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<T>();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeSerializer;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeSerializer;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<T>();
            _baseTypeCopier.DeepCopy(original, result, context);
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<string>> _baseTypeSerializer;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<string>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<string>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2();
            _baseTypeCopier.DeepCopy(original, result, context);
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<string>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain>> where TGrain : global::Orleans.Serialization.UnitTests.IMyInvokableBaseType
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TGrain>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(TGrain);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<TGrain> _codec0;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TGrain>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<TGrain>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain>> where TGrain : global::Orleans.Serialization.UnitTests.IMyInvokableBaseType
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TGrain>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<TGrain> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<TGrain>();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TGrain>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<TGrain>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestRequest<int>> _baseTypeSerializer;
        public Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestRequest<int>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.BoolCodec.WriteField(ref writer, 0U, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = global::Orleans.Serialization.Codecs.BoolCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestRequest<int>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = original.arg0;
            return result;
        }

        public Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestRequest<int>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<T>();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T_1>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(T_1);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T_1> _codec0;
        public Codec_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T_1>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T_1>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T_1>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T_1> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<T, T_1>();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T_1>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T_1>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<T>();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<T>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::Orleans.Serialization.UnitTests.@event>> _baseTypeSerializer;
        public Codec_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::Orleans.Serialization.UnitTests.@event>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T>();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::Orleans.Serialization.UnitTests.@event>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<T>();
            _baseTypeCopier.DeepCopy(original, result, context);
            return result;
        }

        public Copier_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<global::Orleans.Serialization.UnitTests.@event>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_GenericGrainState<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.GenericGrainState<T>>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.GenericGrainState<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.GenericGrainState<T>);
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_GenericGrainState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.GenericGrainState<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 1U, _type0, instance.@event);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.GenericGrainState<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 1U)
                {
                    instance.@event = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.GenericGrainState<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.GenericGrainState<T>))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.GenericGrainState<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.GenericGrainState<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.GenericGrainState<T>();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.GenericGrainState<T>>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_GenericGrainState<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.GenericGrainState<T>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.GenericGrainState<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.GenericGrainState<T> DeepCopy(global::Orleans.Serialization.UnitTests.GenericGrainState<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.GenericGrainState<T> existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.GenericGrainState<T>))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.GenericGrainState<T>();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_GenericGrainState(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.GenericGrainState<T> input, global::Orleans.Serialization.UnitTests.GenericGrainState<T> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.@event = _copier0.DeepCopy(input.@event, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_GenericGrainState<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.GenericGrainState<T>>
    {
        public global::Orleans.Serialization.UnitTests.GenericGrainState<T> Create() => new global::Orleans.Serialization.UnitTests.GenericGrainState<T>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_event : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.@event>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.@event>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.@event);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.@event.@enum);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.@event.@enum> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<global::Orleans.Serialization.UnitTests.@event>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Serialization.UnitTests.@event> _codec1;
        private readonly global::System.Type _type2 = typeof(global::Orleans.Serialization.UnitTests.@event);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_event _codec2;
        private static readonly global::System.Func<global::Orleans.Serialization.UnitTests.@event, global::System.Guid> getField4 = (global::System.Func<global::Orleans.Serialization.UnitTests.@event, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Serialization.UnitTests.@event), "privateId");
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.@event, global::System.Guid> setField4 = (global::System.Action<global::Orleans.Serialization.UnitTests.@event, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.@event), "privateId");
        public Codec_event(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.@event.@enum>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Serialization.UnitTests.@event>>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_event>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.@event instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.Id);
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 1U, getField4(instance));
            _codec2.WriteField(ref writer, 1U, _type2, instance.@public);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Enum);
            _codec1.WriteField(ref writer, 1U, _type1, instance.@if);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.@event instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Id = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField4(instance, global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.@public = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.Enum = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.@if = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.@event @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.@event))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.@event ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.@event, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.@event();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.@event>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_event : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.@event>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.@event>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Serialization.UnitTests.@event> _copier0;
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_event _copier1;
        private static readonly global::System.Func<global::Orleans.Serialization.UnitTests.@event, global::System.Guid> getField4 = (global::System.Func<global::Orleans.Serialization.UnitTests.@event, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Serialization.UnitTests.@event), "privateId");
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.@event, global::System.Guid> setField4 = (global::System.Action<global::Orleans.Serialization.UnitTests.@event, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.@event), "privateId");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.@event DeepCopy(global::Orleans.Serialization.UnitTests.@event original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.@event existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.@event))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.@event();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_event(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Serialization.UnitTests.@event>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_event>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.@event input, global::Orleans.Serialization.UnitTests.@event output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Id = input.Id;
            setField4(output, getField4(input));
            output.@public = _copier1.DeepCopy(input.@public, context);
            output.Enum = input.Enum;
            output.@if = _copier0.DeepCopy(input.@if, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_event : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.@event>
    {
        public global::Orleans.Serialization.UnitTests.@event Create() => new global::Orleans.Serialization.UnitTests.@event();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_NestedGeneric<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.NestedGeneric<T>>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.NestedGeneric<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<T>);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested> _codec0;
        public Codec_NestedGeneric(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.NestedGeneric<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Payload);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.NestedGeneric<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Payload = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.NestedGeneric<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<T>))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NestedGeneric<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.NestedGeneric<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.NestedGeneric<T>();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.NestedGeneric<T>>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_NestedGeneric<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.NestedGeneric<T>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.NestedGeneric<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NestedGeneric<T> DeepCopy(global::Orleans.Serialization.UnitTests.NestedGeneric<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.NestedGeneric<T> existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<T>))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.NestedGeneric<T>();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_NestedGeneric(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.NestedGeneric<T> input, global::Orleans.Serialization.UnitTests.NestedGeneric<T> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Payload = _copier0.DeepCopy(input.Payload, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_NestedGeneric<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.NestedGeneric<T>>
    {
        public global::Orleans.Serialization.UnitTests.NestedGeneric<T> Create() => new global::Orleans.Serialization.UnitTests.NestedGeneric<T>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_NestedConstructedGeneric : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<int>);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.NestedConstructedGeneric.Codec_Nested<int> _codec0;
        public Codec_NestedConstructedGeneric(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.NestedConstructedGeneric.Codec_Nested<int>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Payload);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Payload = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NestedConstructedGeneric ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.NestedConstructedGeneric();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_NestedConstructedGeneric : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.NestedConstructedGeneric.Copier_Nested<int> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NestedConstructedGeneric DeepCopy(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.NestedConstructedGeneric existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.NestedConstructedGeneric();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_NestedConstructedGeneric(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.NestedConstructedGeneric.Copier_Nested<int>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric input, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Payload = _copier0.DeepCopy(input.Payload, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_NestedConstructedGeneric : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric>
    {
        public global::Orleans.Serialization.UnitTests.NestedConstructedGeneric Create() => new global::Orleans.Serialization.UnitTests.NestedConstructedGeneric();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<int>);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NestedGeneric<int> _codec0;
        public Codec_Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NestedGeneric<int>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeCopier;
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedGeneric<int> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedGeneric<int>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA : global::Orleans.Serialization.Codecs.IFieldCodec<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA>
    {
        private readonly global::System.Type _codecFieldType = typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NestedConstructedGeneric _codec0;
        public Codec_Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NestedConstructedGeneric>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.arg0);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.arg0 = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null)
            {
                ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                return;
            }

            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA();
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA : global::Orleans.Serialization.Cloning.IDeepCopier<OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeCopier;
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedConstructedGeneric _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA DeepCopy(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            var result = new OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA();
            _baseTypeCopier.DeepCopy(original, result, context);
            result.arg0 = _copier0.DeepCopy(original.arg0, context);
            return result;
        }

        public Copier_Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<int>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedConstructedGeneric>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyForeignLibraryTypeSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Num);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.String);
            global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.WriteField(ref writer, 1U, instance.DateTimeOffset);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Num = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.String = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.DateTimeOffset = global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_WrapsMyForeignLibraryType : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.MyForeignLibraryType);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyForeignLibraryType> _codec0;
        public Codec_WrapsMyForeignLibraryType(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyForeignLibraryType>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntValue);
            _codec0.WriteField(ref writer, 1U, _type0, instance.ForeignValue);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.OtherIntValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntValue = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.ForeignValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.OtherIntValue = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_WrapsMyForeignLibraryType : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.MyForeignLibraryType> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType DeepCopy(global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_WrapsMyForeignLibraryType(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.MyForeignLibraryType>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType input, global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.IntValue = input.IntValue;
            output.ForeignValue = _copier0.DeepCopy(input.ForeignValue, context);
            output.OtherIntValue = input.OtherIntValue;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_WrapsMyForeignLibraryType : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType>
    {
        public global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType Create() => new global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryType();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_DerivedFromMyForeignLibraryType : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.MyForeignLibraryType> _baseTypeSerializer;
        public Codec_DerivedFromMyForeignLibraryType(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.MyForeignLibraryType> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntValue = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_DerivedFromMyForeignLibraryType : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.MyForeignLibraryType> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType DeepCopy(global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_DerivedFromMyForeignLibraryType(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.MyForeignLibraryType> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType input, global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.IntValue = input.IntValue;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_DerivedFromMyForeignLibraryType : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType>
    {
        public global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType Create() => new global::Orleans.Serialization.UnitTests.DerivedFromMyForeignLibraryType();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyForeignLibraryValueTypeSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Num);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.String);
            global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.WriteField(ref writer, 1U, instance.DateTimeOffset);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Num = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.String = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.DateTimeOffset = global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_WrapsMyForeignLibraryValueType : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.MyForeignLibraryValueType);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyForeignLibraryValueType> _codec0;
        public Codec_WrapsMyForeignLibraryValueType(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyForeignLibraryValueType>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntValue);
            _codec0.WriteField(ref writer, 1U, _type0, instance.ForeignValue);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.OtherIntValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntValue = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.ForeignValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.OtherIntValue = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyNonJsonBaseClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyNonJsonBaseClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass DeepCopy(global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass input, global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.IntProperty = input.IntProperty;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyNonJsonBaseClass : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass>
    {
        public global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass Create() => new global::Orleans.Serialization.UnitTests.MyNonJsonBaseClass();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyCustomEnum : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyCustomEnum>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MyCustomEnum);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MyCustomEnum @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, fieldIdDelta, expectedType, (int)@value, _codecFieldType);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyCustomEnum ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            return (global::Orleans.Serialization.UnitTests.MyCustomEnum)global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_RecursiveClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.RecursiveClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.RecursiveClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.RecursiveClass);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.RecursiveClass);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecursiveClass _codec0;
        public Codec_RecursiveClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecursiveClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.RecursiveClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntProperty);
            _codec0.WriteField(ref writer, 1U, _type0, instance.RecursiveProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.RecursiveClass instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.RecursiveProperty = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.RecursiveClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.RecursiveClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.RecursiveClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.RecursiveClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.RecursiveClass();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.RecursiveClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_RecursiveClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.RecursiveClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.RecursiveClass>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecursiveClass _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.RecursiveClass DeepCopy(global::Orleans.Serialization.UnitTests.RecursiveClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.RecursiveClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.RecursiveClass))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.RecursiveClass();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_RecursiveClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecursiveClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.RecursiveClass input, global::Orleans.Serialization.UnitTests.RecursiveClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.IntProperty = input.IntProperty;
            output.RecursiveProperty = _copier0.DeepCopy(input.RecursiveProperty, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_RecursiveClass : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.RecursiveClass>
    {
        public global::Orleans.Serialization.UnitTests.RecursiveClass Create() => new global::Orleans.Serialization.UnitTests.RecursiveClass();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_SomeClassWithSerializers : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.SomeClassWithSerializers>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.SomeClassWithSerializers>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.SomeClassWithSerializers);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.SomeClassWithSerializers instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntProperty);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.IntField);
            global::Orleans.Serialization.Codecs.ObjectCodec.WriteField(ref writer, 1U, instance.OtherObject);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.SomeClassWithSerializers instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.IntField = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.OtherObject = global::Orleans.Serialization.Codecs.ObjectCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.SomeClassWithSerializers @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.SomeClassWithSerializers))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.SomeClassWithSerializers ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.SomeClassWithSerializers, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.SomeClassWithSerializers();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.SomeClassWithSerializers>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_SomeClassWithSerializers : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.SomeClassWithSerializers>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.SomeClassWithSerializers>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.SomeClassWithSerializers DeepCopy(global::Orleans.Serialization.UnitTests.SomeClassWithSerializers original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.SomeClassWithSerializers existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.SomeClassWithSerializers))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.SomeClassWithSerializers();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.SomeClassWithSerializers input, global::Orleans.Serialization.UnitTests.SomeClassWithSerializers output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.IntProperty = input.IntProperty;
            output.IntField = input.IntField;
            output.OtherObject = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(input.OtherObject, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_SomeClassWithSerializers : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.SomeClassWithSerializers>
    {
        public global::Orleans.Serialization.UnitTests.SomeClassWithSerializers Create() => new global::Orleans.Serialization.UnitTests.SomeClassWithSerializers();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_PocoWithAutogeneratedIds : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 683817142U, instance.F);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 318102879U, instance.E);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 291188959U, instance.D);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1053863394U, instance.G);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 126761183U, instance.I);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 393023149U, instance.K);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 232368202U, instance.A);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 310213262U, instance.H);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 204587520U, instance.C);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 97963112U, instance.B);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 572161402U, instance.J);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 683817142U)
                {
                    instance.F = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1001920021U)
                {
                    instance.E = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1293108980U)
                {
                    instance.D = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2346972374U)
                {
                    instance.G = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2473733557U)
                {
                    instance.I = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2866756706U)
                {
                    instance.K = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3099124908U)
                {
                    instance.A = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3409338170U)
                {
                    instance.H = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3613925690U)
                {
                    instance.C = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3711888802U)
                {
                    instance.B = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4284050204U)
                {
                    instance.J = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_PocoWithAutogeneratedIds : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds DeepCopy(global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds input, global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.F = input.F;
            output.E = input.E;
            output.D = input.D;
            output.G = input.G;
            output.I = input.I;
            output.K = input.K;
            output.A = input.A;
            output.H = input.H;
            output.C = input.C;
            output.B = input.B;
            output.J = input.J;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_PocoWithAutogeneratedIds : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds>
    {
        public global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds Create() => new global::Orleans.Serialization.UnitTests.PocoWithAutogeneratedIds();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_SerializableClassWithCompiledBase : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.List<int>> _baseTypeSerializer;
        public Codec_SerializableClassWithCompiledBase(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.List<int>> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_SerializableClassWithCompiledBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.List<int>> _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase DeepCopy(global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_SerializableClassWithCompiledBase(global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.List<int>> _baseTypeCopier)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase input, global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.IntProperty = input.IntProperty;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_SerializableClassWithCompiledBase : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase>
    {
        public global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase Create() => new global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_DerivedFromDictionary<TKey, TValue> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.Dictionary<TKey, TValue>> _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue>> _activator;
        public Codec_DerivedFromDictionary(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Collections.Generic.Dictionary<TKey, TValue>> _baseTypeSerializer, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue>> _activator)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = _activator.Create();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_DerivedFromDictionary<TKey, TValue> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue>>
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.Dictionary<TKey, TValue>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue>> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue> DeepCopy(global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue> existing))
                return existing;
            var result = _activator.Create();
            context.RecordCopy(original, result);
            _baseTypeCopier.DeepCopy(original, result, context);
            result.IntProperty = original.IntProperty;
            return result;
        }

        public Copier_DerivedFromDictionary(global::Orleans.Serialization.Cloning.IBaseCopier<global::System.Collections.Generic.Dictionary<TKey, TValue>> _baseTypeCopier, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromDictionary<TKey, TValue>> _activator)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_GenericPoco<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.GenericPoco<T>>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.GenericPoco<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.GenericPoco<T>);
        private readonly global::System.Type _type0 = typeof(T[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<T> _codec0;
        private readonly global::System.Type _type1 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec1;
        public Codec_GenericPoco(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<T>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.GenericPoco<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 0U, _type1, instance.Field);
            _codec0.WriteField(ref writer, 1030U, _type0, instance.ArrayField);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.GenericPoco<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Field = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1030U)
                {
                    instance.ArrayField = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.GenericPoco<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.GenericPoco<T>))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.GenericPoco<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.GenericPoco<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.GenericPoco<T>();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.GenericPoco<T>>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_GenericPoco<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.GenericPoco<T>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.GenericPoco<T>>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<T> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.GenericPoco<T> DeepCopy(global::Orleans.Serialization.UnitTests.GenericPoco<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.GenericPoco<T> existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.GenericPoco<T>))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.GenericPoco<T>();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_GenericPoco(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<T>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.GenericPoco<T> input, global::Orleans.Serialization.UnitTests.GenericPoco<T> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Field = _copier1.DeepCopy(input.Field, context);
            output.ArrayField = _copier0.DeepCopy(input.ArrayField, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_GenericPoco<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.GenericPoco<T>>
    {
        public global::Orleans.Serialization.UnitTests.GenericPoco<T> Create() => new global::Orleans.Serialization.UnitTests.GenericPoco<T>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_GenericPocoWithConstraint<TClass, TStruct> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>> where TClass : global::System.Collections.Generic.List<int>, new()
        where TStruct : struct
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.GenericPoco<TStruct>> _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(TClass);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<TClass> _codec0;
        private readonly global::System.Type _type1 = typeof(TStruct);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<TStruct> _codec1;
        public Codec_GenericPocoWithConstraint(global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.GenericPoco<TStruct>> _baseTypeSerializer, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<TClass>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<TStruct>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.Field);
            _codec1.WriteField(ref writer, 999U, _type1, instance.ValueField);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Field = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 999U)
                {
                    instance.ValueField = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_GenericPocoWithConstraint<TClass, TStruct> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>> where TClass : global::System.Collections.Generic.List<int>, new()
        where TStruct : struct
    {
        private readonly global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.GenericPoco<TStruct>> _baseTypeCopier;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<TClass> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<TStruct> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> DeepCopy(global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_GenericPocoWithConstraint(global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.GenericPoco<TStruct>> _baseTypeCopier, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._baseTypeCopier = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeCopier);
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<TClass>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<TStruct>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> input, global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.Field = _copier0.DeepCopy(input.Field, context);
            output.ValueField = _copier1.DeepCopy(input.ValueField, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_GenericPocoWithConstraint<TClass, TStruct> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>> where TClass : global::System.Collections.Generic.List<int>, new()
        where TStruct : struct
    {
        public global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct> Create() => new global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<TClass, TStruct>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ArrayPoco<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ArrayPoco<T>>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.ArrayPoco<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ArrayPoco<T>);
        private readonly global::System.Type _type0 = typeof(T[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<T> _codec0;
        private readonly global::System.Type _type1 = typeof(T[, ]);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T[, ]> _codec1;
        private readonly global::System.Type _type2 = typeof(T[,, ]);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T[,, ]> _codec2;
        private readonly global::System.Type _type3 = typeof(T[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,, ]);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,, ]> _codec3;
        private readonly global::System.Type _type4 = typeof(T[,,, ]);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T[,,, ]> _codec4;
        private readonly global::System.Type _type5 = typeof(T[][]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<T[]> _codec5;
        public Codec_ArrayPoco(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<T>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T[, ]>>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T[,, ]>>(this, codecProvider);
            _codec3 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,, ]>>(this, codecProvider);
            _codec4 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T[,,, ]>>(this, codecProvider);
            _codec5 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<T[]>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.ArrayPoco<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Array);
            _codec1.WriteField(ref writer, 1U, _type1, instance.Dim2);
            _codec2.WriteField(ref writer, 1U, _type2, instance.Dim3);
            _codec4.WriteField(ref writer, 1U, _type4, instance.Dim4);
            _codec3.WriteField(ref writer, 1U, _type3, instance.Dim32);
            _codec5.WriteField(ref writer, 1U, _type5, instance.Jagged);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.ArrayPoco<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Array = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Dim2 = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Dim3 = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.Dim4 = _codec4.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.Dim32 = _codec3.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 5U)
                {
                    instance.Jagged = _codec5.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ArrayPoco<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.ArrayPoco<T>))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ArrayPoco<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.ArrayPoco<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.ArrayPoco<T>();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.ArrayPoco<T>>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ArrayPoco<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.ArrayPoco<T>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.ArrayPoco<T>>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<T> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T[, ]> _copier1;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T[,, ]> _copier2;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,, ]> _copier3;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T[,,, ]> _copier4;
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<T[]> _copier5;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ArrayPoco<T> DeepCopy(global::Orleans.Serialization.UnitTests.ArrayPoco<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.ArrayPoco<T> existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.ArrayPoco<T>))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.ArrayPoco<T>();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_ArrayPoco(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<T>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T[, ]>>(this, codecProvider);
            _copier2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T[,, ]>>(this, codecProvider);
            _copier3 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,, ]>>(this, codecProvider);
            _copier4 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T[,,, ]>>(this, codecProvider);
            _copier5 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<T[]>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.ArrayPoco<T> input, global::Orleans.Serialization.UnitTests.ArrayPoco<T> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Array = _copier0.DeepCopy(input.Array, context);
            output.Dim2 = _copier1.DeepCopy(input.Dim2, context);
            output.Dim3 = _copier2.DeepCopy(input.Dim3, context);
            output.Dim4 = _copier4.DeepCopy(input.Dim4, context);
            output.Dim32 = _copier3.DeepCopy(input.Dim32, context);
            output.Jagged = _copier5.DeepCopy(input.Jagged, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_ArrayPoco<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ArrayPoco<T>>
    {
        public global::Orleans.Serialization.UnitTests.ArrayPoco<T> Create() => new global::Orleans.Serialization.UnitTests.ArrayPoco<T>();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ImmutableClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ImmutableClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.ImmutableClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ImmutableClass);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ImmutableClass> _activator;
        private static readonly global::System.Func<global::Orleans.Serialization.UnitTests.ImmutableClass, int> getField0 = (global::System.Func<global::Orleans.Serialization.UnitTests.ImmutableClass, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableClass), "_intField");
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.ImmutableClass, int> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.ImmutableClass, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableClass), "_intField");
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.ImmutableClass, int> setField1 = (global::System.Action<global::Orleans.Serialization.UnitTests.ImmutableClass, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableClass), "<IntProperty>k__BackingField");
        public Codec_ImmutableClass(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ImmutableClass> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.ImmutableClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntProperty);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, getField0(instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.ImmutableClass instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ImmutableClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.ImmutableClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ImmutableClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.ImmutableClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.ImmutableClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ImmutableClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.ImmutableClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.ImmutableClass>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ImmutableClass> _activator;
        private static readonly global::System.Func<global::Orleans.Serialization.UnitTests.ImmutableClass, int> getField0 = (global::System.Func<global::Orleans.Serialization.UnitTests.ImmutableClass, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetGetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableClass), "_intField");
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.ImmutableClass, int> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.ImmutableClass, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableClass), "_intField");
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.ImmutableClass, int> setField1 = (global::System.Action<global::Orleans.Serialization.UnitTests.ImmutableClass, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableClass), "<IntProperty>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ImmutableClass DeepCopy(global::Orleans.Serialization.UnitTests.ImmutableClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.ImmutableClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.ImmutableClass))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_ImmutableClass(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ImmutableClass> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.ImmutableClass input, global::Orleans.Serialization.UnitTests.ImmutableClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField1(output, input.IntProperty);
            setField0(output, getField0(input));
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ImmutableStruct : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ImmutableStruct>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.UnitTests.ImmutableStruct>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ImmutableStruct);
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Serialization.UnitTests.ImmutableStruct, int> getField0 = (global::Orleans.Serialization.Utilities.ValueTypeGetter<global::Orleans.Serialization.UnitTests.ImmutableStruct, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueGetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableStruct), "_intField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.ImmutableStruct, int> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.ImmutableStruct, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableStruct), "_intField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.ImmutableStruct, int> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.ImmutableStruct, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Serialization.UnitTests.ImmutableStruct), "<IntProperty>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.UnitTests.ImmutableStruct instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntProperty);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, getField0(ref instance));
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.UnitTests.ImmutableStruct instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(ref instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField0(ref instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ImmutableStruct @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ImmutableStruct ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.UnitTests.ImmutableStruct);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_SystemCollectionsClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.SystemCollectionsClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.SystemCollectionsClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.SystemCollectionsClass);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Concurrent.ConcurrentDictionary<string, int>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Concurrent.ConcurrentDictionary<string, int>> _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Concurrent.ConcurrentQueue<int>);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Concurrent.ConcurrentQueue<int>> _codec1;
        private readonly global::System.Type _type2 = typeof(global::System.Collections.Generic.HashSet<string>);
        private readonly global::Orleans.Serialization.Codecs.HashSetCodec<string> _codec2;
        public Codec_SystemCollectionsClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Concurrent.ConcurrentDictionary<string, int>>>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<global::System.Collections.Concurrent.ConcurrentQueue<int>>>(this, codecProvider);
            _codec2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.HashSetCodec<string>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.SystemCollectionsClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec2.WriteField(ref writer, 0U, _type2, instance.hashSetField);
            _codec2.WriteField(ref writer, 1U, _type2, instance.HashSetProperty);
            _codec1.WriteField(ref writer, 1U, _type1, instance.concurrentQueueField);
            _codec1.WriteField(ref writer, 1U, _type1, instance.ConcurrentQueueProperty);
            _codec0.WriteField(ref writer, 1U, _type0, instance.concurrentDictField);
            _codec0.WriteField(ref writer, 1U, _type0, instance.ConcurrentDictProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.SystemCollectionsClass instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.hashSetField = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.HashSetProperty = _codec2.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.concurrentQueueField = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.ConcurrentQueueProperty = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 4U)
                {
                    instance.concurrentDictField = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 5U)
                {
                    instance.ConcurrentDictProperty = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.SystemCollectionsClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.SystemCollectionsClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.SystemCollectionsClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.SystemCollectionsClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.SystemCollectionsClass();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.SystemCollectionsClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_SystemCollectionsClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.SystemCollectionsClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.SystemCollectionsClass>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Concurrent.ConcurrentDictionary<string, int>> _copier0;
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Concurrent.ConcurrentQueue<int>> _copier1;
        private readonly global::Orleans.Serialization.Codecs.HashSetCopier<string> _copier2;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.SystemCollectionsClass DeepCopy(global::Orleans.Serialization.UnitTests.SystemCollectionsClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.SystemCollectionsClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.SystemCollectionsClass))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.SystemCollectionsClass();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_SystemCollectionsClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Concurrent.ConcurrentDictionary<string, int>>>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<global::System.Collections.Concurrent.ConcurrentQueue<int>>>(this, codecProvider);
            _copier2 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.HashSetCopier<string>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.SystemCollectionsClass input, global::Orleans.Serialization.UnitTests.SystemCollectionsClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.hashSetField = _copier2.DeepCopy(input.hashSetField, context);
            output.HashSetProperty = _copier2.DeepCopy(input.HashSetProperty, context);
            output.concurrentQueueField = _copier1.DeepCopy(input.concurrentQueueField, context);
            output.ConcurrentQueueProperty = _copier1.DeepCopy(input.ConcurrentQueueProperty, context);
            output.concurrentDictField = _copier0.DeepCopy(input.concurrentDictField, context);
            output.ConcurrentDictProperty = _copier0.DeepCopy(input.ConcurrentDictProperty, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_SystemCollectionsClass : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.SystemCollectionsClass>
    {
        public global::Orleans.Serialization.UnitTests.SystemCollectionsClass Create() => new global::Orleans.Serialization.UnitTests.SystemCollectionsClass();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ClassWithLargeCollectionAndUri : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri);
        private readonly global::System.Type _type0 = typeof(global::System.Collections.Generic.List<string>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<string> _codec0;
        public Codec_ClassWithLargeCollectionAndUri(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<string>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.LargeCollection);
            global::Orleans.Serialization.Codecs.UriCodec.WriteField(ref writer, 1U, instance.Uri);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.LargeCollection = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Uri = global::Orleans.Serialization.Codecs.UriCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ClassWithLargeCollectionAndUri : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri>
    {
        private readonly global::Orleans.Serialization.Codecs.ListCopier<string> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri DeepCopy(global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_ClassWithLargeCollectionAndUri(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<string>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri input, global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.LargeCollection = _copier0.DeepCopy(input.LargeCollection, context);
            output.Uri = input.Uri;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_ClassWithLargeCollectionAndUri : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri>
    {
        public global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri Create() => new global::Orleans.Serialization.UnitTests.ClassWithLargeCollectionAndUri();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ClassWithManualSerializableProperty : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.GuidProperty);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StringProperty);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.GuidProperty = global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.StringProperty = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ClassWithManualSerializableProperty : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty DeepCopy(global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty input, global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.GuidProperty = input.GuidProperty;
            output.StringProperty = input.StringProperty;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_ClassWithManualSerializableProperty : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty>
    {
        public global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty Create() => new global::Orleans.Serialization.UnitTests.ClassWithManualSerializableProperty();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ClassWithImplicitFieldIds : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds> _activator;
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.MyCustomEnum);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyCustomEnum _codec0;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, global::Orleans.Serialization.UnitTests.MyCustomEnum> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, global::Orleans.Serialization.UnitTests.MyCustomEnum>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds), "<EnumValue>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, string> setField1 = (global::System.Action<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds), "<StringValue>k__BackingField");
        public Codec_ClassWithImplicitFieldIds(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds> _activator, global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyCustomEnum>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 19816600U, _type0, instance.EnumValue);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1774218397U, instance.StringValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 19816600U)
                {
                    setField0(instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1794034997U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ClassWithImplicitFieldIds : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds>
    {
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, global::Orleans.Serialization.UnitTests.MyCustomEnum> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, global::Orleans.Serialization.UnitTests.MyCustomEnum>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds), "<EnumValue>k__BackingField");
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, string> setField1 = (global::System.Action<global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds), "<StringValue>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds DeepCopy(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return original is null || original.GetType() == typeof(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds) ? original : context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds input, global::Orleans.Serialization.UnitTests.ClassWithImplicitFieldIds output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.EnumValue);
            setField1(output, input.StringValue);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ClassWithTypeFields : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ClassWithTypeFields>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ClassWithTypeFields);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.ClassWithTypeFields instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.TypeSerializerCodec.WriteField(ref writer, 1U, instance.Type1);
            global::Orleans.Serialization.Codecs.ObjectCodec.WriteField(ref writer, 1U, instance.UntypedValue);
            global::Orleans.Serialization.Codecs.TypeSerializerCodec.WriteField(ref writer, 1U, instance.Type2);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.ClassWithTypeFields instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 1U)
                {
                    instance.Type1 = global::Orleans.Serialization.Codecs.TypeSerializerCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.UntypedValue = global::Orleans.Serialization.Codecs.ObjectCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    instance.Type2 = global::Orleans.Serialization.Codecs.TypeSerializerCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ClassWithTypeFields @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ClassWithTypeFields ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.ClassWithTypeFields, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.UnitTests.ClassWithTypeFields();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ClassWithTypeFields : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.ClassWithTypeFields>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ClassWithTypeFields DeepCopy(global::Orleans.Serialization.UnitTests.ClassWithTypeFields original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.ClassWithTypeFields existing))
                return existing;
            var result = new global::Orleans.Serialization.UnitTests.ClassWithTypeFields();
            context.RecordCopy(original, result);
            result.Type1 = original.Type1;
            result.UntypedValue = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(original.UntypedValue, context);
            result.Type2 = original.Type2;
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_ClassWithTypeFields : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ClassWithTypeFields>
    {
        public global::Orleans.Serialization.UnitTests.ClassWithTypeFields Create() => new global::Orleans.Serialization.UnitTests.ClassWithTypeFields();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyFirstForeignLibraryTypeSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Num);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.String);
            global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.WriteField(ref writer, 1U, instance.DateTimeOffset);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Num = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.String = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.DateTimeOffset = global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MySecondForeignLibraryTypeSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Name);
            global::Orleans.Serialization.Codecs.FloatCodec.WriteField(ref writer, 1U, instance.Value);
            global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.WriteField(ref writer, 1U, instance.Timestamp);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Name = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Value = global::Orleans.Serialization.Codecs.FloatCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Timestamp = global::Orleans.Serialization.Codecs.DateTimeOffsetCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_CustomException : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.CustomException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.CustomException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.CustomException);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer;
        public Codec_CustomException(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.CustomException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.CustomInt);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.CustomException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.CustomInt = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.CustomException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.CustomException))
            {
                if (@value is null)
                {
                    ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                    return;
                }

                ReferenceCodec.MarkValueField(writer.Session);
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.CustomException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.CustomException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.CustomException();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.CustomException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_CustomException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::Orleans.Serialization.UnitTests.CustomException, global::System.Exception>
    {
        public Copier_CustomException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::Orleans.Serialization.UnitTests.CustomException input, global::Orleans.Serialization.UnitTests.CustomException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            output.CustomInt = input.CustomInt;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_CustomException : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.CustomException>
    {
        public global::Orleans.Serialization.UnitTests.CustomException Create() => new global::Orleans.Serialization.UnitTests.CustomException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_EmptyAbstractRecord : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.UnitTests.EmptyAbstractRecord>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.EmptyAbstractRecord instance)
        {
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.EmptyAbstractRecord instance)
        {
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            if (header.IsEndBaseFields)
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_EmptyAbstractRecord : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.EmptyAbstractRecord>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.EmptyAbstractRecord>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.EmptyAbstractRecord DeepCopy(global::Orleans.Serialization.UnitTests.EmptyAbstractRecord original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.EmptyAbstractRecord input, global::Orleans.Serialization.UnitTests.EmptyAbstractRecord output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_DerivedFromEmptyAbstractRecord : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_EmptyAbstractRecord _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord), "<Foo>k__BackingField");
        public Codec_DerivedFromEmptyAbstractRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_EmptyAbstractRecord>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Foo);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_DerivedFromEmptyAbstractRecord : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_EmptyAbstractRecord _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord), "<Foo>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord DeepCopy(global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_DerivedFromEmptyAbstractRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_EmptyAbstractRecord>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord input, global::Orleans.Serialization.UnitTests.DerivedFromEmptyAbstractRecord output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            setField0(output, input.Foo);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_NonEmptyAbstractRecord : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord>
    {
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord), "<Bar>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord instance)
        {
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Bar);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_NonEmptyAbstractRecord : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord>
    {
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord), "<Bar>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord DeepCopy(global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord input, global::Orleans.Serialization.UnitTests.NonEmptyAbstractRecord output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.Bar);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_DerivedFromNonEmptyAbstractRecord : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NonEmptyAbstractRecord _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord), "<Foo>k__BackingField");
        public Codec_DerivedFromNonEmptyAbstractRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NonEmptyAbstractRecord>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Foo);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_DerivedFromNonEmptyAbstractRecord : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NonEmptyAbstractRecord _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord), "<Foo>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord DeepCopy(global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_DerivedFromNonEmptyAbstractRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NonEmptyAbstractRecord>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord input, global::Orleans.Serialization.UnitTests.DerivedFromNonEmptyAbstractRecord output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            setField0(output, input.Foo);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_RecordHierarchyDerived : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.RecordHierarchyDerived);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecordHierarchyMiddle _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.RecordHierarchyDerived), "<Message>k__BackingField");
        public Codec_RecordHierarchyDerived(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecordHierarchyMiddle>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.RecordHierarchyDerived instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Message);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.RecordHierarchyDerived instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 1U)
                    {
                        setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id++;
                    }

                    reader.ConsumeUnknownField(ref header);
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.RecordHierarchyDerived @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.RecordHierarchyDerived))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.RecordHierarchyDerived ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.RecordHierarchyDerived>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_RecordHierarchyDerived : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecordHierarchyMiddle _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.RecordHierarchyDerived), "<Message>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.RecordHierarchyDerived DeepCopy(global::Orleans.Serialization.UnitTests.RecordHierarchyDerived original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.RecordHierarchyDerived existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.RecordHierarchyDerived))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_RecordHierarchyDerived(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.RecordHierarchyDerived> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecordHierarchyMiddle>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.RecordHierarchyDerived input, global::Orleans.Serialization.UnitTests.RecordHierarchyDerived output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            setField0(output, input.Message);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_RecordHierarchyMiddle : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecordHierarchyBase _baseTypeSerializer;
        public Codec_RecordHierarchyMiddle(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecordHierarchyBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle instance)
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            if (header.IsEndBaseFields)
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_RecordHierarchyMiddle : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecordHierarchyBase _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle DeepCopy(global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        public Copier_RecordHierarchyMiddle(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecordHierarchyBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle input, global::Orleans.Serialization.UnitTests.RecordHierarchyMiddle output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_RecordHierarchyBase : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.UnitTests.RecordHierarchyBase>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.RecordHierarchyBase instance)
        {
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.RecordHierarchyBase instance)
        {
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            if (header.IsEndBaseFields)
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_RecordHierarchyBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.RecordHierarchyBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.RecordHierarchyBase>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.RecordHierarchyBase DeepCopy(global::Orleans.Serialization.UnitTests.RecordHierarchyBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.RecordHierarchyBase input, global::Orleans.Serialization.UnitTests.RecordHierarchyBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_FooWithListOfObject : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.FooWithListOfObject>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.FooWithListOfObject>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.FooWithListOfObject);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.FooRecord);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooRecord _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<object>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<object> _codec1;
        public Codec_FooWithListOfObject(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooRecord>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<object>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.FooWithListOfObject instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 1U, _type1, instance.Items);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Bar);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.FooWithListOfObject instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 1U)
                {
                    instance.Items = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Bar = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.FooWithListOfObject @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.FooWithListOfObject))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FooWithListOfObject ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.FooWithListOfObject, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.FooWithListOfObject();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.FooWithListOfObject>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_FooWithListOfObject : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.FooWithListOfObject>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.FooWithListOfObject>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooRecord _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<object> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FooWithListOfObject DeepCopy(global::Orleans.Serialization.UnitTests.FooWithListOfObject original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.FooWithListOfObject existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.FooWithListOfObject))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.FooWithListOfObject();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_FooWithListOfObject(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooRecord>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<object>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.FooWithListOfObject input, global::Orleans.Serialization.UnitTests.FooWithListOfObject output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Items = _copier1.DeepCopy(input.Items, context);
            output.Bar = _copier0.DeepCopy(input.Bar, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_FooWithListOfObject : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FooWithListOfObject>
    {
        public global::Orleans.Serialization.UnitTests.FooWithListOfObject Create() => new global::Orleans.Serialization.UnitTests.FooWithListOfObject();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_TwoObjects : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.TwoObjects>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.TwoObjects>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.TwoObjects);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.TwoObjects instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.ObjectCodec.WriteField(ref writer, 0U, instance.One);
            global::Orleans.Serialization.Codecs.ObjectCodec.WriteField(ref writer, 1U, instance.Two);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.TwoObjects instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.One = global::Orleans.Serialization.Codecs.ObjectCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Two = global::Orleans.Serialization.Codecs.ObjectCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.TwoObjects @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.TwoObjects))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TwoObjects ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.TwoObjects, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.TwoObjects();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.TwoObjects>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_TwoObjects : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.TwoObjects>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.TwoObjects>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.TwoObjects DeepCopy(global::Orleans.Serialization.UnitTests.TwoObjects original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.TwoObjects existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.TwoObjects))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.TwoObjects();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.TwoObjects input, global::Orleans.Serialization.UnitTests.TwoObjects output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.One = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(input.One, context);
            output.Two = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(input.Two, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_TwoObjects : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.TwoObjects>
    {
        public global::Orleans.Serialization.UnitTests.TwoObjects Create() => new global::Orleans.Serialization.UnitTests.TwoObjects();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_FooWithListOfFruit : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.FooWithListOfFruit>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.FooWithListOfFruit>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.FooWithListOfFruit);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.FooRecord);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooRecord _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<global::Orleans.Serialization.UnitTests.FruitRecord>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Serialization.UnitTests.FruitRecord> _codec1;
        public Codec_FooWithListOfFruit(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooRecord>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Serialization.UnitTests.FruitRecord>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.FooWithListOfFruit instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 1U, _type1, instance.Items);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Bar);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.FooWithListOfFruit instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 1U)
                {
                    instance.Items = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Bar = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.FooWithListOfFruit @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.FooWithListOfFruit))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FooWithListOfFruit ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.FooWithListOfFruit, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.FooWithListOfFruit();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.FooWithListOfFruit>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_FooWithListOfFruit : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.FooWithListOfFruit>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.FooWithListOfFruit>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooRecord _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Serialization.UnitTests.FruitRecord> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FooWithListOfFruit DeepCopy(global::Orleans.Serialization.UnitTests.FooWithListOfFruit original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.FooWithListOfFruit existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.FooWithListOfFruit))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.FooWithListOfFruit();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_FooWithListOfFruit(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooRecord>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Serialization.UnitTests.FruitRecord>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.FooWithListOfFruit input, global::Orleans.Serialization.UnitTests.FooWithListOfFruit output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Items = _copier1.DeepCopy(input.Items, context);
            output.Bar = _copier0.DeepCopy(input.Bar, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_FooWithListOfFruit : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FooWithListOfFruit>
    {
        public global::Orleans.Serialization.UnitTests.FooWithListOfFruit Create() => new global::Orleans.Serialization.UnitTests.FooWithListOfFruit();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_FooWithListOfApple : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.FooWithListOfApple>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.FooWithListOfApple>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.FooWithListOfApple);
        private readonly global::System.Type _type0 = typeof(global::Orleans.Serialization.UnitTests.FooRecord);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooRecord _codec0;
        private readonly global::System.Type _type1 = typeof(global::System.Collections.Generic.List<global::Orleans.Serialization.UnitTests.AppleRecord>);
        private readonly global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Serialization.UnitTests.AppleRecord> _codec1;
        public Codec_FooWithListOfApple(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooRecord>(this, codecProvider);
            _codec1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCodec<global::Orleans.Serialization.UnitTests.AppleRecord>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.FooWithListOfApple instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec1.WriteField(ref writer, 1U, _type1, instance.Items);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Bar);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.FooWithListOfApple instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 1U)
                {
                    instance.Items = _codec1.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Bar = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id++;
                }

                reader.ConsumeUnknownField(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.FooWithListOfApple @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.FooWithListOfApple))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FooWithListOfApple ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.FooWithListOfApple, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.FooWithListOfApple();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.FooWithListOfApple>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_FooWithListOfApple : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.FooWithListOfApple>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.FooWithListOfApple>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooRecord _copier0;
        private readonly global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Serialization.UnitTests.AppleRecord> _copier1;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FooWithListOfApple DeepCopy(global::Orleans.Serialization.UnitTests.FooWithListOfApple original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.FooWithListOfApple existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.FooWithListOfApple))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.FooWithListOfApple();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_FooWithListOfApple(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooRecord>(this, codecProvider);
            _copier1 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ListCopier<global::Orleans.Serialization.UnitTests.AppleRecord>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.FooWithListOfApple input, global::Orleans.Serialization.UnitTests.FooWithListOfApple output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Items = _copier1.DeepCopy(input.Items, context);
            output.Bar = _copier0.DeepCopy(input.Bar, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_FooWithListOfApple : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FooWithListOfApple>
    {
        public global::Orleans.Serialization.UnitTests.FooWithListOfApple Create() => new global::Orleans.Serialization.UnitTests.FooWithListOfApple();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_FruitRecord : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.FruitRecord>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.FruitRecord>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.FruitRecord);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FruitRecord> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.FruitRecord, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.FruitRecord, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.FruitRecord), "<Name>k__BackingField");
        public Codec_FruitRecord(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FruitRecord> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.FruitRecord instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Name);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.FruitRecord instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }

            id = 0U;
            if (header.IsEndBaseFields)
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.FruitRecord @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.FruitRecord))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FruitRecord ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.FruitRecord, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.FruitRecord>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_FruitRecord : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.FruitRecord>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.FruitRecord>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FruitRecord> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.FruitRecord, string> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.FruitRecord, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.FruitRecord), "<Name>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FruitRecord DeepCopy(global::Orleans.Serialization.UnitTests.FruitRecord original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.FruitRecord existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.FruitRecord))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_FruitRecord(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FruitRecord> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.FruitRecord input, global::Orleans.Serialization.UnitTests.FruitRecord output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.Name);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_AppleRecord : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.AppleRecord>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.AppleRecord>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.AppleRecord);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FruitRecord _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.AppleRecord> _activator;
        public Codec_AppleRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.AppleRecord> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FruitRecord>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.AppleRecord instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.AppleRecord instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            if (header.IsEndBaseFields)
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.AppleRecord @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.AppleRecord))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.AppleRecord ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.AppleRecord, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.AppleRecord>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_AppleRecord : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.AppleRecord>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.AppleRecord>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FruitRecord _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.AppleRecord> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.AppleRecord DeepCopy(global::Orleans.Serialization.UnitTests.AppleRecord original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.AppleRecord existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.AppleRecord))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_AppleRecord(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.AppleRecord> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FruitRecord>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.AppleRecord input, global::Orleans.Serialization.UnitTests.AppleRecord output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_FooRecord : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.FooRecord>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.FooRecord>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.FooRecord);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FooRecord> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.FooRecord, global::System.Guid> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.FooRecord, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.FooRecord), "<Id>k__BackingField");
        public Codec_FooRecord(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FooRecord> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.FooRecord instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.Id);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.FooRecord instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        setField0(instance, global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.FooRecord @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.FooRecord))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FooRecord ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.FooRecord, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.FooRecord>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_FooRecord : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.FooRecord>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.FooRecord>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FooRecord> _activator;
        private static readonly global::System.Action<global::Orleans.Serialization.UnitTests.FooRecord, global::System.Guid> setField0 = (global::System.Action<global::Orleans.Serialization.UnitTests.FooRecord, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Orleans.Serialization.UnitTests.FooRecord), "<Id>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.FooRecord DeepCopy(global::Orleans.Serialization.UnitTests.FooRecord original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.FooRecord existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.FooRecord))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_FooRecord(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.FooRecord> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.FooRecord input, global::Orleans.Serialization.UnitTests.FooRecord output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.Id);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyCompoundTypeAliasBaseClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.BaseValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.BaseValue = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyCompoundTypeAliasBaseClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass DeepCopy(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass input, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.BaseValue = input.BaseValue;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyCompoundTypeAliasBaseClass : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass>
    {
        public global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass Create() => new global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasBaseClass();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyCompoundTypeAliasClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyCompoundTypeAliasBaseClass _baseTypeSerializer;
        public Codec_MyCompoundTypeAliasClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyCompoundTypeAliasBaseClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Name);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.Value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Name = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Value = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyCompoundTypeAliasClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_MyCompoundTypeAliasBaseClass _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass DeepCopy(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_MyCompoundTypeAliasClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_MyCompoundTypeAliasBaseClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass input, global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.Name = input.Name;
            output.Value = input.Value;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyCompoundTypeAliasClass : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass>
    {
        public global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass Create() => new global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass();
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.Root
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_IA<TRoot, T1, T2, T3> : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::Orleans.Serialization.UnitTests.Root<TRoot>.IA<T1, T2, T3>
    {
        public Proxy_IA(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
        }
    }
}

namespace OrleansCodeGen
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Proxy_IHasNoNamespace : global::Orleans.Serialization.UnitTests.MyInvokableProxyBase, global::IHasNoNamespace
    {
        public Proxy_IHasNoNamespace(global::Orleans.Serialization.Cloning.CopyContextPool arg0, global::Orleans.Serialization.Serializers.CodecProvider arg1) : base(arg0, arg1)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Person : global::Orleans.Serialization.Codecs.IFieldCodec<global::Person>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Person>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Person);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person> _activator;
        private static readonly global::System.Action<global::Person, int> setField0 = (global::System.Action<global::Person, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person, string> setField1 = (global::System.Action<global::Person, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person, string> setField2 = (global::System.Action<global::Person, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Person, string> setField3 = (global::System.Action<global::Person, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person), "<StarSign>k__BackingField");
        public Codec_Person(global::Orleans.Serialization.Activators.IActivator<global::Person> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Person instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Age);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.FavouriteColor);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StarSign);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Person instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id += header.FieldIdDelta;
                    }

                    if (id == 1U)
                    {
                        setField2(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id += header.FieldIdDelta;
                    }

                    if (id == 2U)
                    {
                        setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id += header.FieldIdDelta;
                    }

                    if (id == 3U)
                    {
                        setField3(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Person @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Person))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Person, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Person>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Person : global::Orleans.Serialization.Cloning.IDeepCopier<global::Person>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Person>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person> _activator;
        private static readonly global::System.Action<global::Person, int> setField0 = (global::System.Action<global::Person, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person, string> setField1 = (global::System.Action<global::Person, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person, string> setField2 = (global::System.Action<global::Person, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Person, string> setField3 = (global::System.Action<global::Person, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person), "<StarSign>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person DeepCopy(global::Person original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Person existing))
                return existing;
            if (original.GetType() != typeof(global::Person))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_Person(global::Orleans.Serialization.Activators.IActivator<global::Person> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Person input, global::Person output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.Age);
            setField2(output, input.Name);
            setField1(output, input.FavouriteColor);
            setField3(output, input.StarSign);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Person2 : global::Orleans.Serialization.Codecs.IFieldCodec<global::Person2>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Person2>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Person2);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person2> _activator;
        private static readonly global::System.Action<global::Person2, int> setField0 = (global::System.Action<global::Person2, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person2), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person2, string> setField1 = (global::System.Action<global::Person2, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person2), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person2, string> setField2 = (global::System.Action<global::Person2, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person2), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Person2, string> setField3 = (global::System.Action<global::Person2, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person2), "<StarSign>k__BackingField");
        public Codec_Person2(global::Orleans.Serialization.Activators.IActivator<global::Person2> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Person2 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Age);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.FavouriteColor);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StarSign);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Person2 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id += header.FieldIdDelta;
                    }

                    if (id == 1U)
                    {
                        setField3(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Person2 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Person2))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person2 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Person2, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Person2>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Person2 : global::Orleans.Serialization.Cloning.IDeepCopier<global::Person2>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Person2>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person2> _activator;
        private static readonly global::System.Action<global::Person2, int> setField0 = (global::System.Action<global::Person2, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person2), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person2, string> setField1 = (global::System.Action<global::Person2, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person2), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person2, string> setField2 = (global::System.Action<global::Person2, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person2), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Person2, string> setField3 = (global::System.Action<global::Person2, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person2), "<StarSign>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person2 DeepCopy(global::Person2 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Person2 existing))
                return existing;
            if (original.GetType() != typeof(global::Person2))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_Person2(global::Orleans.Serialization.Activators.IActivator<global::Person2> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Person2 input, global::Person2 output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.Age);
            setField1(output, input.FavouriteColor);
            setField2(output, input.Name);
            setField3(output, input.StarSign);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Person3 : global::Orleans.Serialization.Codecs.IFieldCodec<global::Person3>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Person3>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Person3);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person3> _activator;
        private static readonly global::System.Action<global::Person3, string> setField0 = (global::System.Action<global::Person3, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person3), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person3, string> setField1 = (global::System.Action<global::Person3, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person3), "<StarSign>k__BackingField");
        public Codec_Person3(global::Orleans.Serialization.Activators.IActivator<global::Person3> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Person3 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.FavouriteColor);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StarSign);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Person3 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Person3 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Person3))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person3 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Person3, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Person3>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Person3 : global::Orleans.Serialization.Cloning.IDeepCopier<global::Person3>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Person3>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person3> _activator;
        private static readonly global::System.Action<global::Person3, string> setField0 = (global::System.Action<global::Person3, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person3), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person3, string> setField1 = (global::System.Action<global::Person3, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person3), "<StarSign>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person3 DeepCopy(global::Person3 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Person3 existing))
                return existing;
            if (original.GetType() != typeof(global::Person3))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_Person3(global::Orleans.Serialization.Activators.IActivator<global::Person3> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Person3 input, global::Person3 output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.FavouriteColor);
            setField1(output, input.StarSign);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Person4 : global::Orleans.Serialization.Codecs.IFieldCodec<global::Person4>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Person4>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Person4);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person4> _activator;
        private static readonly global::System.Action<global::Person4, int> setField0 = (global::System.Action<global::Person4, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person4), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person4, string> setField1 = (global::System.Action<global::Person4, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person4), "<Name>k__BackingField");
        public Codec_Person4(global::Orleans.Serialization.Activators.IActivator<global::Person4> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Person4 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Age);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Person4 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }

            id = 0U;
            if (header.IsEndBaseFields)
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Person4 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Person4))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person4 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Person4, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Person4>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Person4 : global::Orleans.Serialization.Cloning.IDeepCopier<global::Person4>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Person4>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person4> _activator;
        private static readonly global::System.Action<global::Person4, int> setField0 = (global::System.Action<global::Person4, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person4), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person4, string> setField1 = (global::System.Action<global::Person4, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person4), "<Name>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person4 DeepCopy(global::Person4 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Person4 existing))
                return existing;
            if (original.GetType() != typeof(global::Person4))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_Person4(global::Orleans.Serialization.Activators.IActivator<global::Person4> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Person4 input, global::Person4 output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.Age);
            setField1(output, input.Name);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Person5 : global::Orleans.Serialization.Codecs.IFieldCodec<global::Person5>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Person5>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Person5);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person5> _activator;
        private static readonly global::System.Action<global::Person5, int> setField0 = (global::System.Action<global::Person5, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person5, string> setField1 = (global::System.Action<global::Person5, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person5, string> setField2 = (global::System.Action<global::Person5, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Person5, string> setField3 = (global::System.Action<global::Person5, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5), "<StarSign>k__BackingField");
        public Codec_Person5(global::Orleans.Serialization.Activators.IActivator<global::Person5> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Person5 instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Age);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.FavouriteColor);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StarSign);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Person5 instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField3(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Person5 @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Person5))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person5 ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Person5, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Person5>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Person5 : global::Orleans.Serialization.Cloning.IDeepCopier<global::Person5>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Person5>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Person5> _activator;
        private static readonly global::System.Action<global::Person5, int> setField0 = (global::System.Action<global::Person5, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person5, string> setField1 = (global::System.Action<global::Person5, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person5, string> setField2 = (global::System.Action<global::Person5, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Person5, string> setField3 = (global::System.Action<global::Person5, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5), "<StarSign>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person5 DeepCopy(global::Person5 original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Person5 existing))
                return existing;
            if (original.GetType() != typeof(global::Person5))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_Person5(global::Orleans.Serialization.Activators.IActivator<global::Person5> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Person5 input, global::Person5 output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.Age);
            setField2(output, input.Name);
            setField1(output, input.FavouriteColor);
            setField3(output, input.StarSign);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Person5_Class : global::Orleans.Serialization.Codecs.IFieldCodec<global::Person5_Class>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Person5_Class>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Person5_Class);
        private static readonly global::System.Action<global::Person5_Class, int> setField0 = (global::System.Action<global::Person5_Class, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5_Class), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person5_Class, string> setField1 = (global::System.Action<global::Person5_Class, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5_Class), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person5_Class, string> setField2 = (global::System.Action<global::Person5_Class, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5_Class), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Person5_Class, string> setField3 = (global::System.Action<global::Person5_Class, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5_Class), "<StarSign>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Person5_Class instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Age);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.FavouriteColor);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StarSign);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Person5_Class instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField0(instance, global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    setField1(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 3U)
                {
                    setField3(instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Person5_Class @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Person5_Class))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person5_Class ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Person5_Class, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Person5_Class();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Person5_Class>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Person5_Class : global::Orleans.Serialization.Cloning.IDeepCopier<global::Person5_Class>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Person5_Class>
    {
        private static readonly global::System.Action<global::Person5_Class, int> setField0 = (global::System.Action<global::Person5_Class, int>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5_Class), "<Age>k__BackingField");
        private static readonly global::System.Action<global::Person5_Class, string> setField1 = (global::System.Action<global::Person5_Class, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5_Class), "<FavouriteColor>k__BackingField");
        private static readonly global::System.Action<global::Person5_Class, string> setField2 = (global::System.Action<global::Person5_Class, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5_Class), "<Name>k__BackingField");
        private static readonly global::System.Action<global::Person5_Class, string> setField3 = (global::System.Action<global::Person5_Class, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetReferenceSetter(typeof(global::Person5_Class), "<StarSign>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Person5_Class DeepCopy(global::Person5_Class original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Person5_Class existing))
                return existing;
            if (original.GetType() != typeof(global::Person5_Class))
                return context.DeepCopy(original);
            var result = new global::Person5_Class();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Person5_Class input, global::Person5_Class output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(output, input.Age);
            setField2(output, input.Name);
            setField1(output, input.FavouriteColor);
            setField3(output, input.StarSign);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_Person5_Class : global::Orleans.Serialization.Activators.IActivator<global::Person5_Class>
    {
        public global::Person5_Class Create() => new global::Person5_Class();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyValue : global::Orleans.Serialization.Codecs.IFieldCodec<global::MyValue>, global::Orleans.Serialization.Serializers.IBaseCodec<global::MyValue>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MyValue);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::MyValue> _activator;
        public Codec_MyValue(global::Orleans.Serialization.Activators.IActivator<global::MyValue> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MyValue instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MyValue instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Value = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MyValue @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::MyValue))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyValue ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MyValue, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::MyValue>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyValue : global::Orleans.Serialization.Cloning.IDeepCopier<global::MyValue>, global::Orleans.Serialization.Cloning.IBaseCopier<global::MyValue>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::MyValue> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyValue DeepCopy(global::MyValue original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::MyValue existing))
                return existing;
            if (original.GetType() != typeof(global::MyValue))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_MyValue(global::Orleans.Serialization.Activators.IActivator<global::MyValue> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::MyValue input, global::MyValue output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Value = input.Value;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyImmutableBase : global::Orleans.Serialization.Codecs.IFieldCodec<global::MyImmutableBase>, global::Orleans.Serialization.Serializers.IBaseCodec<global::MyImmutableBase>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MyImmutableBase);
        private readonly global::System.Type _type0 = typeof(global::MyValue);
        private readonly OrleansCodeGen.Codec_MyValue _codec0;
        public Codec_MyImmutableBase(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyValue>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MyImmutableBase instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.BaseValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MyImmutableBase instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.BaseValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MyImmutableBase @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::MyImmutableBase))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyImmutableBase ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MyImmutableBase, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::MyImmutableBase();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::MyImmutableBase>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyImmutableBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::MyImmutableBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::MyImmutableBase>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyImmutableBase DeepCopy(global::MyImmutableBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return original is null || original.GetType() == typeof(global::MyImmutableBase) ? original : context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::MyImmutableBase input, global::MyImmutableBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.BaseValue = input.BaseValue;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyImmutableBase : global::Orleans.Serialization.Activators.IActivator<global::MyImmutableBase>
    {
        public global::MyImmutableBase Create() => new global::MyImmutableBase();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyMutableSub : global::Orleans.Serialization.Codecs.IFieldCodec<global::MyMutableSub>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MyMutableSub);
        private readonly OrleansCodeGen.Codec_MyImmutableBase _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(global::MyValue);
        private readonly OrleansCodeGen.Codec_MyValue _codec0;
        public Codec_MyMutableSub(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyImmutableBase>(this, codecProvider);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyValue>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MyMutableSub instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.SubValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MyMutableSub instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SubValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MyMutableSub @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyMutableSub ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MyMutableSub, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::MyMutableSub();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyMutableSub : global::Orleans.Serialization.Cloning.IDeepCopier<global::MyMutableSub>
    {
        private readonly OrleansCodeGen.Copier_MyImmutableBase _baseTypeCopier;
        private readonly OrleansCodeGen.Copier_MyValue _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyMutableSub DeepCopy(global::MyMutableSub original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::MyMutableSub existing))
                return existing;
            var result = new global::MyMutableSub();
            context.RecordCopy(original, result);
            _baseTypeCopier.DeepCopy(original, result, context);
            result.SubValue = _copier0.DeepCopy(original.SubValue, context);
            return result;
        }

        public Copier_MyMutableSub(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Copier_MyImmutableBase>(this, codecProvider);
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Copier_MyValue>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyMutableSub : global::Orleans.Serialization.Activators.IActivator<global::MyMutableSub>
    {
        public global::MyMutableSub Create() => new global::MyMutableSub();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyImmutableSub : global::Orleans.Serialization.Codecs.IFieldCodec<global::MyImmutableSub>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MyImmutableSub);
        private readonly OrleansCodeGen.Codec_MyImmutableBase _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(global::MyValue);
        private readonly OrleansCodeGen.Codec_MyValue _codec0;
        public Codec_MyImmutableSub(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyImmutableBase>(this, codecProvider);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyValue>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MyImmutableSub instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.SubValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MyImmutableSub instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SubValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MyImmutableSub @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyImmutableSub ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MyImmutableSub, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::MyImmutableSub();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyImmutableSub : global::Orleans.Serialization.Activators.IActivator<global::MyImmutableSub>
    {
        public global::MyImmutableSub Create() => new global::MyImmutableSub();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyMutableBase : global::Orleans.Serialization.Codecs.IFieldCodec<global::MyMutableBase>, global::Orleans.Serialization.Serializers.IBaseCodec<global::MyMutableBase>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MyMutableBase);
        private readonly global::System.Type _type0 = typeof(global::MyValue);
        private readonly OrleansCodeGen.Codec_MyValue _codec0;
        public Codec_MyMutableBase(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyValue>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MyMutableBase instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.BaseValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MyMutableBase instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.BaseValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MyMutableBase @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::MyMutableBase))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyMutableBase ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MyMutableBase, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::MyMutableBase();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::MyMutableBase>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyMutableBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::MyMutableBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::MyMutableBase>
    {
        private readonly OrleansCodeGen.Copier_MyValue _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyMutableBase DeepCopy(global::MyMutableBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::MyMutableBase existing))
                return existing;
            if (original.GetType() != typeof(global::MyMutableBase))
                return context.DeepCopy(original);
            var result = new global::MyMutableBase();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_MyMutableBase(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Copier_MyValue>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::MyMutableBase input, global::MyMutableBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.BaseValue = _copier0.DeepCopy(input.BaseValue, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyMutableBase : global::Orleans.Serialization.Activators.IActivator<global::MyMutableBase>
    {
        public global::MyMutableBase Create() => new global::MyMutableBase();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MySealedSub : global::Orleans.Serialization.Codecs.IFieldCodec<global::MySealedSub>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MySealedSub);
        private readonly OrleansCodeGen.Codec_MyMutableBase _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(global::MyValue);
        private readonly OrleansCodeGen.Codec_MyValue _codec0;
        public Codec_MySealedSub(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyMutableBase>(this, codecProvider);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyValue>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MySealedSub instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.SubValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MySealedSub instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SubValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MySealedSub @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MySealedSub ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MySealedSub, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::MySealedSub();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MySealedSub : global::Orleans.Serialization.Cloning.IDeepCopier<global::MySealedSub>
    {
        private readonly OrleansCodeGen.Copier_MyMutableBase _baseTypeCopier;
        private readonly OrleansCodeGen.Copier_MyValue _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MySealedSub DeepCopy(global::MySealedSub original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::MySealedSub existing))
                return existing;
            var result = new global::MySealedSub();
            context.RecordCopy(original, result);
            _baseTypeCopier.DeepCopy(original, result, context);
            result.SubValue = _copier0.DeepCopy(original.SubValue, context);
            return result;
        }

        public Copier_MySealedSub(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Copier_MyMutableBase>(this, codecProvider);
            _copier0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Copier_MyValue>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MySealedSub : global::Orleans.Serialization.Activators.IActivator<global::MySealedSub>
    {
        public global::MySealedSub Create() => new global::MySealedSub();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MySealedImmutableSub : global::Orleans.Serialization.Codecs.IFieldCodec<global::MySealedImmutableSub>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MySealedImmutableSub);
        private readonly OrleansCodeGen.Codec_MyMutableBase _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(global::MyValue);
        private readonly OrleansCodeGen.Codec_MyValue _codec0;
        public Codec_MySealedImmutableSub(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyMutableBase>(this, codecProvider);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyValue>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MySealedImmutableSub instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.SubValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MySealedImmutableSub instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SubValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MySealedImmutableSub @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MySealedImmutableSub ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MySealedImmutableSub, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::MySealedImmutableSub();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MySealedImmutableSub : global::Orleans.Serialization.Activators.IActivator<global::MySealedImmutableSub>
    {
        public global::MySealedImmutableSub Create() => new global::MySealedImmutableSub();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyUnsealedImmutableSub : global::Orleans.Serialization.Codecs.IFieldCodec<global::MyUnsealedImmutableSub>, global::Orleans.Serialization.Serializers.IBaseCodec<global::MyUnsealedImmutableSub>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MyUnsealedImmutableSub);
        private readonly OrleansCodeGen.Codec_MyMutableBase _baseTypeSerializer;
        private readonly global::System.Type _type0 = typeof(global::MyValue);
        private readonly OrleansCodeGen.Codec_MyValue _codec0;
        public Codec_MyUnsealedImmutableSub(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyMutableBase>(this, codecProvider);
            _codec0 = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyValue>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MyUnsealedImmutableSub instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.SubValue);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MyUnsealedImmutableSub instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SubValue = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MyUnsealedImmutableSub @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::MyUnsealedImmutableSub))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyUnsealedImmutableSub ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MyUnsealedImmutableSub, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::MyUnsealedImmutableSub();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::MyUnsealedImmutableSub>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyUnsealedImmutableSub : global::Orleans.Serialization.Cloning.IDeepCopier<global::MyUnsealedImmutableSub>, global::Orleans.Serialization.Cloning.IBaseCopier<global::MyUnsealedImmutableSub>
    {
        private readonly OrleansCodeGen.Copier_MyMutableBase _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyUnsealedImmutableSub DeepCopy(global::MyUnsealedImmutableSub original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return original is null || original.GetType() == typeof(global::MyUnsealedImmutableSub) ? original : context.DeepCopy(original);
        }

        public Copier_MyUnsealedImmutableSub(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Copier_MyMutableBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::MyUnsealedImmutableSub input, global::MyUnsealedImmutableSub output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.SubValue = input.SubValue;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyUnsealedImmutableSub : global::Orleans.Serialization.Activators.IActivator<global::MyUnsealedImmutableSub>
    {
        public global::MyUnsealedImmutableSub Create() => new global::MyUnsealedImmutableSub();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MySuppressReferenceTrackingValue : global::Orleans.Serialization.Codecs.IFieldCodec<global::MySuppressReferenceTrackingValue>, global::Orleans.Serialization.Serializers.IBaseCodec<global::MySuppressReferenceTrackingValue>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MySuppressReferenceTrackingValue);
        private readonly OrleansCodeGen.Codec_MyValue _baseTypeSerializer;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::MySuppressReferenceTrackingValue> _activator;
        public Codec_MySuppressReferenceTrackingValue(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::MySuppressReferenceTrackingValue> _activator)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Codec_MyValue>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MySuppressReferenceTrackingValue instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MySuppressReferenceTrackingValue instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MySuppressReferenceTrackingValue @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::MySuppressReferenceTrackingValue))
            {
                if (@value is null)
                {
                    ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                    return;
                }

                ReferenceCodec.MarkValueField(writer.Session);
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MySuppressReferenceTrackingValue ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MySuppressReferenceTrackingValue, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::MySuppressReferenceTrackingValue>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MySuppressReferenceTrackingValue : global::Orleans.Serialization.Cloning.IDeepCopier<global::MySuppressReferenceTrackingValue>, global::Orleans.Serialization.Cloning.IBaseCopier<global::MySuppressReferenceTrackingValue>
    {
        private readonly OrleansCodeGen.Copier_MyValue _baseTypeCopier;
        private readonly global::Orleans.Serialization.Activators.IActivator<global::MySuppressReferenceTrackingValue> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MySuppressReferenceTrackingValue DeepCopy(global::MySuppressReferenceTrackingValue original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (original is null)
                return null;
            if (original.GetType() != typeof(global::MySuppressReferenceTrackingValue))
                return context.DeepCopy(original);
            var result = _activator.Create();
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_MySuppressReferenceTrackingValue(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider, global::Orleans.Serialization.Activators.IActivator<global::MySuppressReferenceTrackingValue> _activator)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Copier_MyValue>(this, codecProvider);
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::MySuppressReferenceTrackingValue input, global::MySuppressReferenceTrackingValue output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyCustomException : global::Orleans.Serialization.Codecs.IFieldCodec<global::MyCustomException>, global::Orleans.Serialization.Serializers.IBaseCodec<global::MyCustomException>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MyCustomException);
        private readonly global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer;
        public Codec_MyCustomException(global::Orleans.Serialization.Serializers.IBaseCodec<global::System.Exception> _baseTypeSerializer)
        {
            this._baseTypeSerializer = OrleansGeneratedCodeHelper.UnwrapService(this, _baseTypeSerializer);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::MyCustomException instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.CustomInt);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::MyCustomException instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.CustomInt = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MyCustomException @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::MyCustomException))
            {
                if (@value is null)
                {
                    ReferenceCodec.WriteNullReference(ref writer, fieldIdDelta);
                    return;
                }

                ReferenceCodec.MarkValueField(writer.Session);
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyCustomException ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::MyCustomException, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::MyCustomException();
                ReferenceCodec.MarkValueField(reader.Session);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::MyCustomException>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_MyCustomException : global::Orleans.Serialization.GeneratedCodeHelpers.OrleansGeneratedCodeHelper.ExceptionCopier<global::MyCustomException, global::System.Exception>
    {
        public Copier_MyCustomException(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider) : base(codecProvider)
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void DeepCopy(global::MyCustomException input, global::MyCustomException output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            base.DeepCopy(input, output, context);
            output.CustomInt = input.CustomInt;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_MyCustomException : global::Orleans.Serialization.Activators.IActivator<global::MyCustomException>
    {
        public global::MyCustomException Create() => new global::MyCustomException();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_MyCustomForeignExceptionSurrogate : global::Orleans.Serialization.Codecs.IFieldCodec<global::MyCustomForeignExceptionSurrogate>, global::Orleans.Serialization.Serializers.IValueSerializer<global::MyCustomForeignExceptionSurrogate>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::MyCustomForeignExceptionSurrogate);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::MyCustomForeignExceptionSurrogate instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.CustomInt);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::MyCustomForeignExceptionSurrogate instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.CustomInt = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::MyCustomForeignExceptionSurrogate @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::MyCustomForeignExceptionSurrogate ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::MyCustomForeignExceptionSurrogate);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_SomeClassWithSerializers : global::Orleans.Serialization.Codecs.IFieldCodec<global::SomeClassWithSerializers>, global::Orleans.Serialization.Serializers.IBaseCodec<global::SomeClassWithSerializers>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::SomeClassWithSerializers);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::SomeClassWithSerializers instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.IntProperty);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.IntField);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::SomeClassWithSerializers instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.IntProperty = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.IntField = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::SomeClassWithSerializers @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::SomeClassWithSerializers))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::SomeClassWithSerializers ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::SomeClassWithSerializers, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::SomeClassWithSerializers();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::SomeClassWithSerializers>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_SomeClassWithSerializers : global::Orleans.Serialization.Cloning.IDeepCopier<global::SomeClassWithSerializers>, global::Orleans.Serialization.Cloning.IBaseCopier<global::SomeClassWithSerializers>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::SomeClassWithSerializers DeepCopy(global::SomeClassWithSerializers original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::SomeClassWithSerializers existing))
                return existing;
            if (original.GetType() != typeof(global::SomeClassWithSerializers))
                return context.DeepCopy(original);
            var result = new global::SomeClassWithSerializers();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::SomeClassWithSerializers input, global::SomeClassWithSerializers output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.IntProperty = input.IntProperty;
            output.IntField = input.IntField;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_SomeClassWithSerializers : global::Orleans.Serialization.Activators.IActivator<global::SomeClassWithSerializers>
    {
        public global::SomeClassWithSerializers Create() => new global::SomeClassWithSerializers();
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_CaseInsensitiveEqualityComparer : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_CaseInsensitiveEqualityComparer : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer DeepCopy(global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer input, global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_CaseInsensitiveEqualityComparer : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer>
    {
        public global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer Create() => new global::Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.CaseInsensitiveEqualityComparer();
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.NestedGeneric
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Nested<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested);
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_Nested(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Value = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Nested<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested DeepCopy(global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_Nested(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested input, global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Value = _copier0.DeepCopy(input.Value, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_Nested<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested>
    {
        public global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested Create() => new global::Orleans.Serialization.UnitTests.NestedGeneric<T>.Nested();
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.NestedConstructedGeneric
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Nested<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>);
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_Nested(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Value = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_Nested<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> DeepCopy(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_Nested(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> input, global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Value = _copier0.DeepCopy(input.Value, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_Nested<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>>
    {
        public global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T> Create() => new global::Orleans.Serialization.UnitTests.NestedConstructedGeneric.Nested<T>();
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.ManualVersionToleranceTests
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ObjectWithNewField : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField> _activator;
        public Codec_ObjectWithNewField(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Blah);
            global::Orleans.Serialization.Codecs.ObjectCodec.WriteField(ref writer, 1U, instance.NewField);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.Version);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Blah = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.NewField = global::Orleans.Serialization.Codecs.ObjectCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 2U)
                {
                    instance.Version = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ObjectWithNewField : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField DeepCopy(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_ObjectWithNewField(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField input, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithNewField output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Blah = input.Blah;
            output.NewField = global::Orleans.Serialization.Codecs.ObjectCopier.DeepCopy(input.NewField, context);
            output.Version = input.Version;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ObjectWithoutNewField : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField);
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField> _activator;
        public Codec_ObjectWithoutNewField(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.Blah);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.Version);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Blah = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Version = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = _activator.Create();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ObjectWithoutNewField : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField>
    {
        private readonly global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField> _activator;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField DeepCopy(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField))
                return context.DeepCopy(original);
            var result = _activator.Create();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_ObjectWithoutNewField(global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField> _activator)
        {
            this._activator = OrleansGeneratedCodeHelper.UnwrapService(this, _activator);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField input, global::Orleans.Serialization.UnitTests.ManualVersionToleranceTests.ObjectWithoutNewField output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.Blah = input.Blah;
            output.Version = input.Version;
        }
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.Outer
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_InnerNonGen<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_InnerNonGen<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen DeepCopy(global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen input, global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_InnerNonGen<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen>
    {
        public global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen Create() => new global::Orleans.Serialization.UnitTests.Outer<T>.InnerNonGen();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_InnerGen<T, U> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> instance)
        {
            reader.ConsumeEndBaseOrEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_InnerGen<T, U> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> DeepCopy(global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> input, global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_InnerGen<T, U> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>>
    {
        public global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U> Create() => new global::Orleans.Serialization.UnitTests.Outer<T>.InnerGen<U>();
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ValueHolder<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T>);
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_ValueHolder(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.Value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Value = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                return;
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T>, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            var result = new global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T>();
            ReferenceCodec.RecordObject(reader.Session, result);
            Deserialize(ref reader, result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ValueHolder<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T> DeepCopy(global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T> existing))
                return existing;
            var result = new global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T>();
            context.RecordCopy(original, result);
            result.Value = _copier0.DeepCopy(original.Value, context);
            return result;
        }

        public Copier_ValueHolder(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_ValueHolder<T> : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T>>
    {
        public global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T> Create() => new global::Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.ValueHolder<T>();
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_SomeBaseClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.SbcString);
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 1U, instance.SbcInteger);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SbcString = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.SbcInteger = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_SomeBaseClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass DeepCopy(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass input, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            output.SbcString = input.SbcString;
            output.SbcInteger = input.SbcInteger;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_SomeBaseClass : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass>
    {
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass Create() => new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_SomeSubClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeBaseClass _baseTypeSerializer;
        public Codec_SomeSubClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeBaseClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.SscInteger);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.SscString);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SscInteger = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.SscString = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_SomeSubClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeBaseClass _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass DeepCopy(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_SomeSubClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeBaseClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass input, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.SscInteger = input.SscInteger;
            output.SscString = input.SscString;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_SomeSubClass : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass>
    {
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass Create() => new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_OtherSubClass : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeBaseClass _baseTypeSerializer;
        public Codec_OtherSubClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeBaseClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.OtherSubClassInt);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.OtherSubClassString);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.OtherSubClassInt = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.OtherSubClassString = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_OtherSubClass : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeBaseClass _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass DeepCopy(global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_OtherSubClass(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeBaseClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass input, global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.OtherSubClassInt = input.OtherSubClassInt;
            output.OtherSubClassString = input.OtherSubClassString;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_OtherSubClass : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass>
    {
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass Create() => new global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass();
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_SomeSubClassChild : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild>, global::Orleans.Serialization.Serializers.IBaseCodec<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild);
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeSubClass _baseTypeSerializer;
        public Codec_SomeSubClassChild(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeSubClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.SomeSubClassChildInt);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.SomeSubClassChildString);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.SomeSubClassChildInt = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.SomeSubClassChildString = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            if (@value is null || @value.GetType() == typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild))
            {
                if (ReferenceCodec.TryWriteReferenceField(ref writer, fieldIdDelta, expectedType, @value))
                    return;
                writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
                Serialize(ref writer, @value);
                writer.WriteEndObject();
            }
            else
                writer.SerializeUnexpectedType(fieldIdDelta, expectedType, @value);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            if (field.IsReference)
                return ReferenceCodec.ReadReference<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild, TReaderInput>(ref reader, field);
            field.EnsureWireTypeTagDelimited();
            global::System.Type valueType = field.FieldType;
            if (valueType is null || valueType == _codecFieldType)
            {
                var result = new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild();
                ReferenceCodec.RecordObject(reader.Session, result);
                Deserialize(ref reader, result);
                return result;
            }

            return reader.DeserializeUnexpectedType<TReaderInput, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild>(ref field);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_SomeSubClassChild : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeSubClass _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild DeepCopy(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            if (context.TryGetCopy(original, out global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild existing))
                return existing;
            if (original.GetType() != typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild))
                return context.DeepCopy(original);
            var result = new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild();
            context.RecordCopy(original, result);
            DeepCopy(original, result, context);
            return result;
        }

        public Copier_SomeSubClassChild(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeSubClass>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild input, global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
            output.SomeSubClassChildInt = input.SomeSubClassChildInt;
            output.SomeSubClassChildString = input.SomeSubClassChildString;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Activator_SomeSubClassChild : global::Orleans.Serialization.Activators.IActivator<global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild>
    {
        public global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild Create() => new global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild();
    }
}

namespace OrleansCodeGen.Orleans.Serialization.UnitTests.PooledBufferTests
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_LargeObject : global::Orleans.Serialization.Codecs.IFieldCodec<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject>, global::Orleans.Serialization.Serializers.IValueSerializer<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject);
        private readonly global::System.Type _type0 = typeof((global::System.Guid, global::System.Guid)[]);
        private readonly global::Orleans.Serialization.Codecs.ArrayCodec<(global::System.Guid, global::System.Guid)> _codec0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject, global::System.Guid> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject, global::System.Guid>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject), "<Id>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject, (global::System.Guid, global::System.Guid)[]> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject, (global::System.Guid, global::System.Guid)[]>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject), "<Values>k__BackingField");
        public Codec_LargeObject(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCodec<(global::System.Guid, global::System.Guid)>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.GuidCodec.WriteField(ref writer, 0U, instance.Id);
            _codec0.WriteField(ref writer, 1U, _type0, instance.Values);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            {
                reader.ReadFieldHeader(ref header);
                reader.ConsumeEndBaseOrEndObject(ref header);
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        setField0(ref instance, global::Orleans.Serialization.Codecs.GuidCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id += header.FieldIdDelta;
                    }

                    if (id == 1U)
                    {
                        setField1(ref instance, _codec0.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_LargeObject : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject>
    {
        private readonly global::Orleans.Serialization.Codecs.ArrayCopier<(global::System.Guid, global::System.Guid)> _copier0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject, (global::System.Guid, global::System.Guid)[]> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject, (global::System.Guid, global::System.Guid)[]>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject), "<Values>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject DeepCopy(global::Orleans.Serialization.UnitTests.PooledBufferTests.LargeObject result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField1(ref result, _copier0.DeepCopy(result.Values, context));
            return result;
        }

        public Copier_LargeObject(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.ArrayCopier<(global::System.Guid, global::System.Guid)>>(this, codecProvider);
        }
    }
}

namespace OrleansCodeGen.Orleans.Serialization.Invocation
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_UnitTestRequestBase : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.Invocation.UnitTestRequestBase>
    {
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_UnitTestRequestBase : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Invocation.UnitTestRequestBase>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestRequestBase>
    {
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Invocation.UnitTestRequestBase DeepCopy(global::Orleans.Serialization.Invocation.UnitTestRequestBase original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.Invocation.UnitTestRequestBase input, global::Orleans.Serialization.Invocation.UnitTestRequestBase output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_UnitTestRequest : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.Invocation.UnitTestRequest>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase _baseTypeSerializer;
        public Codec_UnitTestRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.Invocation.UnitTestRequest instance)
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.Invocation.UnitTestRequest instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_UnitTestRequest : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Invocation.UnitTestRequest>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestRequest>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Invocation.UnitTestRequest DeepCopy(global::Orleans.Serialization.Invocation.UnitTestRequest original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        public Copier_UnitTestRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.Invocation.UnitTestRequest input, global::Orleans.Serialization.Invocation.UnitTestRequest output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_UnitTestRequest<TResult> : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.Invocation.UnitTestRequest<TResult>>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase _baseTypeSerializer;
        public Codec_UnitTestRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.Invocation.UnitTestRequest<TResult> instance)
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.Invocation.UnitTestRequest<TResult> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_UnitTestRequest<TResult> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Invocation.UnitTestRequest<TResult>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestRequest<TResult>>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Invocation.UnitTestRequest<TResult> DeepCopy(global::Orleans.Serialization.Invocation.UnitTestRequest<TResult> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        public Copier_UnitTestRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.Invocation.UnitTestRequest<TResult> input, global::Orleans.Serialization.Invocation.UnitTestRequest<TResult> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_UnitTestTaskRequest<TResult> : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult>>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase _baseTypeSerializer;
        public Codec_UnitTestTaskRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult> instance)
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult> instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_UnitTestTaskRequest<TResult> : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult>>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult>>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult> DeepCopy(global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult> original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        public Copier_UnitTestTaskRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult> input, global::Orleans.Serialization.Invocation.UnitTestTaskRequest<TResult> output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_UnitTestTaskRequest : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.Invocation.UnitTestTaskRequest>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase _baseTypeSerializer;
        public Codec_UnitTestTaskRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.Invocation.UnitTestTaskRequest instance)
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.Invocation.UnitTestTaskRequest instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_UnitTestTaskRequest : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestTaskRequest>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Invocation.UnitTestTaskRequest DeepCopy(global::Orleans.Serialization.Invocation.UnitTestTaskRequest original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        public Copier_UnitTestTaskRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.Invocation.UnitTestTaskRequest input, global::Orleans.Serialization.Invocation.UnitTestTaskRequest output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_UnitTestVoidRequest : global::Orleans.Serialization.Serializers.AbstractTypeSerializer<global::Orleans.Serialization.Invocation.UnitTestVoidRequest>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase _baseTypeSerializer;
        public Codec_UnitTestVoidRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeSerializer = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, global::Orleans.Serialization.Invocation.UnitTestVoidRequest instance)
        {
            _baseTypeSerializer.Serialize(ref writer, instance);
            writer.WriteEndBase();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public override void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.Invocation.UnitTestVoidRequest instance)
        {
            _baseTypeSerializer.Deserialize(ref reader, instance);
            reader.ConsumeEndBaseOrEndObject();
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_UnitTestVoidRequest : global::Orleans.Serialization.Cloning.IDeepCopier<global::Orleans.Serialization.Invocation.UnitTestVoidRequest>, global::Orleans.Serialization.Cloning.IBaseCopier<global::Orleans.Serialization.Invocation.UnitTestVoidRequest>
    {
        private readonly OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase _baseTypeCopier;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::Orleans.Serialization.Invocation.UnitTestVoidRequest DeepCopy(global::Orleans.Serialization.Invocation.UnitTestVoidRequest original, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            return context.DeepCopy(original);
        }

        public Copier_UnitTestVoidRequest(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _baseTypeCopier = OrleansGeneratedCodeHelper.GetService<OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void DeepCopy(global::Orleans.Serialization.Invocation.UnitTestVoidRequest input, global::Orleans.Serialization.Invocation.UnitTestVoidRequest output, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            _baseTypeCopier.DeepCopy(input, output, context);
        }
    }
}

namespace OrleansCodeGen.UnitTests.SerializerExternalModels
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_Person2ExternalStruct : global::Orleans.Serialization.Codecs.IFieldCodec<global::UnitTests.SerializerExternalModels.Person2ExternalStruct>, global::Orleans.Serialization.Serializers.IValueSerializer<global::UnitTests.SerializerExternalModels.Person2ExternalStruct>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::UnitTests.SerializerExternalModels.Person2ExternalStruct);
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::UnitTests.SerializerExternalModels.Person2ExternalStruct instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            global::Orleans.Serialization.Codecs.Int32Codec.WriteField(ref writer, 0U, instance.Age);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
            writer.WriteEndBase();
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 0U, instance.FavouriteColor);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StarSign);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::UnitTests.SerializerExternalModels.Person2ExternalStruct instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.Age = global::Orleans.Serialization.Codecs.Int32Codec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Name = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        instance.FavouriteColor = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id += header.FieldIdDelta;
                    }

                    if (id == 1U)
                    {
                        instance.StarSign = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::UnitTests.SerializerExternalModels.Person2ExternalStruct @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::UnitTests.SerializerExternalModels.Person2ExternalStruct ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::UnitTests.SerializerExternalModels.Person2ExternalStruct);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_GenericPersonExternalStruct<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T>);
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        public Codec_GenericPersonExternalStruct(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.CtorParam);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.BodyParam);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StarSign);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    instance.CtorParam = _codec0.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    instance.Name = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        instance.BodyParam = _codec0.ReadValue(ref reader, header);
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id += header.FieldIdDelta;
                    }

                    if (id == 1U)
                    {
                        instance.StarSign = global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header);
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_GenericPersonExternalStruct<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T> DeepCopy(global::UnitTests.SerializerExternalModels.GenericPersonExternalStruct<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            result.BodyParam = _copier0.DeepCopy(result.BodyParam, context);
            result.CtorParam = _copier0.DeepCopy(result.CtorParam, context);
            return result;
        }

        public Copier_GenericPersonExternalStruct(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Codec_ReadonlyGenericPersonExternalStruct<T> : global::Orleans.Serialization.Codecs.IFieldCodec<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>>, global::Orleans.Serialization.Serializers.IValueSerializer<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>>
    {
        private readonly global::System.Type _codecFieldType = typeof(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>);
        private readonly global::System.Type _type0 = typeof(T);
        private readonly global::Orleans.Serialization.Codecs.IFieldCodec<T> _codec0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, T> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, T>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>), "<BodyParam>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, T> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, T>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>), "<CtorParam>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, string> setField2 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>), "<Name>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, string> setField3 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, string>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>), "<StarSign>k__BackingField");
        public Codec_ReadonlyGenericPersonExternalStruct(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _codec0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Codecs.IFieldCodec<T>>(this, codecProvider);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Serialize<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, scoped ref global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T> instance)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            _codec0.WriteField(ref writer, 0U, _type0, instance.CtorParam);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.Name);
            writer.WriteEndBase();
            _codec0.WriteField(ref writer, 0U, _type0, instance.BodyParam);
            global::Orleans.Serialization.Codecs.StringCodec.WriteField(ref writer, 1U, instance.StarSign);
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void Deserialize<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, scoped ref global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T> instance)
        {
            uint id = 0U;
            global::Orleans.Serialization.WireProtocol.Field header = default;
            while (true)
            {
                reader.ReadFieldHeader(ref header);
                if (header.IsEndBaseOrEndObject)
                    break;
                id += header.FieldIdDelta;
                if (id == 0U)
                {
                    setField1(ref instance, _codec0.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                }

                if (id == 1U)
                {
                    setField2(ref instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                    reader.ReadFieldHeader(ref header);
                }

                reader.ConsumeEndBaseOrEndObject(ref header);
                break;
            }

            id = 0U;
            if (header.IsEndBaseFields)
                while (true)
                {
                    reader.ReadFieldHeader(ref header);
                    if (header.IsEndBaseOrEndObject)
                        break;
                    id += header.FieldIdDelta;
                    if (id == 0U)
                    {
                        setField0(ref instance, _codec0.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                        if (header.IsEndBaseOrEndObject)
                            break;
                        id += header.FieldIdDelta;
                    }

                    if (id == 1U)
                    {
                        setField3(ref instance, global::Orleans.Serialization.Codecs.StringCodec.ReadValue(ref reader, header));
                        reader.ReadFieldHeader(ref header);
                    }

                    reader.ConsumeEndBaseOrEndObject(ref header);
                    break;
                }
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public void WriteField<TBufferWriter>(ref global::Orleans.Serialization.Buffers.Writer<TBufferWriter> writer, uint fieldIdDelta, global::System.Type expectedType, global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T> @value)
            where TBufferWriter : global::System.Buffers.IBufferWriter<byte>
        {
            ReferenceCodec.MarkValueField(writer.Session);
            writer.WriteStartObject(fieldIdDelta, expectedType, _codecFieldType);
            Serialize(ref writer, ref @value);
            writer.WriteEndObject();
        }

        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T> ReadValue<TReaderInput>(ref global::Orleans.Serialization.Buffers.Reader<TReaderInput> reader, global::Orleans.Serialization.WireProtocol.Field field)
        {
            field.EnsureWireTypeTagDelimited();
            var result = default(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>);
            ReferenceCodec.MarkValueField(reader.Session);
            Deserialize(ref reader, ref result);
            return result;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    public sealed class Copier_ReadonlyGenericPersonExternalStruct<T> : global::Orleans.Serialization.Cloning.IDeepCopier<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>>
    {
        private readonly global::Orleans.Serialization.Cloning.IDeepCopier<T> _copier0;
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, T> setField0 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, T>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>), "<BodyParam>k__BackingField");
        private static readonly global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, T> setField1 = (global::Orleans.Serialization.Utilities.ValueTypeSetter<global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>, T>)global::Orleans.Serialization.Utilities.FieldAccessor.GetValueSetter(typeof(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T>), "<CtorParam>k__BackingField");
        [global::System.Runtime.CompilerServices.MethodImplAttribute(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T> DeepCopy(global::UnitTests.SerializerExternalModels.ReadonlyGenericPersonExternalStruct<T> result, global::Orleans.Serialization.Cloning.CopyContext context)
        {
            setField0(ref result, _copier0.DeepCopy(result.BodyParam, context));
            setField1(ref result, _copier0.DeepCopy(result.CtorParam, context));
            return result;
        }

        public Copier_ReadonlyGenericPersonExternalStruct(global::Orleans.Serialization.Serializers.ICodecProvider codecProvider)
        {
            _copier0 = OrleansGeneratedCodeHelper.GetService<global::Orleans.Serialization.Cloning.IDeepCopier<T>>(this, codecProvider);
        }
    }
}

namespace OrleansCodeGen.OrleansSerializationUnitTests
{
    using global::Orleans.Serialization.Codecs;
    using global::Orleans.Serialization.GeneratedCodeHelpers;

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("OrleansCodeGen", "9.0.0.0"), global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never), global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute]
    internal sealed class Metadata_OrleansSerializationUnitTests : global::Orleans.Serialization.Configuration.TypeManifestProviderBase
    {
        protected override void ConfigureInner(global::Orleans.Serialization.Configuration.TypeManifestOptions config)
        {
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyEnum));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_TypeWithListBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_TypeWithCollectionBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_TypeWithDictionaryBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.Codec_CaseInsensitiveEqualityComparer));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_TypeWithHashSetBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Base<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<,,,,, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<,, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<,, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_GenericGrainState<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_event));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NestedGeneric<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NestedGeneric.Codec_Nested<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NestedConstructedGeneric));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NestedConstructedGeneric.Codec_Nested<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.ManualVersionToleranceTests.Codec_ObjectWithNewField));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.ManualVersionToleranceTests.Codec_ObjectWithoutNewField));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyForeignLibraryTypeSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_WrapsMyForeignLibraryType));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_DerivedFromMyForeignLibraryType));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyForeignLibraryValueTypeSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_WrapsMyForeignLibraryValueType));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyNonJsonBaseClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyCustomEnum));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecursiveClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_SomeClassWithSerializers));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_PocoWithAutogeneratedIds));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_SerializableClassWithCompiledBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_DerivedFromDictionary<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_GenericPoco<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_GenericPocoWithConstraint<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Outer.Codec_InnerNonGen<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Outer.Codec_InnerGen<, >));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_ArrayPoco<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_ImmutableClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_ImmutableStruct));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_SystemCollectionsClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_ClassWithLargeCollectionAndUri));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_ClassWithManualSerializableProperty));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_ClassWithImplicitFieldIds));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_ClassWithTypeFields));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyFirstForeignLibraryTypeSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MySecondForeignLibraryTypeSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.Codec_ValueHolder<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_CustomException));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeBaseClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeSubClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_OtherSubClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Codec_SomeSubClassChild));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PooledBufferTests.Codec_LargeObject));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_EmptyAbstractRecord));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_DerivedFromEmptyAbstractRecord));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_NonEmptyAbstractRecord));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_DerivedFromNonEmptyAbstractRecord));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecordHierarchyDerived));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecordHierarchyMiddle));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_RecordHierarchyBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooWithListOfObject));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_TwoObjects));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooWithListOfFruit));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooWithListOfApple));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FruitRecord));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_AppleRecord));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_FooRecord));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyCompoundTypeAliasBaseClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Codec_MyCompoundTypeAliasClass));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequestBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestRequest<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestTaskRequest<>));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestTaskRequest));
            config.Serializers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Codec_UnitTestVoidRequest));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_Person));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_Person2));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_Person3));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_Person4));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_Person5));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_Person5_Class));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MyValue));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MyImmutableBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MyMutableSub));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MyImmutableSub));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MyMutableBase));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MySealedSub));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MySealedImmutableSub));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MyUnsealedImmutableSub));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MySuppressReferenceTrackingValue));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MyCustomException));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_MyCustomForeignExceptionSurrogate));
            config.Serializers.Add(typeof(OrleansCodeGen.Codec_SomeClassWithSerializers));
            config.Serializers.Add(typeof(OrleansCodeGen.UnitTests.SerializerExternalModels.Codec_Person2ExternalStruct));
            config.Serializers.Add(typeof(OrleansCodeGen.UnitTests.SerializerExternalModels.Codec_GenericPersonExternalStruct<>));
            config.Serializers.Add(typeof(OrleansCodeGen.UnitTests.SerializerExternalModels.Codec_ReadonlyGenericPersonExternalStruct<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_TypeWithListBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_TypeWithCollectionBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_TypeWithDictionaryBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.Copier_CaseInsensitiveEqualityComparer));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_TypeWithHashSetBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Base<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<,,,,, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<,, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<,, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_GenericGrainState<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_event));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedGeneric<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NestedGeneric.Copier_Nested<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NestedConstructedGeneric));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NestedConstructedGeneric.Copier_Nested<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.ManualVersionToleranceTests.Copier_ObjectWithNewField));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.ManualVersionToleranceTests.Copier_ObjectWithoutNewField));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogate>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_WrapsMyForeignLibraryType));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_DerivedFromMyForeignLibraryType));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogate>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.UnitTests.WrapsMyForeignLibraryValueType>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_MyNonJsonBaseClass));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecursiveClass));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_SomeClassWithSerializers));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_PocoWithAutogeneratedIds));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_SerializableClassWithCompiledBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_DerivedFromDictionary<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_GenericPoco<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_GenericPocoWithConstraint<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Outer.Copier_InnerNonGen<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Outer.Copier_InnerGen<, >));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_ArrayPoco<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_ImmutableClass));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.UnitTests.ImmutableStruct>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_SystemCollectionsClass));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_ClassWithLargeCollectionAndUri));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_ClassWithManualSerializableProperty));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_ClassWithImplicitFieldIds));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_ClassWithTypeFields));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.UnitTests.MyFirstForeignLibraryTypeSurrogate>));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::Orleans.Serialization.UnitTests.MySecondForeignLibraryTypeSurrogate>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.Copier_ValueHolder<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_CustomException));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeBaseClass));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeSubClass));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_OtherSubClass));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Copier_SomeSubClassChild));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PooledBufferTests.Copier_LargeObject));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_EmptyAbstractRecord));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_DerivedFromEmptyAbstractRecord));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_NonEmptyAbstractRecord));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_DerivedFromNonEmptyAbstractRecord));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecordHierarchyDerived));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecordHierarchyMiddle));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_RecordHierarchyBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooWithListOfObject));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_TwoObjects));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooWithListOfFruit));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooWithListOfApple));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FruitRecord));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_AppleRecord));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_FooRecord));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_MyCompoundTypeAliasBaseClass));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Copier_MyCompoundTypeAliasClass));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequestBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestRequest<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestTaskRequest<>));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestTaskRequest));
            config.Copiers.Add(typeof(OrleansCodeGen.Orleans.Serialization.Invocation.Copier_UnitTestVoidRequest));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_Person));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_Person2));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_Person3));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_Person4));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_Person5));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_Person5_Class));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_MyValue));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_MyImmutableBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_MyMutableSub));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::MyImmutableSub>));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_MyMutableBase));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_MySealedSub));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::MySealedImmutableSub>));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_MyUnsealedImmutableSub));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_MySuppressReferenceTrackingValue));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_MyCustomException));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::MyCustomForeignExceptionSurrogate>));
            config.Copiers.Add(typeof(OrleansCodeGen.Copier_SomeClassWithSerializers));
            config.Copiers.Add(typeof(global::Orleans.Serialization.Cloning.ShallowCopier<global::UnitTests.SerializerExternalModels.Person2ExternalStruct>));
            config.Copiers.Add(typeof(OrleansCodeGen.UnitTests.SerializerExternalModels.Copier_GenericPersonExternalStruct<>));
            config.Copiers.Add(typeof(OrleansCodeGen.UnitTests.SerializerExternalModels.Copier_ReadonlyGenericPersonExternalStruct<>));
            config.Converters.Add(typeof(global::Orleans.Serialization.UnitTests.MyForeignLibraryTypeSurrogateConverter));
            config.Converters.Add(typeof(global::Orleans.Serialization.UnitTests.MyForeignLibraryValueTypeSurrogateConverter));
            config.Converters.Add(typeof(global::Orleans.Serialization.UnitTests.MyCombinedForeignLibraryValueTypeSurrogateConverter));
            config.Converters.Add(typeof(global::MyCustomForeignExceptionSurrogateConverter));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy_my_interface));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy__proxy_alias_test_));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy_test_IGenericProxyAliasTestGrain_3<,, >));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy_IG2<, >));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy_IG<>));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Root.Proxy_IA<,,, >));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy_IGrainWithGenericMethods));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy_IGenericGrainWithGenericMethods<>));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy_IRuntimeCodeGenGrain<>));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Proxy_INestedGenericGrain));
            config.InterfaceProxies.Add(typeof(OrleansCodeGen.Proxy_IHasNoNamespace));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.IMyInvokableBaseType));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<,, >));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.IG2<, >));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.IG<>));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.Root<>.IA<,, >));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<>));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<>));
            config.Interfaces.Add(typeof(global::Orleans.Serialization.UnitTests.INestedGenericGrain));
            config.Interfaces.Add(typeof(global::IHasNoNamespace));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.HalfOpenGrain1<>));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.HalfOpenGrain2<>));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.OpenGeneric<, >));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.ClosedGeneric));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.ClosedGenericWithManyInterfaces));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.G1<,,, >));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.Root<>.G<,, >));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.GrainWithGenericMethods));
            config.InterfaceImplementations.Add(typeof(global::Orleans.Serialization.UnitTests.NestedGenericGrain));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_TypeWithListBase));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_TypeWithCollectionBase));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_TypeWithDictionaryBase));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.DictionaryWithComparerCodecTests.Activator_CaseInsensitiveEqualityComparer));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_TypeWithHashSetBase));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_GenericGrainState<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_event));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_NestedGeneric<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NestedGeneric.Activator_Nested<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_NestedConstructedGeneric));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NestedConstructedGeneric.Activator_Nested<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_WrapsMyForeignLibraryType));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_DerivedFromMyForeignLibraryType));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_MyNonJsonBaseClass));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_RecursiveClass));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_SomeClassWithSerializers));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_PocoWithAutogeneratedIds));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_SerializableClassWithCompiledBase));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_GenericPoco<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_GenericPocoWithConstraint<, >));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Outer.Activator_InnerNonGen<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Outer.Activator_InnerGen<, >));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_ArrayPoco<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_SystemCollectionsClass));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_ClassWithLargeCollectionAndUri));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_ClassWithManualSerializableProperty));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_ClassWithTypeFields));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.NumericsWideningAndNarrowingTests.Activator_ValueHolder<>));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_CustomException));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Activator_SomeBaseClass));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Activator_SomeSubClass));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Activator_OtherSubClass));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.PolymorphismTests.Activator_SomeSubClassChild));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_FooWithListOfObject));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_TwoObjects));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_FooWithListOfFruit));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_FooWithListOfApple));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_MyCompoundTypeAliasBaseClass));
            config.Activators.Add(typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Activator_MyCompoundTypeAliasClass));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_Person5_Class));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_MyImmutableBase));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_MyMutableSub));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_MyImmutableSub));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_MyMutableBase));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_MySealedSub));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_MySealedImmutableSub));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_MyUnsealedImmutableSub));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_MyCustomException));
            config.Activators.Add(typeof(OrleansCodeGen.Activator_SomeClassWithSerializers));
            config.WellKnownTypeIds.Add(3201U, typeof(global::Orleans.Serialization.UnitTests.SomeClassWithSerializers));
            config.WellKnownTypeIds.Add(1000U, typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeBaseClass));
            config.WellKnownTypeIds.Add(1001U, typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClass));
            config.WellKnownTypeIds.Add(1002U, typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.OtherSubClass));
            config.WellKnownTypeIds.Add(1003U, typeof(global::Orleans.Serialization.UnitTests.PolymorphismTests.SomeSubClassChild));
            config.WellKnownTypeAliases.Add("_my_proxy_base_", typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase));
            config.WellKnownTypeAliases.Add("groan", typeof(global::Orleans.Serialization.UnitTests.AltInvokableProxyBase));
            config.WellKnownTypeAliases.Add("my_interface", typeof(global::Orleans.Serialization.UnitTests.IMyInvokableBaseType));
            config.WellKnownTypeAliases.Add("_proxy_alias_test_", typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain));
            config.WellKnownTypeAliases.Add("test.IGenericProxyAliasTestGrain`3", typeof(global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<,, >));
            config.WellKnownTypeAliases.Add("sercla1", typeof(global::Orleans.Serialization.UnitTests.SerializableClassWithCompiledBase));
            config.WellKnownTypeAliases.Add("gpoco`1", typeof(global::Orleans.Serialization.UnitTests.GenericPoco<>));
            config.WellKnownTypeAliases.Add("GenericPocoWithConstraint`2", typeof(global::Orleans.Serialization.UnitTests.GenericPocoWithConstraint<, >));
            config.WellKnownTypeAliases.Add("Orleans.Serialization.UnitTests.Outer.InnerNonGen`1", typeof(global::Orleans.Serialization.UnitTests.Outer<>.InnerNonGen));
            config.WellKnownTypeAliases.Add("Orleans.Serialization.UnitTests.Outer.InnerGen`2", typeof(global::Orleans.Serialization.UnitTests.Outer<>.InnerGen<>));
            config.WellKnownTypeAliases.Add("_custom_type_alias_", typeof(global::Orleans.Serialization.UnitTests.MyTypeAliasClass));
            config.WellKnownTypeAliases.Add("test.person.alias", typeof(global::Person));
            var n1 = config.CompoundTypeAliases.Add("inv");
            var n2 = n1.Add(typeof(global::Orleans.Serialization.UnitTests.MyInvokableProxyBase));
            var n3 = n2.Add(typeof(global::Orleans.Serialization.UnitTests.IProxyAliasTestGrain));
            n3.Add("125", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331));
            n3.Add("E8B1F331", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_E8B1F331));
            n3.Add("Method", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D));
            n3.Add("5C35143D", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_5C35143D));
            n3.Add("StringMethod", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1));
            n3.Add("140733F1", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_140733F1));
            n3.Add("MyOtherMethod", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55));
            n3.Add("FFED2C55", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IProxyAliasTestGrain_MyInvokableProxyBase_FFED2C55));
            var n12 = n2.Add(typeof(global::Orleans.Serialization.UnitTests.IGenericProxyAliasTestGrain<,, >));
            n12.Add("777", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<,,,,, >));
            n12.Add("E150EAD8", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericProxyAliasTestGrain_MyInvokableProxyBase_E150EAD8_6<,,,,, >));
            var n15 = n2.Add(typeof(global::Orleans.Serialization.UnitTests.IGrainWithGenericMethods));
            n15.Add("897D5539", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_897D5539_3<,, >));
            n15.Add("4A2D8354", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_4A2D8354_3<,, >));
            n15.Add("2CE0CA54", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_2CE0CA54_2<, >));
            n15.Add("C62BC31B", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_C62BC31B_1<>));
            n15.Add("60E98DC2", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_60E98DC2));
            n15.Add("CA65C468", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_CA65C468_1<>));
            n15.Add("EA8E38D2", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_EA8E38D2));
            n15.Add("48553A94", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_48553A94_1<>));
            n15.Add("7AA6BCD7", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGrainWithGenericMethods_MyInvokableProxyBase_7AA6BCD7));
            var n25 = n2.Add(typeof(global::Orleans.Serialization.UnitTests.IGenericGrainWithGenericMethods<>));
            n25.Add("750C249C", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_750C249C_1<>));
            n25.Add("2C5E9318", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IGenericGrainWithGenericMethods_MyInvokableProxyBase_2C5E9318_2<, >));
            var n28 = n2.Add(typeof(global::Orleans.Serialization.UnitTests.IRuntimeCodeGenGrain<>));
            n28.Add("D3CF5E24", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_D3CF5E24_1<>));
            n28.Add("F9B2D902", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_IRuntimeCodeGenGrain_MyInvokableProxyBase_F9B2D902_1<>));
            var n31 = n2.Add(typeof(global::Orleans.Serialization.UnitTests.INestedGenericGrain));
            n31.Add("5EE6D1DA", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_5EE6D1DA));
            n31.Add("C878BCCA", typeof(OrleansCodeGen.Orleans.Serialization.UnitTests.Invokable_INestedGenericGrain_MyInvokableProxyBase_C878BCCA));
            var n34 = config.CompoundTypeAliases.Add("xx_test_xx");
            var n35 = n34.Add(typeof(global::Orleans.Serialization.UnitTests.MyTypeAliasClass));
            var n36 = n35.Add(typeof( int ));
            n36.Add("1", typeof(global::Orleans.Serialization.UnitTests.MyCompoundTypeAliasClass));
        }
    }
}
#pragma warning restore CS1591, RS0016, RS0041
